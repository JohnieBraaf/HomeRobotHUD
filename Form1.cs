﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace HomeRobotHUD
{
    public partial class Main_Form : Form
    {
        Serial SerialCOMPort;
        
        public Main_Form()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            RefreshCOMPorts();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            RefreshCOMPorts();
        }

        void RefreshCOMPorts()
        {
            COMPort_ComboBox.DataSource = SerialPort.GetPortNames();
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SerialCOMPort = new Serial(this);
                SerialCOMPort.Connect(COMPort_ComboBox.Text, "115200", "8", "0", "1");
                SerialCOMPort.GetSerialPort().DataReceived += SerialCOMPort.ReceiveData;
            }
            catch (Exception ex)
            {
                Console_ListBox.Items.Add("Error: " + ex.Message);
                int itemsPerPage = (int)(Console_ListBox.Height / Console_ListBox.ItemHeight);
                Console_ListBox.TopIndex = Console_ListBox.Items.Count - itemsPerPage;
            }            
        }

        private void Disconnect_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SerialCOMPort.Disconnect();
            }
            catch (Exception ex)
            {
                Console_ListBox.Items.Add("Error: " + ex.Message);
                int itemsPerPage = (int)(Console_ListBox.Height / Console_ListBox.ItemHeight);
                Console_ListBox.TopIndex = Console_ListBox.Items.Count - itemsPerPage;
            }
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {           
            try
            {
                SerialCOMPort.SendCommand(Command_TextBox.Text);
            }
            catch (Exception ex)
            {
                Console_ListBox.Items.Add("Error: " + ex.Message);
                int itemsPerPage = (int)(Console_ListBox.Height / Console_ListBox.ItemHeight);
                Console_ListBox.TopIndex = Console_ListBox.Items.Count - itemsPerPage;
            }
        }

        private void DecimalSend_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SerialCOMPort.SendDecimalCommand(Decimal_TextBox.Text);
            }
            catch (Exception ex)
            {
                Console_ListBox.Items.Add("Error: " + ex.Message);
                int itemsPerPage = (int)(Console_ListBox.Height / Console_ListBox.ItemHeight);
                Console_ListBox.TopIndex = Console_ListBox.Items.Count - itemsPerPage;
            }
        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SerialCOMPort.GetSerialPort().Write(new byte[]{
                        95,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0,
                        0
                }, 0, 8);
            }
            catch (Exception ex)
            {
                Console_ListBox.Items.Add("Error: " + ex.Message);
                int itemsPerPage = (int)(Console_ListBox.Height / Console_ListBox.ItemHeight);
                Console_ListBox.TopIndex = Console_ListBox.Items.Count - itemsPerPage;
            }
            
        }

        private void UpdateDecimalBox()
        {
            byte header = 255; // set all bits to 1
            // Toggle bit to 0 if needed
            if (LeftTrack_TrackBar.Value < 0)  header ^= (1 << 0);
            if (RightTrack_TrackBar.Value < 0) header ^= (1 << 1);
            if (Torso_TrackBar.Value < 0)      header ^= (1 << 2);
            if (Arms_TrackBar.Value < 0)       header ^= (1 << 3);
            if (Chest_TrackBar.Value < 0)      header ^= (1 << 4);

            int x = Convert.ToInt32(header);
            Decimal_TextBox.Text = x + " " +
            Math.Abs(RightTrack_TrackBar.Value) + " " +
            Math.Abs(LeftTrack_TrackBar.Value) + " " +
            Math.Abs(Torso_TrackBar.Value) + " " +
            Math.Abs(Arms_TrackBar.Value) + " " +
            Math.Abs(Chest_TrackBar.Value) + " " +
            Duration_TrackBar.Value;

            DurationDisplay_Label.Text = (Duration_TrackBar.Value * 50) + " ms";
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(LeftTrackReset_Button)) LeftTrack_TrackBar.Value = 0;
            else if (sender.Equals(RightTrackReset_Button)) RightTrack_TrackBar.Value = 0;
            else if (sender.Equals(TorsoReset_Button)) Torso_TrackBar.Value = 0;
            else if (sender.Equals(ArmsReset_Button)) Arms_TrackBar.Value = 0;
            else if (sender.Equals(ChestReset_Button)) Chest_TrackBar.Value = 0;
            UpdateDecimalBox();
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateDecimalBox();
        }
    }   
}