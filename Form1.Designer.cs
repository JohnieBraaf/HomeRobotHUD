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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Decimal_Label = new System.Windows.Forms.Label();
            this.ASCII_Label = new System.Windows.Forms.Label();
            this.Decimal_TextBox = new System.Windows.Forms.TextBox();
            this.DecimalSend_Button = new System.Windows.Forms.Button();
            this.Chest_Label = new System.Windows.Forms.Label();
            this.Arms_Label = new System.Windows.Forms.Label();
            this.Torso_Label = new System.Windows.Forms.Label();
            this.Tracks_Label = new System.Windows.Forms.Label();
            this.Torso_TrackBar = new System.Windows.Forms.TrackBar();
            this.Arms_TrackBar = new System.Windows.Forms.TrackBar();
            this.LeftTrack_TrackBar = new System.Windows.Forms.TrackBar();
            this.RightTrack_TrackBar = new System.Windows.Forms.TrackBar();
            this.Chest_TrackBar = new System.Windows.Forms.TrackBar();
            this.Disconnect_Button = new System.Windows.Forms.Button();
            this.Send_Button = new System.Windows.Forms.Button();
            this.Command_TextBox = new System.Windows.Forms.TextBox();
            this.Console_ListBox = new System.Windows.Forms.ListBox();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.COMPort_ComboBox = new System.Windows.Forms.ComboBox();
            this.terminatedCommand_textBox = new System.Windows.Forms.TextBox();
            this.terminatedSend_button = new System.Windows.Forms.Button();
            this.TelnetConnect_Button = new System.Windows.Forms.Button();
            this.IPAdress_Textbox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Torso_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arms_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTrack_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTrack_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chest_TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Decimal_Label
            // 
            this.Decimal_Label.AutoSize = true;
            this.Decimal_Label.Location = new System.Drawing.Point(736, 90);
            this.Decimal_Label.Name = "Decimal_Label";
            this.Decimal_Label.Size = new System.Drawing.Size(45, 13);
            this.Decimal_Label.TabIndex = 60;
            this.Decimal_Label.Text = "Decimal";
            // 
            // ASCII_Label
            // 
            this.ASCII_Label.AutoSize = true;
            this.ASCII_Label.Location = new System.Drawing.Point(740, 64);
            this.ASCII_Label.Name = "ASCII_Label";
            this.ASCII_Label.Size = new System.Drawing.Size(34, 13);
            this.ASCII_Label.TabIndex = 59;
            this.ASCII_Label.Text = "ASCII";
            // 
            // Decimal_TextBox
            // 
            this.Decimal_TextBox.Location = new System.Drawing.Point(552, 85);
            this.Decimal_TextBox.Name = "Decimal_TextBox";
            this.Decimal_TextBox.Size = new System.Drawing.Size(182, 20);
            this.Decimal_TextBox.TabIndex = 58;
            this.Decimal_TextBox.Text = "255 0 0 0 0 0 10";
            // 
            // DecimalSend_Button
            // 
            this.DecimalSend_Button.Location = new System.Drawing.Point(782, 84);
            this.DecimalSend_Button.Name = "DecimalSend_Button";
            this.DecimalSend_Button.Size = new System.Drawing.Size(49, 23);
            this.DecimalSend_Button.TabIndex = 57;
            this.DecimalSend_Button.Text = "Send";
            this.DecimalSend_Button.UseVisualStyleBackColor = true;
            this.DecimalSend_Button.Click += new System.EventHandler(this.DecimalSend_Button_Click);
            // 
            // Chest_Label
            // 
            this.Chest_Label.AutoSize = true;
            this.Chest_Label.Location = new System.Drawing.Point(477, 98);
            this.Chest_Label.Name = "Chest_Label";
            this.Chest_Label.Size = new System.Drawing.Size(34, 13);
            this.Chest_Label.TabIndex = 56;
            this.Chest_Label.Text = "Chest";
            // 
            // Arms_Label
            // 
            this.Arms_Label.AutoSize = true;
            this.Arms_Label.Location = new System.Drawing.Point(419, 97);
            this.Arms_Label.Name = "Arms_Label";
            this.Arms_Label.Size = new System.Drawing.Size(30, 13);
            this.Arms_Label.TabIndex = 55;
            this.Arms_Label.Text = "Arms";
            // 
            // Torso_Label
            // 
            this.Torso_Label.AutoSize = true;
            this.Torso_Label.Location = new System.Drawing.Point(445, 97);
            this.Torso_Label.Name = "Torso_Label";
            this.Torso_Label.Size = new System.Drawing.Size(34, 13);
            this.Torso_Label.TabIndex = 54;
            this.Torso_Label.Text = "Torso";
            // 
            // Tracks_Label
            // 
            this.Tracks_Label.AutoSize = true;
            this.Tracks_Label.Location = new System.Drawing.Point(338, 97);
            this.Tracks_Label.Name = "Tracks_Label";
            this.Tracks_Label.Size = new System.Drawing.Size(40, 13);
            this.Tracks_Label.TabIndex = 50;
            this.Tracks_Label.Text = "Tracks";
            // 
            // Torso_TrackBar
            // 
            this.Torso_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Torso_TrackBar.Location = new System.Drawing.Point(451, 113);
            this.Torso_TrackBar.Maximum = 255;
            this.Torso_TrackBar.Minimum = -255;
            this.Torso_TrackBar.Name = "Torso_TrackBar";
            this.Torso_TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Torso_TrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Torso_TrackBar.Size = new System.Drawing.Size(45, 170);
            this.Torso_TrackBar.TabIndex = 47;
            this.Torso_TrackBar.TickFrequency = 40;
            this.Torso_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Arms_TrackBar
            // 
            this.Arms_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Arms_TrackBar.Location = new System.Drawing.Point(423, 113);
            this.Arms_TrackBar.Maximum = 255;
            this.Arms_TrackBar.Minimum = -255;
            this.Arms_TrackBar.Name = "Arms_TrackBar";
            this.Arms_TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Arms_TrackBar.Size = new System.Drawing.Size(45, 170);
            this.Arms_TrackBar.TabIndex = 46;
            this.Arms_TrackBar.TickFrequency = 40;
            this.Arms_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // LeftTrack_TrackBar
            // 
            this.LeftTrack_TrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftTrack_TrackBar.Location = new System.Drawing.Point(357, 113);
            this.LeftTrack_TrackBar.Maximum = 255;
            this.LeftTrack_TrackBar.Minimum = -255;
            this.LeftTrack_TrackBar.Name = "LeftTrack_TrackBar";
            this.LeftTrack_TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftTrack_TrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LeftTrack_TrackBar.Size = new System.Drawing.Size(45, 170);
            this.LeftTrack_TrackBar.TabIndex = 45;
            this.LeftTrack_TrackBar.TickFrequency = 25;
            this.LeftTrack_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // RightTrack_TrackBar
            // 
            this.RightTrack_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightTrack_TrackBar.Location = new System.Drawing.Point(317, 113);
            this.RightTrack_TrackBar.Maximum = 255;
            this.RightTrack_TrackBar.Minimum = -255;
            this.RightTrack_TrackBar.Name = "RightTrack_TrackBar";
            this.RightTrack_TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightTrack_TrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightTrack_TrackBar.RightToLeftLayout = true;
            this.RightTrack_TrackBar.Size = new System.Drawing.Size(45, 170);
            this.RightTrack_TrackBar.TabIndex = 44;
            this.RightTrack_TrackBar.TickFrequency = 25;
            this.RightTrack_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Chest_TrackBar
            // 
            this.Chest_TrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chest_TrackBar.Location = new System.Drawing.Point(480, 113);
            this.Chest_TrackBar.Maximum = 255;
            this.Chest_TrackBar.Minimum = -255;
            this.Chest_TrackBar.Name = "Chest_TrackBar";
            this.Chest_TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Chest_TrackBar.Size = new System.Drawing.Size(45, 170);
            this.Chest_TrackBar.TabIndex = 43;
            this.Chest_TrackBar.TickFrequency = 40;
            this.Chest_TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Disconnect_Button
            // 
            this.Disconnect_Button.Location = new System.Drawing.Point(782, 30);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(49, 23);
            this.Disconnect_Button.TabIndex = 40;
            this.Disconnect_Button.Text = "Disconnect";
            this.Disconnect_Button.UseVisualStyleBackColor = true;
            this.Disconnect_Button.Click += new System.EventHandler(this.Disconnect_Button_Click);
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(782, 57);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(49, 23);
            this.Send_Button.TabIndex = 39;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Command_TextBox
            // 
            this.Command_TextBox.Location = new System.Drawing.Point(552, 58);
            this.Command_TextBox.Name = "Command_TextBox";
            this.Command_TextBox.Size = new System.Drawing.Size(182, 20);
            this.Command_TextBox.TabIndex = 38;
            this.Command_TextBox.Text = "_ # # # # # #";
            // 
            // Console_ListBox
            // 
            this.Console_ListBox.FormattingEnabled = true;
            this.Console_ListBox.Location = new System.Drawing.Point(11, 113);
            this.Console_ListBox.Name = "Console_ListBox";
            this.Console_ListBox.Size = new System.Drawing.Size(279, 537);
            this.Console_ListBox.TabIndex = 37;
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(740, 31);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(36, 23);
            this.Connect_Button.TabIndex = 36;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // COMPort_ComboBox
            // 
            this.COMPort_ComboBox.FormattingEnabled = true;
            this.COMPort_ComboBox.Location = new System.Drawing.Point(552, 32);
            this.COMPort_ComboBox.Name = "COMPort_ComboBox";
            this.COMPort_ComboBox.Size = new System.Drawing.Size(182, 21);
            this.COMPort_ComboBox.TabIndex = 35;
            this.COMPort_ComboBox.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // terminatedCommand_textBox
            // 
            this.terminatedCommand_textBox.Location = new System.Drawing.Point(12, 87);
            this.terminatedCommand_textBox.Name = "terminatedCommand_textBox";
            this.terminatedCommand_textBox.Size = new System.Drawing.Size(197, 20);
            this.terminatedCommand_textBox.TabIndex = 68;
            this.terminatedCommand_textBox.Text = ">0;0;0;0;0";
            // 
            // terminatedSend_button
            // 
            this.terminatedSend_button.Location = new System.Drawing.Point(215, 85);
            this.terminatedSend_button.Name = "terminatedSend_button";
            this.terminatedSend_button.Size = new System.Drawing.Size(75, 23);
            this.terminatedSend_button.TabIndex = 70;
            this.terminatedSend_button.Text = "Send";
            this.terminatedSend_button.UseVisualStyleBackColor = true;
            this.terminatedSend_button.Click += new System.EventHandler(this.terminatedSend_button_Click);
            // 
            // TelnetConnect_Button
            // 
            this.TelnetConnect_Button.Location = new System.Drawing.Point(215, 57);
            this.TelnetConnect_Button.Name = "TelnetConnect_Button";
            this.TelnetConnect_Button.Size = new System.Drawing.Size(75, 23);
            this.TelnetConnect_Button.TabIndex = 71;
            this.TelnetConnect_Button.Text = "Connect";
            this.TelnetConnect_Button.UseVisualStyleBackColor = true;
            this.TelnetConnect_Button.Click += new System.EventHandler(this.TelnetConnect_Button_Click);
            // 
            // IPAdress_Textbox
            // 
            this.IPAdress_Textbox.Location = new System.Drawing.Point(12, 59);
            this.IPAdress_Textbox.Name = "IPAdress_Textbox";
            this.IPAdress_Textbox.Size = new System.Drawing.Size(197, 20);
            this.IPAdress_Textbox.TabIndex = 72;
            this.IPAdress_Textbox.Text = "192.168.137.94";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(552, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 537);
            this.listBox1.TabIndex = 73;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Chest_TrackBar);
            this.Controls.Add(this.IPAdress_Textbox);
            this.Controls.Add(this.TelnetConnect_Button);
            this.Controls.Add(this.terminatedSend_button);
            this.Controls.Add(this.terminatedCommand_textBox);
            this.Controls.Add(this.Decimal_Label);
            this.Controls.Add(this.ASCII_Label);
            this.Controls.Add(this.Decimal_TextBox);
            this.Controls.Add(this.DecimalSend_Button);
            this.Controls.Add(this.Chest_Label);
            this.Controls.Add(this.Arms_Label);
            this.Controls.Add(this.Torso_Label);
            this.Controls.Add(this.Tracks_Label);
            this.Controls.Add(this.Torso_TrackBar);
            this.Controls.Add(this.Arms_TrackBar);
            this.Controls.Add(this.LeftTrack_TrackBar);
            this.Controls.Add(this.RightTrack_TrackBar);
            this.Controls.Add(this.Disconnect_Button);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Command_TextBox);
            this.Controls.Add(this.Console_ListBox);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.COMPort_ComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "Home Robot - HUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Torso_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arms_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTrack_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTrack_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chest_TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Decimal_Label;
        private System.Windows.Forms.Label ASCII_Label;
        private System.Windows.Forms.TextBox Decimal_TextBox;
        public System.Windows.Forms.Button DecimalSend_Button;
        private System.Windows.Forms.Label Chest_Label;
        private System.Windows.Forms.Label Arms_Label;
        private System.Windows.Forms.Label Torso_Label;
        private System.Windows.Forms.Label Tracks_Label;
        private System.Windows.Forms.TrackBar Torso_TrackBar;
        private System.Windows.Forms.TrackBar Arms_TrackBar;
        private System.Windows.Forms.TrackBar LeftTrack_TrackBar;
        private System.Windows.Forms.TrackBar RightTrack_TrackBar;
        private System.Windows.Forms.TrackBar Chest_TrackBar;
        public System.Windows.Forms.Button Disconnect_Button;
        public System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.TextBox Command_TextBox;
        public System.Windows.Forms.ListBox Console_ListBox;
        public System.Windows.Forms.Button Connect_Button;
        public System.Windows.Forms.ComboBox COMPort_ComboBox;
        private System.Windows.Forms.TextBox terminatedCommand_textBox;
        public System.Windows.Forms.Button terminatedSend_button;
        public System.Windows.Forms.Button TelnetConnect_Button;
        private System.Windows.Forms.TextBox IPAdress_Textbox;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

