using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Rapid_Trigger_Config.Settings;
using static Rapid_Trigger_Config.App;
using Newtonsoft.Json.Linq;
using System.IO.Ports;
using System.Threading;


namespace Rapid_Trigger_Config
{
    public partial class Form1 : Form
    {

        private ConnectDevice connectDeviceForm;

        #region Startup

        public Form1()
        {
            InitializeComponent();
            InitializeDeviceCheckTimer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SerialPort1.NewLine = "\r\n";
            SerialPort1.ReadTimeout = 5000;
            SerialPort1.RtsEnable = true;
            SerialPort1.DtrEnable = true;

            if (!IsDeviceConnected)
            {
                this.Hide();
                ShowConnectDeviceForm();
            }

            barActuationPoint.Scroll += new EventHandler(Slider_Scroll);
            barRTSensitivity.Scroll += new EventHandler(Slider_Scroll);
        }

        private void ShowConnectDeviceForm()
        {
            if (connectDeviceForm == null || connectDeviceForm.IsDisposed)
            {
                connectDeviceForm = new ConnectDevice();
                connectDeviceForm.ShowDialog();
            }
            else if (!connectDeviceForm.Visible)
            {
                connectDeviceForm.ShowDialog();
            }
        }

        private void HideConnectDeviceForm()
        {
            if (connectDeviceForm != null && connectDeviceForm.Visible)
            {
                connectDeviceForm.Hide();
            }
        }

        private void PopulateCboRTMode()
        {
            cboRTMode.DataSource = RTModes;
        }
        #endregion

        #region GUI methods
        private void UpdateGUI()
        {
            if (ConfigArray[0] == "1")
            {
                cboRTMode.SelectedIndex = 0;
            }
            else if (ConfigArray[1] == "1")
            {
                cboRTMode.SelectedIndex = 1;
            }
            else if (ConfigArray[0] == "0" && ConfigArray[1] == "0")
            {
                cboRTMode.SelectedIndex = 2;
            }

            lblRTSensitivity.Text = ConvertToMM(ConfigArray[2]) + " mm";
            barRTSensitivity.Value = Convert.ToInt32(ConfigArray[2]);

            btnLeft.Text = ConvertToMM(ConfigArray[3]);
            btnRight.Text = ConvertToMM(ConfigArray[4]);
            btnUp.Text = ConvertToMM(ConfigArray[5]);
            btnDown.Text = ConvertToMM(ConfigArray[6]);
            btnX.Text = ConvertToMM(ConfigArray[7]);
            btnY.Text = ConvertToMM(ConfigArray[8]);
            btnA.Text = ConvertToMM(ConfigArray[9]);
            btnB.Text = ConvertToMM(ConfigArray[10]);
            btnR1.Text = ConvertToMM(ConfigArray[11]);
            btnL1.Text = ConvertToMM(ConfigArray[12]);
            btnR2.Text = ConvertToMM(ConfigArray[13]);
            btnL2.Text = ConvertToMM(ConfigArray[14]);
        }

        private void LoadSettings()
        {
            GetSettings();
            UpdateGUI();
        }

        private void Slider_Scroll(object sender, EventArgs e)
        {
            TrackBar slider = sender as TrackBar;
            if (slider != null)
            {
                slider.Value = (int)Math.Round((double)slider.Value / 25.0) * 25;
            }
        }
        #endregion

        #region Button click events

        private void btnResetDefault_Click(object sender, EventArgs e)
        {
            Reset();
            Thread.Sleep(1000);
            LoadSettings();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SetSettings();
            Thread.Sleep(1000);
            LoadSettings();
        }

        private void btnCalibrate_Click(object sender, EventArgs e)
        {
            Calibrate();
            CalibrationForm calibrationForm = new CalibrationForm();
            calibrationForm.ShowDialog();
            LoadSettings();
        }



        private void barActuationPoint_Scroll(object sender, EventArgs e)
        {
            Slider_Scroll(sender, e);

            //foreach button in SelectedButtons set the actuation point for button in config array
            foreach (int button in SelectedButtons)
            {
                ConfigArray[button + 3] = barActuationPoint.Value.ToString();
            }
            lblActuationPoint.Text = ConvertToMM(barActuationPoint.Value.ToString()) + " mm";
            SetSettings();
            LoadSettings();
        }

        private void barRTSensitivity_Scroll(object sender, EventArgs e)
        {
            Slider_Scroll(sender, e);

            // set the RT sensitivity in the config array
            ConfigArray[2] = barRTSensitivity.Value.ToString();
            lblRTSensitivity.Text = ConvertToMM(barRTSensitivity.Value.ToString()) + " mm";
            SetSettings();
            LoadSettings();
        }

