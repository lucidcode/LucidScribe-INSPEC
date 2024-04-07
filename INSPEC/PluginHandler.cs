using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using InTheHand.Bluetooth;
using System.Threading.Tasks;
using System.Linq;

namespace lucidcode.LucidScribe.Plugin.INSPEC
{
    public static class Device
    {
        public static string Algorithm = "REM Detection";
        public static int Threshold = 600;
        public static string ServiceUuid;
        public static string CharacteristicUuid;

        public static EventHandler<EventArgs> ValueChanged;

        static bool Initialized;
        static bool InitError;
        static decimal bleValue;
        static bool clearValue;

        static int ticks;

        static string DeviceId = "";
        static BluetoothDevice BleDevice;
        private static List<BluetoothDevice> BleDevices;

        public static Boolean Initialize()
        {
            if (!Initialized & !InitError)
            {
                var deviceForm = new DeviceForm();
                if (deviceForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Algorithm = deviceForm.Algorithm;
                        Threshold = deviceForm.Threshold;
                        DeviceId = deviceForm.SelectedDevice;
                        BleDevices = deviceForm.BleDevices;
                        ServiceUuid = deviceForm.ServiceUuid;
                        CharacteristicUuid = deviceForm.CharacteristicUuid;

                        ConnectDevice();
                    }
                    catch (Exception ex)
                    {
                        if (!InitError)
                        {
                            MessageBox.Show(ex.Message, "LucidScribe.InitializePlugin()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        InitError = true;
                    }
                }
                else
                {
                    InitError = true;
                    return false;
                }

                Initialized = true;
            }
            return true;
        }

        private static async Task<bool> ConnectDevice()
        {
            BleDevice = BleDevices.Where(b => b.Id == DeviceId).FirstOrDefault();

            var gatt = BleDevice.Gatt;
            await gatt.ConnectAsync();

            var services = await gatt.GetPrimaryServicesAsync();
            foreach (var service in services)
            {
                if (!string.IsNullOrEmpty(ServiceUuid) && ServiceUuid.ToUpper() != service.Uuid.ToString().ToUpper())
                {
                    continue;
                }

                var characteristics = await service.GetCharacteristicsAsync();

                foreach (var characteristic in characteristics)
                {
                    if (!string.IsNullOrEmpty(CharacteristicUuid) && CharacteristicUuid.ToUpper() != characteristic.Uuid.ToString().ToUpper())
                    {
                        continue;
                    }

                    if (characteristic.Properties.HasFlag(GattCharacteristicProperties.Notify))
                    {
                        characteristic.CharacteristicValueChanged += Characteristic_CharacteristicValueChanged;
                        await characteristic.StartNotificationsAsync();
                    }
                }
            }
            return true;
        }

        private static void Characteristic_CharacteristicValueChanged(object sender, GattCharacteristicValueChangedEventArgs e)
        {
            //var value = random.Next(500, 550);

            if (e.Error != null)
            {
                if (!InitError)
                {
                    MessageBox.Show(e.Error.Message, "LucidScribe.Plugin.CharacteristicValueChanged()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                InitError = true;
                return;
            }

            var valueString = Encoding.UTF8.GetString(e.Value);
            var value = Convert.ToDecimal(valueString);

            if (ValueChanged != null)
            {
                ValueChanged((object)value, null);
            }

            if (clearValue)
            {
                clearValue = false;
                bleValue = 0;
                ticks = 0;
            }

            bleValue += value;
            ticks++;
        }

        public static void Dispose()
        {
            if (Initialized)
            {
                Initialized = false;
            }
        }

        public static Double GetValue()
        {
            if (ticks == 0) return 0;
            return (double)(bleValue / ticks);
        }

        public static void ClearValue()
        {
            clearValue = true;
        }
    }

    namespace INSPEC
    {
        public class PluginHandler : Interface.LucidPluginBase
        {

            public override string Name
            {
                get
                {
                    return "INSPEC";
                }
            }

            public override bool Initialize()
            {
                try
                {
                    return Device.Initialize();
                }
                catch (Exception ex)
                {
                    throw (new Exception("The '" + Name + "' plugin failed to initialize: " + ex.Message));
                }
            }

            public override double Value
            {
                get
                {
                    var value = Device.GetValue();
                    Device.ClearValue();
                    if (value > 999) { value = 999; }
                    if (value < 0) { value = 0; }
                    return value;
                }
            }

            public override void Dispose()
            {
                Device.Dispose();
            }
        }
    }

    namespace RAW
    {
        public class PluginHandler : Interface.ILluminatedPlugin
        {
            public string Name
            {
                get
                {
                    return "INSPEC RAW";
                }
            }

            public bool Initialize()
            {
                try
                {
                    bool initialized = Device.Initialize();
                    Device.ValueChanged += ValueChanged;
                    return initialized;
                }
                catch (Exception ex)
                {
                    throw (new Exception("The '" + Name + "' plugin failed to initialize: " + ex.Message));
                }
            }

            public event Interface.SenseHandler Sensed;
            public void ValueChanged(object sender, EventArgs e)
            {
                if (ClearTicks)
                {
                    ClearTicks = false;
                    TickCount = "";
                }
                TickCount += sender + ",";

                if (ClearBuffer)
                {
                    ClearBuffer = false;
                    BufferData = "";
                }
                BufferData += sender + ",";
            }

            public void Dispose()
            {
                Device.ValueChanged -= ValueChanged;
                Device.Dispose();
            }

            public Boolean isEnabled = false;
            public Boolean Enabled
            {
                get
                {
                    return isEnabled;
                }
                set
                {
                    isEnabled = value;
                }
            }

            public Color PluginColor = Color.White;
            public Color Color
            {
                get
                {
                    return Color;
                }
                set
                {
                    Color = value;
                }
            }

            private Boolean ClearTicks = false;
            public String TickCount = "";
            public String Ticks
            {
                get
                {
                    ClearTicks = true;
                    return TickCount;
                }
                set
                {
                    TickCount = value;
                }
            }

            private Boolean ClearBuffer = false;
            public String BufferData = "";
            public String Buffer
            {
                get
                {
                    ClearBuffer = true;
                    return BufferData;
                }
                set
                {
                    BufferData = value;
                }
            }

            int lastHour;
            public int LastHour
            {
                get
                {
                    return lastHour;
                }
                set
                {
                    lastHour = value;
                }
            }
        }
    }

    namespace REM
    {
        public class PluginHandler : lucidcode.LucidScribe.Interface.LucidPluginBase
        {

            static int TicksSinceLastArtifact = 0;
            static int TicksAbove = 0;

            public override string Name
            {
                get
                {
                    return "INSPEC REM";
                }
            }

            public override bool Initialize()
            {
                try
                {
                    return Device.Initialize();
                }
                catch (Exception ex)
                {
                    throw (new Exception("The '" + Name + "' plugin failed to initialize: " + ex.Message));
                }
            }

            List<int> m_arrHistory = new List<int>();

            public override double Value
            {
                get
                {
                    if (Device.Algorithm == "Motion Detection")
                    {
                        if (Device.GetValue() > Device.Threshold)
                        {
                            TicksAbove++;
                            if (TicksAbove > 5)
                            {
                                TicksAbove = 0;
                                TicksSinceLastArtifact = 0;
                                if (TicksSinceLastArtifact > 19200)
                                {
                                    return 888;
                                }
                            }
                        }

                        TicksSinceLastArtifact++;
                        return 0;
                    }

                    return 0;
                }
            }

            public override void Dispose()
            {
                Device.Dispose();
            }
        }
    }
}
