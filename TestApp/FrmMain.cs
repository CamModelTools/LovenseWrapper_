using LovenseWrapper;
using LovenseWrapper.CLovenseToy;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TestApp
{
    public partial class FrmMain : Form
    {
        private static readonly CLovenseToyManager Ltm = Lovense.GetLovenseToyManager();

        private static ToyCommand ActualToyCommand = new ToyCommand();
        private static readonly List<AvailableToy> AvailableToys = new List<AvailableToy>();
        private static DateTime CmdStartTime = DateTime.Now;
        private static readonly List<ToyCommand> ToyCommands = new List<ToyCommand>();
        private static readonly List<ToyCommand> AvailableCommands = new List<ToyCommand>();
        private readonly LovenseNotify LovenseCallback = new LovenseNotify();
        public FrmMain()
        {
            InitializeComponent();
            // Expand the possibel Commands and add some more attributes and store them in a list ...
            foreach (CmdType cmdType in Enum.GetValues(typeof(CmdType)))
            {
                ToyCommand toyCommand = new ToyCommand
                {
                    CmdType = cmdType,
                    CmdName = cmdType.ToString(),
                    ParmFrom = 0
                };
                if (cmdType == CmdType.COMMAND_UNKNOWN)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = (LVSToyType[])Enum.GetValues(typeof(LVSToyType));
                }
                else if (cmdType == CmdType.COMMAND_CONNECT_TOY)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = (LVSToyType[])Enum.GetValues(typeof(LVSToyType));
                }
                else if (cmdType == CmdType.COMMAND_DISCONNECT_TOY)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = (LVSToyType[])Enum.GetValues(typeof(LVSToyType));
                }
                else if (cmdType == CmdType.COMMAND_VIBRATE)
                {
                    toyCommand.ParmTo = 20;
                    toyCommand.ToyTypes = (LVSToyType[])Enum.GetValues(typeof(LVSToyType));
                }
                else if (cmdType == CmdType.COMMAND_ROTATE)
                {
                    toyCommand.ParmTo = 20;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_NORA;
                }
                else if (cmdType == CmdType.COMMAND_ROTATE_CLOCKWISE)
                {
                    toyCommand.ParmTo = 20;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_NORA;
                }
                else if (cmdType == CmdType.COMMAND_ROTATE_ANTI_CLOCKWISE)
                {
                    toyCommand.ParmTo = 20;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_NORA;
                }
                else if (cmdType == CmdType.COMMAND_ROTATE_CHANGE)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_NORA;
                }
                else if (cmdType == CmdType.COMMAND_VIBRATE1)
                {
                    toyCommand.ParmTo = 20;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_EDGE;
                }
                else if (cmdType == CmdType.COMMAND_VIBRATE2)
                {
                    toyCommand.ParmTo = 20;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_EDGE;
                }
                else if (cmdType == CmdType.COMMAND_VIBRATE_FLASH)
                {
                    toyCommand.ParmTo = 20;
                    toyCommand.ToyTypes = new LVSToyType[3];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_AMBI;
                    toyCommand.ToyTypes[1] = LVSToyType.LVS_DOMI;
                    toyCommand.ToyTypes[2] = LVSToyType.LVS_OSCI;
                }
                else if (cmdType == CmdType.COMMAND_FLASH)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = (LVSToyType[])Enum.GetValues(typeof(LVSToyType));
                }
                else if (cmdType == CmdType.COMMAND_LIGHT_OFF)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = new LVSToyType[3];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_LUSH;
                    toyCommand.ToyTypes[1] = LVSToyType.LVS_HUSH;
                    toyCommand.ToyTypes[2] = LVSToyType.LVS_EDGE;
                }
                else if (cmdType == CmdType.COMMAND_LIGHT_ON)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = new LVSToyType[3];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_LUSH;
                    toyCommand.ToyTypes[1] = LVSToyType.LVS_HUSH;
                    toyCommand.ToyTypes[2] = LVSToyType.LVS_EDGE;
                }
                else if (cmdType == CmdType.COMMAND_GET_LIGHT_STATUS)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = new LVSToyType[3];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_LUSH;
                    toyCommand.ToyTypes[1] = LVSToyType.LVS_HUSH;
                    toyCommand.ToyTypes[2] = LVSToyType.LVS_EDGE;
                }
                else if (cmdType == CmdType.COMMAND_ALIGHT_OFF)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_DOMI;
                }
                else if (cmdType == CmdType.COMMAND_ALIGHT_ON)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_DOMI;
                }
                else if (cmdType == CmdType.COMMAND_GET_ALIGHT_STATUS)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_DOMI;
                }
                else if (cmdType == CmdType.COMMAND_GET_BATTERY)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = (LVSToyType[])Enum.GetValues(typeof(LVSToyType));
                }
                else if (cmdType == CmdType.COMMAND_GET_DEVICE_TYPE)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = (LVSToyType[])Enum.GetValues(typeof(LVSToyType));
                }
                else if (cmdType == CmdType.COMMAND_AIR_IN)
                {
                    toyCommand.ParmTo = 3;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_MAX;
                }
                else if (cmdType == CmdType.COMMAND_AIR_OUT)
                {
                    toyCommand.ParmTo = 3;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_MAX;
                }
                else if (cmdType == CmdType.COMMAND_AIR_AUTO)
                {
                    toyCommand.ParmTo = 3;
                    toyCommand.ToyTypes = new LVSToyType[1];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_MAX;
                }
                else if (cmdType == CmdType.COMMAND_START_MOVE)
                {
                    toyCommand.ParmTo = 4;
                    toyCommand.ToyTypes = new LVSToyType[2];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_MAX;
                    toyCommand.ToyTypes[1] = LVSToyType.LVS_NORA;
                }
                else if (cmdType == CmdType.COMMAND_STOP_MOVE)
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = new LVSToyType[2];
                    toyCommand.ToyTypes[0] = LVSToyType.LVS_MAX;
                    toyCommand.ToyTypes[1] = LVSToyType.LVS_NORA;
                }
                else
                {
                    toyCommand.ParmTo = 0;
                    toyCommand.ToyTypes = (LVSToyType[])Enum.GetValues(typeof(LVSToyType));
                }
                ToyCommands.Add(toyCommand);
            }

            // Register the callback method to the LovenseToyManager (Ltm) ...
            Ltm.RegisterEventCallBack(LovenseCallback);
            // Define some special event handlers to communicate from the LTM callback ...
            LogTxtChanged += FrmMain_LogTxtChanged;
            ToySearchStarted += FrmMain_SearchingToys;
            ToyConnected += FrmMain_ConnectingToys;
            ToyFound += FrmMain_ToyFound;
        }

        private static event EventHandler LogTxtChanged;

        private static event EventHandler ToyConnected;

        private static event EventHandler ToyFound;

        private static event EventHandler ToySearchStarted;

        private void BtnConnectToToy_Click(object sender, EventArgs e)
        {
            if (CmbToys.Text != String.Empty)
            {
                Ltm.ConnectToToy(AvailableToys[CmbToys.SelectedIndex].ToyId);
            }
        }

        private void BtnDisconnectFromToy_Click(object sender, EventArgs e)
        {
            Ltm.DisConnectedToy(AvailableToys[CmbToys.SelectedIndex].ToyId);
        }

        private void BtnFlash_Click(object sender, EventArgs e)
        {
            if (CmbToys.Text != String.Empty)
            {
                Ltm.SendCommand(AvailableToys[CmbToys.SelectedIndex].ToyId, CmdType.COMMAND_FLASH, 0);
            }
        }

        private void BtnGetBattery_Click(object sender, EventArgs e)
        {
            int batteryLevel = 0;
            _ = Ltm.GetToyBattery(AvailableToys[CmbToys.SelectedIndex].ToyId, ref batteryLevel);
            TxbLog.AppendText("Battery Level of " + CmbToys.Text + " is: " + batteryLevel.ToString() + "%" + Environment.NewLine);
            PgbBatteryLevel.Value = batteryLevel;
            if (batteryLevel > 55)
            {
                LblBatteryLevel.ForeColor = Color.Green;
            }
            else if (batteryLevel > 10)
            {
                LblBatteryLevel.ForeColor = Color.Orange;
            }
            else
            {
                LblBatteryLevel.ForeColor = Color.Red;
            }
            LblBatteryLevel.Text = "Battery Level of " + AvailableToys[CmbToys.SelectedIndex].ToyType + " (" + AvailableToys[CmbToys.SelectedIndex].ToyId + ") is: " + batteryLevel.ToString() + "%";
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            Ltm.SendCommand(AvailableToys[CmbToys.SelectedIndex].ToyId, ActualToyCommand.CmdType, TrbLevel.Value);
        }

        private void BtnPowerOff_Click(object sender, EventArgs e)
        {
            Ltm.SendCommand(AvailableToys[CmbToys.SelectedIndex].ToyId, CmdType.COMMAND_POWER_OFF, 0);
        }

        private void BtnSearchToys_Click(object sender, EventArgs e)
        {
            // Insert here your developer token ...
            bool tokenIsValid = Ltm.SetDeveloperToken("AUoSrvCL-poWB__NNnw3cgeE7hSeE_GAbMsRjCcULr_ihMdh9w__fhJtCswknST8");
            TxbLog.Clear();
            if (tokenIsValid)
            {
                BtnSearchToys.Enabled = false;
                Ltm.StartSearchToy();
            }
        }

        private void BtnStopSearch_Click(object sender, EventArgs e)
        {
            _ = Ltm.StopSearchToy;
        }

        private void CmbCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualToyCommand = AvailableCommands[CmbCommands.SelectedIndex];
            if (ActualToyCommand.ParmTo > 0)
            {
                BtnGo.Enabled = false;
                TrbLevel.Enabled = true;
            }
            else
            {
                BtnGo.Enabled = true;
                TrbLevel.Enabled = false;
            }

            TrbLevel.Maximum = ActualToyCommand.ParmTo;
        }

        private void CmbToys_SelectedIndexChanged(object sender, EventArgs e)
        {
            // these strings are only to show the structure of the Combobox entries ... 
            // Setting the availabilty of several controls according to the connection status of the selected toy ...
            bool toyIsConnected = AvailableToys[CmbToys.SelectedIndex].ToyIsConnected;
            BtnConnectToToy.Enabled = !toyIsConnected;
            BtnDisconnectFromToy.Enabled = toyIsConnected;
            BtnFlash.Enabled = toyIsConnected;
            GpbToyCommands.Enabled = toyIsConnected;
            BtnGetBattery.Enabled = toyIsConnected;
            BtnGo.Enabled = toyIsConnected;
            BtnPowerOff.Enabled = toyIsConnected;
            // Add the commands to the combobox, limited to the possible commands available for the toy type ...
            CmbCommands.Items.Clear();
            AvailableCommands.Clear();
            foreach (ToyCommand toyCommand in ToyCommands)
            {
                foreach (LVSToyType type in toyCommand.ToyTypes)
                {
                    if (type.ToString() == AvailableToys[CmbToys.SelectedIndex].ToyType)
                    {
                        AvailableCommands.Add(toyCommand);
                        CmbCommands.Items.Add(toyCommand.CmdName);
                        break;
                    }
                }
            }
        }

        private void FrmMain_ConnectingToys(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(delegate
            {
                // If the status of connection of a toy changes all entries get reload ...
                int selectedIndex = CmbToys.SelectedIndex;
                CmbToys.Items.Clear();
                PbxToy.Image = null;
                BtnStatus.BackColor = Color.Transparent;
                foreach (AvailableToy availableToy in AvailableToys)
                {
                    string item = availableToy.ToyName + ":" + availableToy.ToyId + ":" + availableToy.ToyType + ":" + availableToy.ToyIsConnected.ToString();
                    CmbToys.Items.Add(item);
                    TxbToysCount.Text = CmbToys.Items.Count.ToString();
                }
                if (CmbToys.Items.Count - 1 < selectedIndex)
                {
                    selectedIndex = CmbToys.Items.Count - 1;
                }
                CmbToys.SelectedIndex = selectedIndex;
            }));
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Disconnect all connected toys ...
            foreach (AvailableToy availableToy in AvailableToys)
            {
                if (availableToy.ToyIsConnected)
                {
                    Ltm.DisConnectedToy(availableToy.ToyId);
                }
            }
            // ESSENTIAL! Because the original native-sdk is completely unmanaged code.
            // This ensures all pointers get reset and ressources get freed!
            Lovense.ReleaseLovenseToyManager();
            Ltm.Dispose();
        }

        private void FrmMain_LogTxtChanged(object sender, EventArgs e)
        {
            // Add a line in log ... gets called from the Ltm callback method ...
            Invoke(new MethodInvoker(delegate
            {
                TxbLog.AppendText(((LovenseNotify)sender).LogTxt + Environment.NewLine);
            }));
        }

        private void FrmMain_SearchingToys(object sender, EventArgs e)
        {
            // List all found toys during search ...
            Invoke(new MethodInvoker(delegate
            {
                bool searchingToys = ((LovenseNotify)sender).SearchingToys;
                if (searchingToys)
                {
                    CmbToys.Items.Clear();
                    AvailableToys.Clear();
                }
                else
                {
                    if (CmbToys.Items.Count > 0)
                    {
                        CmbToys.SelectedIndex = 0;
                    }
                    if (CmbCommands.Items.Count > 0)
                    {
                        CmbCommands.SelectedIndex = 3;
                    }
                }
                BtnSearchToys.Enabled = !searchingToys;
                GpbConnectToys.Enabled = !searchingToys;
                CmbToys.Enabled = !searchingToys;
                CmbCommands.Enabled = !searchingToys;
                BtnConnectToToy.Enabled = !searchingToys;
                BtnStopSearch.Enabled = searchingToys;
            }));
        }

        private void FrmMain_ToyFound(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(delegate
            {
                CmbToys.Items.Add(((LovenseNotify)sender).ToyData);
                TxbToysCount.Text = CmbToys.Items.Count.ToString();
            }));
        }

        private void TrbLevel_Scroll(object sender, EventArgs e)
        {
            if (CmbCommands.Text != string.Empty && ActualToyCommand.ParmTo > 0)
            {
                Ltm.SendCommand(AvailableToys[CmbToys.SelectedIndex].ToyId, ActualToyCommand.CmdType, TrbLevel.Value);
                TxbLevel.Text = TrbLevel.Value.ToString();
            }
        }

        private class AvailableToy
        {
            public string ToyId { get; set; }
            public bool ToyIsConnected { get; set; }
            public string ToyName { get; set; }
            public string ToyType { get; set; }
        }

        private class LovenseNotify : ILovenseSDKNotify
        {
            private string _logTxt;

            private bool _ToyConnected;

            private string _ToyData;

            private bool _ToySearchStarted;

            public bool Connected
            {
                get
                {
                    return _ToyConnected;
                }

                set
                {
                    _ToyConnected = value;
                    OnToyConnected();
                }
            }

            public string LogTxt
            {
                get
                {
                    return _logTxt;
                }

                set
                {
                    _logTxt = value;
                    OnLogTxtChanged();
                }
            }
            public bool SearchingToys
            {
                get
                {
                    return _ToySearchStarted;
                }

                set
                {
                    _ToySearchStarted = value;
                    OnToySearchStarted();
                }
            }

            public string ToyData
            {
                get
                {
                    return _ToyData;
                }

                set
                {
                    _ToyData = value;
                    OnToyFound();
                }
            }
            public override void LovenseDidSearchEnd()
            {
                LogTxt = "Seach for Lovense Toys ended ...";
                SearchingToys = false;
            }

            public override void LovenseDidSearchStart()
            {
                LogTxt = "Seach for Lovense Toys started ...";
                SearchingToys = true;
            }

            public override void LovenseDidSendCmdEnd()
            {
                LogTxt = "Sending command to toy ended after: " + (DateTime.Now - CmdStartTime)
                    .Seconds
                    .ToString() + "," + (DateTime.Now - CmdStartTime)
                    .Milliseconds.ToString() + " seconds";
            }

            public override void LovenseDidSendCmdStart()
            {
                CmdStartTime = DateTime.Now;
                LogTxt = "Sending command to toy started ...";
            }

            public override void LovenseErrorOutPut(int errorCode, string errorMsg)
            {
                LogTxt = "Error from toy, Code: " + errorCode.ToString() + ", Msg: " + errorMsg;
            }

            public override void LovenseSearchingToys(StLovenseToyInfo info)
            {
                LogTxt = "ToyType     : " + info.ToyTypeStr();
                LogTxt = "ToyName     : " + info.ToyNameStr();
                LogTxt = "ToyID       : " + info.ToyIdStr();
                LogTxt = "ToyConnected: " + info.ToyConnected.ToString();
                ToyData = info.ToyNameStr() + ":" + info.ToyIdStr() + ":" + info.ToyTypeStr() + ":" + info.ToyConnected.ToString();
                AvailableToy availableToy = new AvailableToy
                {
                    ToyId = info.ToyIdStr(),
                    ToyName = info.ToyNameStr(),
                    ToyType = info.ToyTypeStr(),
                    ToyIsConnected = info.ToyConnected
                };
                AvailableToys.Add(availableToy);
                info.Dispose();
            }

            public override void LovenseSendCmdResult(string szToyID, CmdType cmd, string result, Error errorCode)
            {
                LogTxt = "CmdResult: " + szToyID + " " + result;
                LogTxt = "  Command: " + cmd;
                LogTxt = "  ErrCode: " + errorCode;
                // Remove powered-off toys from list of available toys ...
                if (cmd == CmdType.COMMAND_POWER_OFF)
                {
                    AvailableToy activeToy = new AvailableToy();
                    foreach (AvailableToy availableToy in AvailableToys)
                    {
                        if (availableToy.ToyId == szToyID)
                        {
                            activeToy = availableToy;
                            break;
                        }
                    }
                    AvailableToys.Remove(activeToy);
                    // Trigger refresh of ComboBox CmbToys ...
                    Connected = false;
                }
            }

            public override void LovenseToyConnectedStatus(string szToyID, bool isConnected)
            {
                LogTxt = "ConnStatus: " + szToyID + " " + isConnected.ToString();
                int i = 0;
                foreach (var availableToy in AvailableToys)
                {
                    if (availableToy.ToyId == szToyID)
                    {
                        availableToy.ToyIsConnected = isConnected;
                    }
                    i++;
                }
                // Trigger refresh of ComboBox CmbToys ...
                Connected = isConnected;
            }

            protected virtual void OnLogTxtChanged()
            {
                LogTxtChanged?.Invoke(this, EventArgs.Empty);
            }

            protected virtual void OnToyConnected()
            {
                ToyConnected?.Invoke(this, EventArgs.Empty);
            }

            protected virtual void OnToyFound()
            {
                ToyFound?.Invoke(this, EventArgs.Empty);
            }

            protected virtual void OnToySearchStarted()
            {
                ToySearchStarted?.Invoke(this, EventArgs.Empty);
            }
        }

        private class ToyCommand
        {
            public string CmdName { get; set; }
            public CmdType CmdType { get; set; }
            public int ParmFrom { get; set; }
            public int ParmTo { get; set; }

            public LVSToyType[] ToyTypes { get; set; }
        }

        private void CmbToys_TextChanged(object sender, EventArgs e)
        {
            string toyType = CmbToys.Text.Split(":")[2];
            bool toyIsConnected = AvailableToys[CmbToys.SelectedIndex].ToyIsConnected;

            // try to find a picture of the toy type and show it ... 
            if (toyType.Contains("AMBI", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[0];
            }
            else if (toyType.Contains("CALOR", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[1];
            }
            else if (toyType.Contains("DIAMO", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[2];
            }
            else if (toyType.Contains("DOLCE", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[3];
            }
            else if (toyType.Contains("DOMI", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[4];
            }
            else if (toyType.Contains("EDGE", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[5];
            }
            else if (toyType.Contains("EXOMOON", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[6];
            }
            else if (toyType.Contains("FERRI", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[7];
            }
            else if (toyType.Contains("GUSH", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[8];
            }
            else if (toyType.Contains("HYPHY", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[9];
            }
            else if (toyType.Contains("HUSH", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[10];
            }
            else if (toyType.Contains("LUSH", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[11];
            }
            else if (toyType.Contains("MAX", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[12];
            }
            else if (toyType.Contains("MISSION", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[13];
            }
            else if (toyType.Contains("NORA", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[14];
            }
            else if (toyType.Contains("OSCI", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[15];
            }
            else if (toyType.Contains("XMACHINE", StringComparison.OrdinalIgnoreCase))
            {
                PbxToy.Image = ImlToyIcons.Images[16];
            }
            else
            {
                PbxToy.Image = null;
            }

            // visualize the connection status ...
            if (toyIsConnected)
            {
                BtnStatus.BackColor = Color.Green;
            }
            else
            {
                BtnStatus.BackColor = Color.Red;
            }
        }
    }
}