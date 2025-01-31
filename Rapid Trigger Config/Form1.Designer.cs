namespace Rapid_Trigger_Config
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.barActuationPoint = new System.Windows.Forms.TrackBar();
            this.lblActuationPoint = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetDefault = new System.Windows.Forms.Button();
            this.btnCalibrate = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRTDescription = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboRTMode = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRTSensitivity = new System.Windows.Forms.Label();
            this.barRTSensitivity = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnRemoveSelection = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnUp = new Rapid_Trigger_Config.RoundButtonControl();
            this.btnA = new Rapid_Trigger_Config.RoundButtonControl();
            this.btnB = new Rapid_Trigger_Config.RoundButtonControl();
            this.btnR2 = new Rapid_Trigger_Config.RoundButtonControl();
            this.btnL2 = new Rapid_Trigger_Config.RoundButtonControl();
            this.btnL1 = new Rapid_Trigger_Config.RoundButtonControl();
            this.btnR1 = new Rapid_Trigger_Config.RoundButtonControl();
            this.btnY = new Rapid_Trigger_Config.RoundButtonControl();
            this.btnX = new Rapid_Trigger_Config.RoundButtonControl();
            this.btnRight = new Rapid_Trigger_Config.RoundButtonControl();
            this.btnDown = new Rapid_Trigger_Config.RoundButtonControl();
            this.btnLeft = new Rapid_Trigger_Config.RoundButtonControl();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barActuationPoint)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barRTSensitivity)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 217);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Futura Bk BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(5, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Actuation Point";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.barActuationPoint, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblActuationPoint, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 132);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 47);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // barActuationPoint
            // 
            this.barActuationPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.barActuationPoint.LargeChange = 25;
            this.barActuationPoint.Location = new System.Drawing.Point(2, 2);
            this.barActuationPoint.Margin = new System.Windows.Forms.Padding(2);
            this.barActuationPoint.Maximum = 1000;
            this.barActuationPoint.Minimum = 25;
            this.barActuationPoint.Name = "barActuationPoint";
            this.barActuationPoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barActuationPoint.Size = new System.Drawing.Size(410, 43);
            this.barActuationPoint.SmallChange = 25;
            this.barActuationPoint.TabIndex = 5;
            this.barActuationPoint.TickFrequency = 25;
            this.barActuationPoint.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.barActuationPoint.Value = 25;
            this.barActuationPoint.Scroll += new System.EventHandler(this.barActuationPoint_Scroll);
            // 
            // lblActuationPoint
            // 
            this.lblActuationPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActuationPoint.AutoSize = true;
            this.lblActuationPoint.Font = new System.Drawing.Font("Futura Bk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActuationPoint.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblActuationPoint.Location = new System.Drawing.Point(416, 12);
            this.lblActuationPoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActuationPoint.Name = "lblActuationPoint";
            this.lblActuationPoint.Size = new System.Drawing.Size(76, 22);
            this.lblActuationPoint.TabIndex = 7;
            this.lblActuationPoint.Text = "-- mm";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Futura Bk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(7, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(497, 90);
            this.label4.TabIndex = 4;
            this.label4.Text = "Set the distance where a keypress\r\nwill be triggered for the selected key(s).";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Futura Hv BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actuation";
            // 
            // btnResetDefault
            // 
            this.btnResetDefault.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetDefault.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResetDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResetDefault.Font = new System.Drawing.Font("Futura Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDefault.Location = new System.Drawing.Point(319, 11);
            this.btnResetDefault.Margin = new System.Windows.Forms.Padding(0);
            this.btnResetDefault.Name = "btnResetDefault";
            this.btnResetDefault.Size = new System.Drawing.Size(166, 35);
            this.btnResetDefault.TabIndex = 3;
            this.btnResetDefault.Text = "Reset to Default";
            this.btnResetDefault.UseVisualStyleBackColor = false;
            this.btnResetDefault.Click += new System.EventHandler(this.btnResetDefault_Click);
            // 
            // btnCalibrate
            // 
            this.btnCalibrate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalibrate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalibrate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalibrate.Font = new System.Drawing.Font("Futura Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalibrate.Location = new System.Drawing.Point(494, 11);
            this.btnCalibrate.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnCalibrate.Name = "btnCalibrate";
            this.btnCalibrate.Size = new System.Drawing.Size(166, 35);
            this.btnCalibrate.TabIndex = 4;
            this.btnCalibrate.Text = "Calibration Mode";
            this.btnCalibrate.UseVisualStyleBackColor = false;
            this.btnCalibrate.Click += new System.EventHandler(this.btnCalibrate_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveSettings.Font = new System.Drawing.Font("Futura Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(670, 11);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(166, 35);
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Text = "Save to Controller";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Futura Hv BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(44, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Settings";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSaveSettings);
            this.panel3.Controls.Add(this.btnCalibrate);
            this.panel3.Controls.Add(this.btnResetDefault);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 692);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panel3.Size = new System.Drawing.Size(1159, 57);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Hv BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rapid Trigger";
            // 
            // lblRTDescription
            // 
            this.lblRTDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRTDescription.AutoEllipsis = true;
            this.lblRTDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblRTDescription.Font = new System.Drawing.Font("Futura Bk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRTDescription.Location = new System.Drawing.Point(7, 35);
            this.lblRTDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRTDescription.Name = "lblRTDescription";
            this.lblRTDescription.Size = new System.Drawing.Size(498, 90);
            this.lblRTDescription.TabIndex = 4;
            this.lblRTDescription.Text = "Continuous Rapid Trigger is active once a key passes its actuation point and rema" +
    "ins active until the key is fully released.";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboRTMode);
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblRTDescription);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(559, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 217);
            this.panel2.TabIndex = 5;
            // 
            // cboRTMode
            // 
            this.cboRTMode.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboRTMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRTMode.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRTMode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cboRTMode.FormattingEnabled = true;
            this.cboRTMode.Location = new System.Drawing.Point(164, 6);
            this.cboRTMode.Margin = new System.Windows.Forms.Padding(2);
            this.cboRTMode.Name = "cboRTMode";
            this.cboRTMode.Size = new System.Drawing.Size(127, 29);
            this.cboRTMode.TabIndex = 8;
            this.cboRTMode.SelectedIndexChanged += new System.EventHandler(this.cboRTMode_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.Controls.Add(this.lblRTSensitivity, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.barRTSensitivity, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 128);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(494, 50);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // lblRTSensitivity
            // 
            this.lblRTSensitivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRTSensitivity.AutoSize = true;
            this.lblRTSensitivity.Font = new System.Drawing.Font("Futura Bk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTSensitivity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRTSensitivity.Location = new System.Drawing.Point(416, 14);
            this.lblRTSensitivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRTSensitivity.Name = "lblRTSensitivity";
            this.lblRTSensitivity.Size = new System.Drawing.Size(76, 22);
            this.lblRTSensitivity.TabIndex = 7;
            this.lblRTSensitivity.Text = "-- mm";
            // 
            // barRTSensitivity
            // 
            this.barRTSensitivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.barRTSensitivity.LargeChange = 25;
            this.barRTSensitivity.Location = new System.Drawing.Point(2, 2);
            this.barRTSensitivity.Margin = new System.Windows.Forms.Padding(2);
            this.barRTSensitivity.Maximum = 575;
            this.barRTSensitivity.Minimum = 25;
            this.barRTSensitivity.Name = "barRTSensitivity";
            this.barRTSensitivity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barRTSensitivity.Size = new System.Drawing.Size(410, 45);
            this.barRTSensitivity.SmallChange = 25;
            this.barRTSensitivity.TabIndex = 5;
            this.barRTSensitivity.TickFrequency = 25;
            this.barRTSensitivity.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.barRTSensitivity.Value = 25;
            this.barRTSensitivity.Scroll += new System.EventHandler(this.barRTSensitivity_Scroll);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Futura Bk BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sensitivity";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 431);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1066, 250);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectAll.Font = new System.Drawing.Font("Futura Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.Location = new System.Drawing.Point(840, 384);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(130, 32);
            this.btnSelectAll.TabIndex = 6;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnRemoveSelection
            // 
            this.btnRemoveSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSelection.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveSelection.Font = new System.Drawing.Font("Futura Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelection.Location = new System.Drawing.Point(981, 384);
            this.btnRemoveSelection.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveSelection.Name = "btnRemoveSelection";
            this.btnRemoveSelection.Size = new System.Drawing.Size(130, 32);
            this.btnRemoveSelection.TabIndex = 7;
            this.btnRemoveSelection.Text = "Unselect All";
            this.btnRemoveSelection.UseVisualStyleBackColor = false;
            this.btnRemoveSelection.Click += new System.EventHandler(this.btnRemoveSelection_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.btnUp);
            this.panel4.Controls.Add(this.btnA);
            this.panel4.Controls.Add(this.btnB);
            this.panel4.Controls.Add(this.btnR2);
            this.panel4.Controls.Add(this.btnL2);
            this.panel4.Controls.Add(this.btnL1);
            this.panel4.Controls.Add(this.btnR1);
            this.panel4.Controls.Add(this.btnY);
            this.panel4.Controls.Add(this.btnX);
            this.panel4.Controls.Add(this.btnRight);
            this.panel4.Controls.Add(this.btnDown);
            this.panel4.Controls.Add(this.btnLeft);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(9, 17);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1140, 364);
            this.panel4.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1066, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // SerialPort1
            // 
            this.SerialPort1.ReadTimeout = 5000;
            // 
            // btnUp
            // 
            this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(498, 235);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(80, 80);
            this.btnUp.TabIndex = 20;
            this.btnUp.Text = "0.0";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnA
            // 
            this.btnA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(532, 160);
            this.btnA.Margin = new System.Windows.Forms.Padding(2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(64, 64);
            this.btnA.TabIndex = 19;
            this.btnA.Text = "0.0";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(599, 124);
            this.btnB.Margin = new System.Windows.Forms.Padding(2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(64, 64);
            this.btnB.TabIndex = 18;
            this.btnB.Text = "0.0";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnR2
            // 
            this.btnR2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnR2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnR2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnR2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnR2.FlatAppearance.BorderSize = 0;
            this.btnR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR2.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR2.Location = new System.Drawing.Point(669, 125);
            this.btnR2.Margin = new System.Windows.Forms.Padding(2);
            this.btnR2.Name = "btnR2";
            this.btnR2.Size = new System.Drawing.Size(64, 64);
            this.btnR2.TabIndex = 17;
            this.btnR2.Text = "0.0";
            this.btnR2.UseVisualStyleBackColor = false;
            this.btnR2.Click += new System.EventHandler(this.btnR2_Click);
            // 
            // btnL2
            // 
            this.btnL2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnL2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnL2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnL2.FlatAppearance.BorderSize = 0;
            this.btnL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL2.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL2.Location = new System.Drawing.Point(739, 147);
            this.btnL2.Margin = new System.Windows.Forms.Padding(2);
            this.btnL2.Name = "btnL2";
            this.btnL2.Size = new System.Drawing.Size(64, 64);
            this.btnL2.TabIndex = 16;
            this.btnL2.Text = "0.0";
            this.btnL2.UseVisualStyleBackColor = false;
            this.btnL2.Click += new System.EventHandler(this.btnL2_Click);
            // 
            // btnL1
            // 
            this.btnL1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnL1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnL1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnL1.FlatAppearance.BorderSize = 0;
            this.btnL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL1.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL1.Location = new System.Drawing.Point(739, 74);
            this.btnL1.Margin = new System.Windows.Forms.Padding(2);
            this.btnL1.Name = "btnL1";
            this.btnL1.Size = new System.Drawing.Size(64, 64);
            this.btnL1.TabIndex = 15;
            this.btnL1.Text = "0.0";
            this.btnL1.UseVisualStyleBackColor = false;
            this.btnL1.Click += new System.EventHandler(this.btnL1_Click);
            // 
            // btnR1
            // 
            this.btnR1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnR1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnR1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnR1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnR1.FlatAppearance.BorderSize = 0;
            this.btnR1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR1.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR1.Location = new System.Drawing.Point(669, 51);
            this.btnR1.Margin = new System.Windows.Forms.Padding(2);
            this.btnR1.Name = "btnR1";
            this.btnR1.Size = new System.Drawing.Size(64, 64);
            this.btnR1.TabIndex = 14;
            this.btnR1.Text = "0.0";
            this.btnR1.UseVisualStyleBackColor = false;
            this.btnR1.Click += new System.EventHandler(this.btnR1_Click);
            // 
            // btnY
            // 
            this.btnY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnY.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnY.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnY.FlatAppearance.BorderSize = 0;
            this.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnY.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(598, 51);
            this.btnY.Margin = new System.Windows.Forms.Padding(2);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(64, 64);
            this.btnY.TabIndex = 13;
            this.btnY.Text = "0.0";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnX
            // 
            this.btnX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(536, 88);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(64, 64);
            this.btnX.TabIndex = 12;
            this.btnX.Text = "0.0";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(473, 119);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(64, 64);
            this.btnRight.TabIndex = 11;
            this.btnRight.Text = "0.0";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDown.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(410, 84);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(64, 64);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "0.0";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Futura Hv BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(338, 84);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(64, 64);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "0.0";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1159, 749);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnRemoveSelection);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1359, 788);
            this.MinimumSize = new System.Drawing.Size(907, 788);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapid Trigger Configurator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barActuationPoint)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barRTSensitivity)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetDefault;
        private System.Windows.Forms.Button btnCalibrate;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRTDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar barActuationPoint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblActuationPoint;
        private System.Windows.Forms.ComboBox cboRTMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TrackBar barRTSensitivity;
        private System.Windows.Forms.Label lblRTSensitivity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnRemoveSelection;
        private System.Windows.Forms.Panel panel4;
        private RoundButtonControl btnLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundButtonControl btnUp;
        private RoundButtonControl btnA;
        private RoundButtonControl btnB;
        private RoundButtonControl btnR2;
        private RoundButtonControl btnL2;
        private RoundButtonControl btnL1;
        private RoundButtonControl btnR1;
        private RoundButtonControl btnY;
        private RoundButtonControl btnX;
        private RoundButtonControl btnRight;
        private RoundButtonControl btnDown;
        public System.IO.Ports.SerialPort SerialPort1;
    }
}