        private void cboRTMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set the RT mode in the config array
            switch (cboRTMode.SelectedIndex) {
                case 0:
                    ConfigArray[0] = "1";
                    ConfigArray[1] = "0";
                    lblRTDescription.Text = RapidTriggerDescription;
                    break;
                case 1:
                    ConfigArray[0] = "0";
                    ConfigArray[1] = "1";
                    lblRTDescription.Text = ContinuousRapidTriggerDescription;
                    break;
                case 2:
                    ConfigArray[0] = "0";
                    ConfigArray[1] = "0";
                    lblRTDescription.Text = WhatIsRapidTrigger;
                    break;
            }
            
            if (InitialLoad)
            {
                SetSettings();
                LoadSettings();
            }
            
        }

        #endregion

        #region Click events for button selection
        // (0 = Left, 1 = Right, 2 = Up, 3 = Down, 4 = X, 5 = Y, 6 = A, 7 = B, 8 = R1, 9 = L1, 10 = R2, 11 = L2)
        private void btnLeft_Click(object sender, EventArgs e)
        {
            // If the button is not already selected, add it to the list of selected buttons and change the colour
            if (!SelectedButtons.Contains(0))
            {
                SelectedButtons.Add(0);
                btnLeft.BackColor = ButtonPressed;
            }
            // If the button is already selected, remove it from the list of selected buttons and change the colour back to the default
            else
            {
                SelectedButtons.Remove(0);
                btnLeft.BackColor = ButtonUnpressed;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (!SelectedButtons.Contains(1))
            {
                SelectedButtons.Add(1);
                btnRight.BackColor = ButtonPressed;
            }
            else
            {
                SelectedButtons.Remove(1);
                btnRight.BackColor = ButtonUnpressed;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (!SelectedButtons.Contains(2))
            {
                SelectedButtons.Add(2);
                btnUp.BackColor = ButtonPressed;
            }
            else
            {
                SelectedButtons.Remove(2);
                btnUp.BackColor = ButtonUnpressed;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (!SelectedButtons.Contains(3))
            {
                SelectedButtons.Add(3);
                btnDown.BackColor = ButtonPressed;
            }
            else
            {
                SelectedButtons.Remove(3);
                btnDown.BackColor = ButtonUnpressed;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (!SelectedButtons.Contains(4))
            {
                SelectedButtons.Add(4);
                btnX.BackColor = ButtonPressed;
            }
            else
            {
                SelectedButtons.Remove(4);
                btnX.BackColor = ButtonUnpressed;
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            if (!SelectedButtons.Contains(5))
            {
                SelectedButtons.Add(5);
                btnY.BackColor = ButtonPressed;
            }
            else
            {
                SelectedButtons.Remove(5);
                btnY.BackColor = ButtonUnpressed;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (!SelectedButtons.Contains(6))
            {
                SelectedButtons.Add(6);
                btnA.BackColor = ButtonPressed;
            }
            else
            {
                SelectedButtons.Remove(6);
                btnA.BackColor = ButtonUnpressed;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (!SelectedButtons.Contains(7))
            {
                SelectedButtons.Add(7);
                btnB.BackColor = ButtonPressed;
            }
            else
            {
                SelectedButtons.Remove(7);
                btnB.BackColor = ButtonUnpressed;
            }
        }

        private void btnR1_Click(object sender, EventArgs e)
        {
            if (!SelectedButtons.Contains(8))
            {
                SelectedButtons.Add(8);
                btnR1.BackColor = ButtonPressed;
            }
            else
            {
                SelectedButtons.Remove(8);
                btnR1.BackColor = ButtonUnpressed;
            }
        }

        private void btnL1_Click(object sender, EventArgs e)
        {
            if (!SelectedButtons.Contains(9))
            {
                SelectedButtons.Add(9);
                btnL1.BackColor = ButtonPressed;
            }
            else
            {
                SelectedButtons.Remove(9);
                btnL1.BackColor = ButtonUnpressed;
            }
        }

        private void btnR2_Click(object sender, EventArgs e)
        {
            if (!SelectedButtons.Contains(10))
            {
                SelectedButtons.Add(10);
                btnR2.BackColor = ButtonPressed;
            }
            else
            {
                SelectedButtons.Remove(10);
                btnR2.BackColor = ButtonUnpressed;
            }
        }

        private void btnL2_Click(object sender, EventArgs e)
        {
            if (!SelectedButtons.Contains(11))
            {
                SelectedButtons.Add(11);
                btnL2.BackColor = ButtonPressed;
            }
            else
            {
                SelectedButtons.Remove(11);
                btnL2.BackColor = ButtonUnpressed;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SelectedButtons.Clear();
            SelectedButtons.AddRange(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            btnLeft.BackColor = ButtonPressed;
            btnRight.BackColor = ButtonPressed;
            btnUp.BackColor = ButtonPressed;
            btnDown.BackColor = ButtonPressed;
            btnX.BackColor = ButtonPressed;
            btnY.BackColor = ButtonPressed;
            btnA.BackColor = ButtonPressed;
            btnB.BackColor = ButtonPressed;
            btnR1.BackColor = ButtonPressed;
            btnR2.BackColor = ButtonPressed;
            btnL1.BackColor = ButtonPressed;
            btnL2.BackColor = ButtonPressed;
        }

        private void btnRemoveSelection_Click(object sender, EventArgs e)
        {
            SelectedButtons.Clear();
            btnLeft.BackColor = ButtonUnpressed;
            btnRight.BackColor = ButtonUnpressed;
            btnUp.BackColor = ButtonUnpressed;
            btnDown.BackColor = ButtonUnpressed;
            btnX.BackColor = ButtonUnpressed;
            btnY.BackColor = ButtonUnpressed;
            btnA.BackColor = ButtonUnpressed;
            btnB.BackColor = ButtonUnpressed;
            btnR1.BackColor = ButtonUnpressed;
            btnR2.BackColor = ButtonUnpressed;
            btnL1.BackColor = ButtonUnpressed;
            btnL2.BackColor = ButtonUnpressed;
            lblActuationPoint.Text = "-- mm";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsDeviceConnected)
            {
                SerialPort1.Close();
            }
            Application.Exit();
        }

        #endregion

        #region Serial commands methods

        public void Calibrate()
        {
            SerialPort1.WriteLine(cmdCalibrate);
        }

        public void Save()
        {
            SerialPort1.WriteLine(cmdSave);
        }

        public void Reset()
        {
            SerialPort1.WriteLine(cmdReset);
            Save();
        }

        public void GetSettings()
        {
            try
            {
                SerialPort1.WriteLine(cmdGetConfig);
                Console.WriteLine($"Sent command: {cmdGetConfig}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Command send error: {ex.Message}");
            }

            string response = SerialPort1.ReadLine();
            Console.WriteLine("Serial Response: " + response);
            ProcessResponse(response);
        }

        public void SetSettings()
        {
            try
            {
                PrepareConfigString();
                SerialPort1.WriteLine($"{cmdSetConfig} {ConfigString}");
                Console.WriteLine($"Sent command: {cmdSetConfig} {ConfigString}");
                Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Command send error: {ex.Message}");
            }
        }

        #endregion

        #region Serial port methods

        private System.Windows.Forms.Timer deviceCheckTimer;

        private void InitializeDeviceCheckTimer()
        {
            deviceCheckTimer = new System.Windows.Forms.Timer();
            deviceCheckTimer.Interval = 1000; // 1 second, maybe reduce this for faster response
            deviceCheckTimer.Tick += DeviceCheckTimer_Tick;
            deviceCheckTimer.Start();
        }

        private void DeviceCheckTimer_Tick(object sender, EventArgs e)
        {
            CheckDeviceConnection();
        }

        private void CheckDeviceConnection()
        {
            if (IsDeviceConnected)
            {
                if (!SerialPort1.IsOpen)
                {
                    IsDeviceConnected = false;
                    SerialPort1.Close();
                    this.Hide();
                    ShowConnectDeviceForm();
                }
            }
            else
            {
                foreach (string port in SerialPort.GetPortNames())
                {
                    try
                    {
                        
                        SerialPort1.PortName = port;

                        SerialPort1.Open();

                        if (ValidateDevice())
                        {
                            IsDeviceConnected = true;
                            this.Show();
                            HideConnectDeviceForm();
                            PopulateCboRTMode();
                            LoadSettings();
                            InitialLoad = true;
                            break;
                        }
                        else
                        {
                            SerialPort1.Close();
                        }
                    }
                    catch
                    {
                        SerialPort1.Close();
                    }
                }

                if (!IsDeviceConnected)
                {
                    ShowConnectDeviceForm();
                }
            }
        }

        private bool ValidateDevice()
        {
            try
            {
                SerialPort1.WriteLine("checkconnection");
                Console.WriteLine($"Sent command: checkconnection");
                string response = SerialPort1.ReadLine();
                Console.WriteLine("Serial Response: " + response);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                return false;
            }

        }

        #endregion
    }
}