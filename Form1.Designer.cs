namespace HomeRobotHUD
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftTrackReset_Button = new System.Windows.Forms.Button();
            this.RightTrackReset_Button = new System.Windows.Forms.Button();
            this.ChestReset_Button = new System.Windows.Forms.Button();
            this.ArmsReset_Button = new System.Windows.Forms.Button();
            this.TorsoReset_Button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Decimal_Label = new System.Windows.Forms.Label();
            this.ASCII_Label = new System.Windows.Forms.Label();
            this.Decimal_TextBox = new System.Windows.Forms.TextBox();
            this.DecimalSend_Button = new System.Windows.Forms.Button();
            this.Chest_Label = new System.Windows.Forms.Label();
            this.Arms_Label = new System.Windows.Forms.Label();
            this.Torso_Label = new System.Windows.Forms.Label();
            this.Duration_Label = new System.Windows.Forms.Label();
            this.RightTrackModerator_Label = new System.Windows.Forms.Label();
            this.LeftTrackModerator_Label = new System.Windows.Forms.Label();
            this.RightTrack_Label = new System.Windows.Forms.Label();
            this.LeftTrack_Label = new System.Windows.Forms.Label();
            this.Duration_TrackBar = new System.Windows.Forms.TrackBar();
            this.Torso_TrackBar = new System.Windows.Forms.TrackBar();
            this.Arms_TrackBar = new System.Windows.Forms.TrackBar();
            this.LeftTrack_TrackBar = new System.Windows.Forms.TrackBar();
            this.RightTrack_TrackBar = new System.Windows.Forms.TrackBar();
            this.Chest_TrackBar = new System.Windows.Forms.TrackBar();
            this.RightTrackModerator_TrackBar = new System.Windows.Forms.TrackBar();
            this.LeftTrackModerator_TrackBar = new System.Windows.Forms.TrackBar();
            this.Disconnect_Button = new System.Windows.Forms.Button();
            this.Send_Button = new System.Windows.Forms.Button();
            this.Command_TextBox = new System.Windows.Forms.TextBox();
            this.Console_ListBox = new System.Windows.Forms.ListBox();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.COMPort_ComboBox = new System.Windows.Forms.ComboBox();
            this.DurationDisplay_Label = new System.Windows.Forms.Label();
            this.terminatedCommand_textBox = new System.Windows.Forms.TextBox();
            this.terminatedSend_button = new System.Windows.Forms.Button();
            this.TelnetConnect_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Duration_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Torso_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arms_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTrack_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTrack_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chest_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTrackModerator_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTrackModerator_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftTrackReset_Button
            // 
            this.LeftTrackReset_Button.Location = new System.Drawing.Point(92, 221);
            this.LeftTrackReset_Button.Name = "LeftTrackReset_Button";
            this.LeftTrackReset_Button.Size = new System.Drawing.Size(21, 23);
            this.LeftTrackReset_Button.TabIndex = 66;
            this.LeftTrackReset_Button.Text = "0";
            this.LeftTrackReset_Button.UseVisualStyleBackColor = true;
            this.LeftTrackReset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // RightTrackReset_Button
            // 
            this.RightTrackReset_Button.Location = new System.Drawing.Point(150, 221);
            this.RightTrackReset_Button.Name = "RightTrackReset_Button";
            this.RightTrackReset_Button.Size = new System.Drawing.Size(21, 23);
            this.RightTrackReset_Button.TabIndex = 65;
            this.RightTrackReset_Button.Text = "0";
            this.RightTrackReset_Button.UseVisualStyleBackColor = true;
            this.RightTrackReset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // ChestReset_Button
            // 
            this.ChestReset_Button.Location = new System.Drawing.Point(271, 573);
            this.ChestReset_Button.Name = "ChestReset_Button";
            this.ChestReset_Button.Size = new System.Drawing.Size(21, 23);
            this.ChestReset_Button.TabIndex = 64;
            this.ChestReset_Button.Text = "0";
            this.ChestReset_Button.UseVisualStyleBackColor = true;
            this.ChestReset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // ArmsReset_Button
            // 
            this.ArmsReset_Button.Location = new System.Drawing.Point(271, 503);
            this.ArmsReset_Button.Name = "ArmsReset_Button";
            this.ArmsReset_Button.Size = new System.Drawing.Size(21, 23);
            this.ArmsReset_Button.TabIndex = 63;
            this.ArmsReset_Button.Text = "0";
            this.ArmsReset_Button.UseVisualStyleBackColor = true;
            this.ArmsReset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // TorsoReset_Button
            // 
            this.TorsoReset_Button.Location = new System.Drawing.Point(271, 430);
            this.TorsoReset_Button.Name = "TorsoReset_Button";
            this.TorsoReset_Button.Size = new System.Drawing.Size(21, 23);
            this.TorsoReset_Button.TabIndex = 62;
            this.TorsoReset_Button.Text = "0";
            this.TorsoReset_Button.UseVisualStyleBackColor = true;
            this.TorsoReset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.Location = new System.Drawing.Point(416, 213);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(75, 23);
            this.Stop_Button.TabIndex = 61;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Decimal_Label
            // 
            this.Decimal_Label.AutoSize = true;
            this.Decimal_Label.Location = new System.Drawing.Point(345, 141);
            this.Decimal_Label.Name = "Decimal_Label";
            this.Decimal_Label.Size = new System.Drawing.Size(45, 13);
            this.Decimal_Label.TabIndex = 60;
            this.Decimal_Label.Text = "Decimal";
            // 
            // ASCII_Label
            // 
            this.ASCII_Label.AutoSize = true;
            this.ASCII_Label.Location = new System.Drawing.Point(351, 105);
            this.ASCII_Label.Name = "ASCII_Label";
            this.ASCII_Label.Size = new System.Drawing.Size(34, 13);
            this.ASCII_Label.TabIndex = 59;
            this.ASCII_Label.Text = "ASCII";
            // 
            // Decimal_TextBox
            // 
            this.Decimal_TextBox.Location = new System.Drawing.Point(212, 138);
            this.Decimal_TextBox.Name = "Decimal_TextBox";
            this.Decimal_TextBox.Size = new System.Drawing.Size(116, 20);
            this.Decimal_TextBox.TabIndex = 58;
            this.Decimal_TextBox.Text = "255 0 0 0 0 0 10";
            // 
            // DecimalSend_Button
            // 
            this.DecimalSend_Button.Location = new System.Drawing.Point(416, 138);
            this.DecimalSend_Button.Name = "DecimalSend_Button";
            this.DecimalSend_Button.Size = new System.Drawing.Size(75, 23);
            this.DecimalSend_Button.TabIndex = 57;
            this.DecimalSend_Button.Text = "Send";
            this.DecimalSend_Button.UseVisualStyleBackColor = true;
            this.DecimalSend_Button.Click += new System.EventHandler(this.DecimalSend_Button_Click);
            // 
            // Chest_Label
            // 
            this.Chest_Label.AutoSize = true;
            this.Chest_Label.Location = new System.Drawing.Point(85, 535);
            this.Chest_Label.Name = "Chest_Label";
            this.Chest_Label.Size = new System.Drawing.Size(34, 13);
            this.Chest_Label.TabIndex = 56;
            this.Chest_Label.Text = "Chest";
            // 
            // Arms_Label
            // 
            this.Arms_Label.AutoSize = true;
            this.Arms_Label.Location = new System.Drawing.Point(85, 465);
            this.Arms_Label.Name = "Arms_Label";
            this.Arms_Label.Size = new System.Drawing.Size(30, 13);
            this.Arms_Label.TabIndex = 55;
            this.Arms_Label.Text = "Arms";
            // 
            // Torso_Label
            // 
            this.Torso_Label.AutoSize = true;
            this.Torso_Label.Location = new System.Drawing.Point(85, 392);
            this.Torso_Label.Name = "Torso_Label";
            this.Torso_Label.Size = new System.Drawing.Size(34, 13);
            this.Torso_Label.TabIndex = 54;
            this.Torso_Label.Text = "Torso";
            // 
            // Duration_Label
            // 
            this.Duration_Label.AutoSize = true;
            this.Duration_Label.Location = new System.Drawing.Point(186, 330);
            this.Duration_Label.Name = "Duration_Label";
            this.Duration_Label.Size = new System.Drawing.Size(92, 13);
            this.Duration_Label.TabIndex = 53;
            this.Duration_Label.Text = "Duration ( x50 ms)";
            // 
            // RightTrackModerator_Label
            // 
            this.RightTrackModerator_Label.AutoSize = true;
            this.RightTrackModerator_Label.Location = new System.Drawing.Point(186, 273);
            this.RightTrackModerator_Label.Name = "RightTrackModerator_Label";
            this.RightTrackModerator_Label.Size = new System.Drawing.Size(114, 13);
            this.RightTrackModerator_Label.TabIndex = 52;
            this.RightTrackModerator_Label.Text = "Right Track Moderator";
            // 
            // LeftTrackModerator_Label
            // 
            this.LeftTrackModerator_Label.AutoSize = true;
            this.LeftTrackModerator_Label.Location = new System.Drawing.Point(184, 226);
            this.LeftTrackModerator_Label.Name = "LeftTrackModerator_Label";
            this.LeftTrackModerator_Label.Size = new System.Drawing.Size(107, 13);
            this.LeftTrackModerator_Label.TabIndex = 51;
            this.LeftTrackModerator_Label.Text = "Left Track Moderator";
            // 
            // RightTrack_Label
            // 
            this.RightTrack_Label.AutoSize = true;
            this.RightTrack_Label.Location = new System.Drawing.Point(117, 70);
            this.RightTrack_Label.Name = "RightTrack_Label";
            this.RightTrack_Label.Size = new System.Drawing.Size(63, 13);
            this.RightTrack_Label.TabIndex = 50;
            this.RightTrack_Label.Text = "Right Track";
            // 
            // LeftTrack_Label
            // 
            this.LeftTrack_Label.AutoSize = true;
            this.LeftTrack_Label.Location = new System.Drawing.Point(60, 70);
            this.LeftTrack_Label.Name = "LeftTrack_Label";
            this.LeftTrack_Label.Size = new System.Drawing.Size(56, 13);
            this.LeftTrack_Label.TabIndex = 49;
            this.LeftTrack_Label.Text = "Left Track";
            // 
            // Duration_TrackBar
            // 
            this.Duration_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Duration_TrackBar.Location = new System.Drawing.Point(182, 346);
            this.Duration_TrackBar.Maximum = 255;
            this.Duration_TrackBar.Name = "Duration_TrackBar";
            this.Duration_TrackBar.Size = new System.Drawing.Size(309, 45);
            this.Duration_TrackBar.TabIndex = 48;
            this.Duration_TrackBar.TickFrequency = 16;
            this.Duration_TrackBar.Value = 10;
            this.Duration_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Torso_TrackBar
            // 
            this.Torso_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Torso_TrackBar.Location = new System.Drawing.Point(74, 408);
            this.Torso_TrackBar.Maximum = 255;
            this.Torso_TrackBar.Minimum = -255;
            this.Torso_TrackBar.Name = "Torso_TrackBar";
            this.Torso_TrackBar.Size = new System.Drawing.Size(417, 45);
            this.Torso_TrackBar.TabIndex = 47;
            this.Torso_TrackBar.TickFrequency = 16;
            this.Torso_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Arms_TrackBar
            // 
            this.Arms_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Arms_TrackBar.Location = new System.Drawing.Point(74, 481);
            this.Arms_TrackBar.Maximum = 255;
            this.Arms_TrackBar.Minimum = -255;
            this.Arms_TrackBar.Name = "Arms_TrackBar";
            this.Arms_TrackBar.Size = new System.Drawing.Size(417, 45);
            this.Arms_TrackBar.TabIndex = 46;
            this.Arms_TrackBar.TickFrequency = 16;
            this.Arms_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // LeftTrack_TrackBar
            // 
            this.LeftTrack_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftTrack_TrackBar.Location = new System.Drawing.Point(68, 86);
            this.LeftTrack_TrackBar.Maximum = 255;
            this.LeftTrack_TrackBar.Minimum = -255;
            this.LeftTrack_TrackBar.Name = "LeftTrack_TrackBar";
            this.LeftTrack_TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftTrack_TrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LeftTrack_TrackBar.Size = new System.Drawing.Size(45, 292);
            this.LeftTrack_TrackBar.TabIndex = 45;
            this.LeftTrack_TrackBar.TickFrequency = 16;
            this.LeftTrack_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // RightTrack_TrackBar
            // 
            this.RightTrack_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightTrack_TrackBar.Location = new System.Drawing.Point(126, 86);
            this.RightTrack_TrackBar.Maximum = 255;
            this.RightTrack_TrackBar.Minimum = -255;
            this.RightTrack_TrackBar.Name = "RightTrack_TrackBar";
            this.RightTrack_TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightTrack_TrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightTrack_TrackBar.Size = new System.Drawing.Size(45, 292);
            this.RightTrack_TrackBar.TabIndex = 44;
            this.RightTrack_TrackBar.TickFrequency = 16;
            this.RightTrack_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Chest_TrackBar
            // 
            this.Chest_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chest_TrackBar.Location = new System.Drawing.Point(74, 551);
            this.Chest_TrackBar.Maximum = 255;
            this.Chest_TrackBar.Minimum = -255;
            this.Chest_TrackBar.Name = "Chest_TrackBar";
            this.Chest_TrackBar.Size = new System.Drawing.Size(417, 45);
            this.Chest_TrackBar.TabIndex = 43;
            this.Chest_TrackBar.TickFrequency = 16;
            this.Chest_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // RightTrackModerator_TrackBar
            // 
            this.RightTrackModerator_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightTrackModerator_TrackBar.Location = new System.Drawing.Point(178, 289);
            this.RightTrackModerator_TrackBar.Maximum = 255;
            this.RightTrackModerator_TrackBar.Minimum = -255;
            this.RightTrackModerator_TrackBar.Name = "RightTrackModerator_TrackBar";
            this.RightTrackModerator_TrackBar.Size = new System.Drawing.Size(313, 45);
            this.RightTrackModerator_TrackBar.TabIndex = 42;
            this.RightTrackModerator_TrackBar.TickFrequency = 16;
            this.RightTrackModerator_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // LeftTrackModerator_TrackBar
            // 
            this.LeftTrackModerator_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftTrackModerator_TrackBar.Location = new System.Drawing.Point(178, 242);
            this.LeftTrackModerator_TrackBar.Maximum = 255;
            this.LeftTrackModerator_TrackBar.Minimum = -255;
            this.LeftTrackModerator_TrackBar.Name = "LeftTrackModerator_TrackBar";
            this.LeftTrackModerator_TrackBar.Size = new System.Drawing.Size(313, 45);
            this.LeftTrackModerator_TrackBar.TabIndex = 41;
            this.LeftTrackModerator_TrackBar.TickFrequency = 16;
            this.LeftTrackModerator_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Disconnect_Button
            // 
            this.Disconnect_Button.Location = new System.Drawing.Point(418, 68);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(73, 23);
            this.Disconnect_Button.TabIndex = 40;
            this.Disconnect_Button.Text = "Disconnect";
            this.Disconnect_Button.UseVisualStyleBackColor = true;
            this.Disconnect_Button.Click += new System.EventHandler(this.Disconnect_Button_Click);
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(416, 102);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Button.TabIndex = 39;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Command_TextBox
            // 
            this.Command_TextBox.Location = new System.Drawing.Point(212, 102);
            this.Command_TextBox.Name = "Command_TextBox";
            this.Command_TextBox.Size = new System.Drawing.Size(116, 20);
            this.Command_TextBox.TabIndex = 38;
            this.Command_TextBox.Text = "_ # # # # # #";
            // 
            // Console_ListBox
            // 
            this.Console_ListBox.FormattingEnabled = true;
            this.Console_ListBox.Location = new System.Drawing.Point(510, 68);
            this.Console_ListBox.Name = "Console_ListBox";
            this.Console_ListBox.Size = new System.Drawing.Size(279, 524);
            this.Console_ListBox.TabIndex = 37;
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(337, 68);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(75, 23);
            this.Connect_Button.TabIndex = 36;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // COMPort_ComboBox
            // 
            this.COMPort_ComboBox.FormattingEnabled = true;
            this.COMPort_ComboBox.Location = new System.Drawing.Point(212, 68);
            this.COMPort_ComboBox.Name = "COMPort_ComboBox";
            this.COMPort_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.COMPort_ComboBox.TabIndex = 35;
            this.COMPort_ComboBox.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // DurationDisplay_Label
            // 
            this.DurationDisplay_Label.AutoSize = true;
            this.DurationDisplay_Label.Location = new System.Drawing.Point(445, 330);
            this.DurationDisplay_Label.Name = "DurationDisplay_Label";
            this.DurationDisplay_Label.Size = new System.Drawing.Size(41, 13);
            this.DurationDisplay_Label.TabIndex = 67;
            this.DurationDisplay_Label.Text = "500 ms";
            // 
            // terminatedCommand_textBox
            // 
            this.terminatedCommand_textBox.Location = new System.Drawing.Point(212, 179);
            this.terminatedCommand_textBox.Name = "terminatedCommand_textBox";
            this.terminatedCommand_textBox.Size = new System.Drawing.Size(116, 20);
            this.terminatedCommand_textBox.TabIndex = 68;
            this.terminatedCommand_textBox.Text = ">200;201;202;203;204";
            // 
            // terminatedSend_button
            // 
            this.terminatedSend_button.Location = new System.Drawing.Point(418, 176);
            this.terminatedSend_button.Name = "terminatedSend_button";
            this.terminatedSend_button.Size = new System.Drawing.Size(75, 23);
            this.terminatedSend_button.TabIndex = 70;
            this.terminatedSend_button.Text = "Send";
            this.terminatedSend_button.UseVisualStyleBackColor = true;
            this.terminatedSend_button.Click += new System.EventHandler(this.terminatedSend_button_Click);
            // 
            // TelnetConnect_Button
            // 
            this.TelnetConnect_Button.Location = new System.Drawing.Point(337, 177);
            this.TelnetConnect_Button.Name = "TelnetConnect_Button";
            this.TelnetConnect_Button.Size = new System.Drawing.Size(75, 23);
            this.TelnetConnect_Button.TabIndex = 71;
            this.TelnetConnect_Button.Text = "Connect";
            this.TelnetConnect_Button.UseVisualStyleBackColor = true;
            this.TelnetConnect_Button.Click += new System.EventHandler(this.TelnetConnect_Button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 665);
            this.Controls.Add(this.TelnetConnect_Button);
            this.Controls.Add(this.terminatedSend_button);
            this.Controls.Add(this.terminatedCommand_textBox);
            this.Controls.Add(this.DurationDisplay_Label);
            this.Controls.Add(this.LeftTrackReset_Button);
            this.Controls.Add(this.RightTrackReset_Button);
            this.Controls.Add(this.ChestReset_Button);
            this.Controls.Add(this.ArmsReset_Button);
            this.Controls.Add(this.TorsoReset_Button);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Decimal_Label);
            this.Controls.Add(this.ASCII_Label);
            this.Controls.Add(this.Decimal_TextBox);
            this.Controls.Add(this.DecimalSend_Button);
            this.Controls.Add(this.Chest_Label);
            this.Controls.Add(this.Arms_Label);
            this.Controls.Add(this.Torso_Label);
            this.Controls.Add(this.Duration_Label);
            this.Controls.Add(this.RightTrackModerator_Label);
            this.Controls.Add(this.LeftTrackModerator_Label);
            this.Controls.Add(this.RightTrack_Label);
            this.Controls.Add(this.LeftTrack_Label);
            this.Controls.Add(this.Duration_TrackBar);
            this.Controls.Add(this.Torso_TrackBar);
            this.Controls.Add(this.Arms_TrackBar);
            this.Controls.Add(this.LeftTrack_TrackBar);
            this.Controls.Add(this.RightTrack_TrackBar);
            this.Controls.Add(this.Chest_TrackBar);
            this.Controls.Add(this.RightTrackModerator_TrackBar);
            this.Controls.Add(this.LeftTrackModerator_TrackBar);
            this.Controls.Add(this.Disconnect_Button);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Command_TextBox);
            this.Controls.Add(this.Console_ListBox);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.COMPort_ComboBox);
            this.Name = "Main_Form";
            this.Text = "Home Robot - HUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Duration_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Torso_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arms_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTrack_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTrack_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chest_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTrackModerator_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTrackModerator_TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LeftTrackReset_Button;
        private System.Windows.Forms.Button RightTrackReset_Button;
        private System.Windows.Forms.Button ChestReset_Button;
        private System.Windows.Forms.Button ArmsReset_Button;
        private System.Windows.Forms.Button TorsoReset_Button;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Label Decimal_Label;
        private System.Windows.Forms.Label ASCII_Label;
        private System.Windows.Forms.TextBox Decimal_TextBox;
        public System.Windows.Forms.Button DecimalSend_Button;
        private System.Windows.Forms.Label Chest_Label;
        private System.Windows.Forms.Label Arms_Label;
        private System.Windows.Forms.Label Torso_Label;
        private System.Windows.Forms.Label Duration_Label;
        private System.Windows.Forms.Label RightTrackModerator_Label;
        private System.Windows.Forms.Label LeftTrackModerator_Label;
        private System.Windows.Forms.Label RightTrack_Label;
        private System.Windows.Forms.Label LeftTrack_Label;
        private System.Windows.Forms.TrackBar Duration_TrackBar;
        private System.Windows.Forms.TrackBar Torso_TrackBar;
        private System.Windows.Forms.TrackBar Arms_TrackBar;
        private System.Windows.Forms.TrackBar LeftTrack_TrackBar;
        private System.Windows.Forms.TrackBar RightTrack_TrackBar;
        private System.Windows.Forms.TrackBar Chest_TrackBar;
        private System.Windows.Forms.TrackBar RightTrackModerator_TrackBar;
        private System.Windows.Forms.TrackBar LeftTrackModerator_TrackBar;
        public System.Windows.Forms.Button Disconnect_Button;
        public System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.TextBox Command_TextBox;
        public System.Windows.Forms.ListBox Console_ListBox;
        public System.Windows.Forms.Button Connect_Button;
        public System.Windows.Forms.ComboBox COMPort_ComboBox;
        private System.Windows.Forms.Label DurationDisplay_Label;
        private System.Windows.Forms.TextBox terminatedCommand_textBox;
        public System.Windows.Forms.Button terminatedSend_button;
        public System.Windows.Forms.Button TelnetConnect_Button;
    }
}

