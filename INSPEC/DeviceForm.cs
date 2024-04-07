using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using InTheHand.Bluetooth;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace lucidcode.LucidScribe.Plugin.INSPEC
{
    public partial class DeviceForm : Form
    {
        public string SelectedDevice = "";
        public string Algorithm = "Motion Detection";
        public int Threshold = 600;
        public string DeviceName = "INSPEC";
        public string ServiceUuid = "13370001-763c-4507-99fb-100f72f2300a";
        public string CharacteristicUuid = "13370003-763c-4507-99fb-100f72f2300a";

        private bool loaded = false;
        private string m_strPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\lucidcode\\Lucid Scribe\\";

        public static List<BluetoothDevice> BleDevicesList = new List<BluetoothDevice>();
        public List<BluetoothDevice> BleDevices = new List<BluetoothDevice>();

        public DeviceForm()
        {
            InitializeComponent();
        }

        private void PortForm_Load(object sender, EventArgs e)
        {
            LoadSettings();

            loaded = true;
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            startScan();
        }

        private void startScan()
        {
            lstDevices.Items.Clear();
            var listViewItem = new ListViewItem("Scanning...");
            lstDevices.Items.Add(listViewItem);

            var searchThread = new Thread(() => Search(DeviceName, ServiceUuid, CharacteristicUuid));
            searchThread.Start();
        }

        private void Search(string deviceName, string serviceUuid, string characteristicUuid)
        {
            var discoveryTask = DiscoverDevices(deviceName, serviceUuid, characteristicUuid);
            discoveryTask.Wait();
            BleDevices = BleDevicesList;
            ListDevices();
        }

        private static async Task<bool> DiscoverDevices(string deviceName, string serviceUuid, string characteristicUuid)
        {
            var requestDeviceOptions = new RequestDeviceOptions();

            if (!string.IsNullOrEmpty(deviceName))
            {
                var nameFilter = new BluetoothLEScanFilter();
                nameFilter.Name = deviceName;
                requestDeviceOptions.Filters.Add(nameFilter);
            }
            if (!string.IsNullOrEmpty(serviceUuid))
            {
                var serviceFilter = new BluetoothLEScanFilter();
                serviceFilter.Services.Add(BluetoothUuid.FromGuid(new Guid(serviceUuid)));
                requestDeviceOptions.Filters.Add(serviceFilter);
            }

            var Devices = await Bluetooth.ScanForDevicesAsync(requestDeviceOptions);
            BleDevicesList = Devices.ToList();
            return Devices?.Count > 0;
        }

        private void ListDevices()
        {
            if (this.InvokeRequired == true)
            {
                this.BeginInvoke(new MethodInvoker(delegate { ListDevices(); }));
                return;
            }

            lstDevices.Items.Clear();
            foreach (var bleDevice in BleDevices)
            {
                var listViewItem = new ListViewItem(bleDevice.Name + " " + bleDevice.Id);
                listViewItem.ImageIndex = 0;
                lstDevices.Items.Add(listViewItem);
            }
        }

        private void LoadSettings()
        {
            var settingsDocument = new XmlDocument();

            if (!File.Exists(m_strPath + "Plugins\\INSPEC.User.lsd"))
            {
                var @default = "<LucidScribeData>";
                @default += "<Plugin>";
                @default += "<Algorithm>" + Algorithm + "</Algorithm>";
                @default += "<Threshold>" + Threshold + "</Threshold>";
                @default += "<DeviceName>" + DeviceName + "</DeviceName>";
                @default += "<ServiceUuid>" + ServiceUuid + "</ServiceUuid>";
                @default += "<CharacteristicUuid>" + CharacteristicUuid + "</CharacteristicUuid>";
                @default += "</Plugin>";
                @default += "</LucidScribeData>";
                File.WriteAllText(m_strPath + "Plugins\\INSPEC.User.lsd", @default);
            }

            settingsDocument.Load(m_strPath + "Plugins\\INSPEC.User.lsd");

            algorithmCombo.Text = settingsDocument.DocumentElement.SelectSingleNode("//Algorithm").InnerText;
            thresholdText.Text = settingsDocument.DocumentElement.SelectSingleNode("//Threshold").InnerText;
            deviceNameText.Text = settingsDocument.DocumentElement.SelectSingleNode("//DeviceName").InnerText;
            serviceUuidText.Text = settingsDocument.DocumentElement.SelectSingleNode("//ServiceUuid").InnerText;
            characteristicUuidText.Text = settingsDocument.DocumentElement.SelectSingleNode("//CharacteristicUuid").InnerText;
        }

        private void cmbAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loaded) { return; }
            Algorithm = algorithmCombo.Text;
            SaveSettings();
        }

        private void SaveSettings()
        {
            var settings = "<LucidScribeData>";
            settings += "<Plugin>";
            settings += "<Algorithm>" + algorithmCombo.Text + "</Algorithm>";
            settings += "<Threshold>" + thresholdText.Text + "</Threshold>";
            settings += "<DeviceName>" + deviceNameText.Text + "</DeviceName>";
            settings += "<ServiceUuid>" + serviceUuidText.Text + "</ServiceUuid>";
            settings += "<CharacteristicUuid>" + characteristicUuidText.Text + "</CharacteristicUuid>";
            settings += "</Plugin>";
            settings += "</LucidScribeData>";
            File.WriteAllText(m_strPath + "Plugins\\INSPEC.User.lsd", settings);
        }

        private void lstDevices_MouseMove(object sender, MouseEventArgs e)
        {
            if (lstDevices.GetItemAt(e.X, e.Y) != null)
            {
                lstDevices.Cursor = Cursors.Hand;
            }
            else
            {
                lstDevices.Cursor = Cursors.Default;
            }
        }

        private void lstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDevices.SelectedItems.Count > 0)
            {
                SelectedDevice = lstDevices.SelectedItems[0].Text;

                if (SelectedDevice == "Scanning...")
                {
                    return;
                }

                SaveSettings();

                var deviceNames = lstDevices.SelectedItems[0].Text.Split(' ');
                SelectedDevice = deviceNames[deviceNames.Length - 1];
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void mnuRefresh_Click(object sender, EventArgs e)
        {
            startScan();
        }

        private void txtThreshold_TextChanged(object sender, EventArgs e)
        {
            if (!loaded) { return; }
            Threshold = Convert.ToInt32(thresholdText.Text);
            SaveSettings();
        }

        private void deviceNameText_TextChanged(object sender, EventArgs e)
        {
            if (!loaded) { return; }
            DeviceName = deviceNameText.Text;
            SaveSettings();
        }

        private void serviceUuidText_TextChanged(object sender, EventArgs e)
        {
            if (!loaded) { return; }
            ServiceUuid = serviceUuidText.Text;
            SaveSettings();
        }

        private void characteristicUuidText_TextChanged(object sender, EventArgs e)
        {
            if (!loaded) { return; }
            CharacteristicUuid = characteristicUuidText.Text;
            SaveSettings();
        }
    }
}
