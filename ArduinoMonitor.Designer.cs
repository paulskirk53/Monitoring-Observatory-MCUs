namespace Monitoring
{
    partial class ArduinoMonitor
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
            this.gpboxStepper = new System.Windows.Forms.GroupBox();
            this.btnConnectToStepper = new System.Windows.Forms.Button();
            this.lblCommsEncoderValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblAzimuth = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblStepper = new System.Windows.Forms.Label();
            this.lblMoving = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.gpboxEncoder = new System.Windows.Forms.GroupBox();
            this.lblAzimuthValue = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEncoder = new System.Windows.Forms.Label();
            this.btnConnectToEncoder = new System.Windows.Forms.Button();
            this.cmbPickStepperPort = new System.Windows.Forms.ComboBox();
            this.tmrStepperRequests = new System.Windows.Forms.Timer(this.components);
            this.tmrEncoderRequests = new System.Windows.Forms.Timer(this.components);
            this.toolTipPK = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpowerActivate = new System.Windows.Forms.Button();
            this.BTNCamon = new System.Windows.Forms.Button();
            this.lblCamerapowerstatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnresetStepper = new System.Windows.Forms.Button();
            this.btnresetEncoder = new System.Windows.Forms.Button();
            this.btnactivate = new System.Windows.Forms.Button();
            this.tabMonitor = new System.Windows.Forms.TabControl();
            this.tabDome = new System.Windows.Forms.TabPage();
            this.tabShutter = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.gpboxStepper.SuspendLayout();
            this.gpboxEncoder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            this.tabDome.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxStepper
            // 
            this.gpboxStepper.Controls.Add(this.btnConnectToStepper);
            this.gpboxStepper.Controls.Add(this.lblCommsEncoderValue);
            this.gpboxStepper.Controls.Add(this.label3);
            this.gpboxStepper.Controls.Add(this.lbl6);
            this.gpboxStepper.Controls.Add(this.lblDirection);
            this.gpboxStepper.Controls.Add(this.lblAzimuth);
            this.gpboxStepper.Controls.Add(this.lblDistance);
            this.gpboxStepper.Controls.Add(this.lblStepper);
            this.gpboxStepper.Controls.Add(this.lblMoving);
            this.gpboxStepper.Controls.Add(this.lblTarget);
            this.gpboxStepper.Controls.Add(this.lbl5);
            this.gpboxStepper.Controls.Add(this.lbl4);
            this.gpboxStepper.Controls.Add(this.lbl3);
            this.gpboxStepper.Controls.Add(this.lbl2);
            this.gpboxStepper.Controls.Add(this.lbl1);
            this.gpboxStepper.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxStepper.Location = new System.Drawing.Point(42, 24);
            this.gpboxStepper.Name = "gpboxStepper";
            this.gpboxStepper.Size = new System.Drawing.Size(433, 176);
            this.gpboxStepper.TabIndex = 0;
            this.gpboxStepper.TabStop = false;
            this.gpboxStepper.Text = "Stepper MCU";
            // 
            // btnConnectToStepper
            // 
            this.btnConnectToStepper.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectToStepper.Location = new System.Drawing.Point(285, 29);
            this.btnConnectToStepper.Name = "btnConnectToStepper";
            this.btnConnectToStepper.Size = new System.Drawing.Size(117, 62);
            this.btnConnectToStepper.TabIndex = 2;
            this.btnConnectToStepper.Text = "Connect";
            this.btnConnectToStepper.UseVisualStyleBackColor = true;
            this.btnConnectToStepper.Click += new System.EventHandler(this.btnConnectToStepper_Click);
            // 
            // lblCommsEncoderValue
            // 
            this.lblCommsEncoderValue.AutoSize = true;
            this.lblCommsEncoderValue.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCommsEncoderValue.Location = new System.Drawing.Point(159, 134);
            this.lblCommsEncoderValue.Name = "lblCommsEncoderValue";
            this.lblCommsEncoderValue.Size = new System.Drawing.Size(56, 16);
            this.lblCommsEncoderValue.TabIndex = 11;
            this.lblCommsEncoderValue.Text = "............";
            this.toolTipPK.SetToolTip(this.lblCommsEncoderValue, "This is the comms state between the two Arduino MCUs");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Connection Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(17, 134);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(111, 16);
            this.lbl6.TabIndex = 10;
            this.lbl6.Text = "Encoder Comms";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.Location = new System.Drawing.Point(159, 51);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(100, 16);
            this.lblDirection.TabIndex = 9;
            this.lblDirection.Text = "Awaiting  data";
            // 
            // lblAzimuth
            // 
            this.lblAzimuth.AutoSize = true;
            this.lblAzimuth.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzimuth.Location = new System.Drawing.Point(159, 113);
            this.lblAzimuth.Name = "lblAzimuth";
            this.lblAzimuth.Size = new System.Drawing.Size(29, 16);
            this.lblAzimuth.TabIndex = 8;
            this.lblAzimuth.Text = "999";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(159, 92);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(100, 16);
            this.lblDistance.TabIndex = 7;
            this.lblDistance.Text = "Awaiting  data";
            // 
            // lblStepper
            // 
            this.lblStepper.BackColor = System.Drawing.Color.Black;
            this.lblStepper.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepper.ForeColor = System.Drawing.SystemColors.Info;
            this.lblStepper.Location = new System.Drawing.Point(280, 134);
            this.lblStepper.Name = "lblStepper";
            this.lblStepper.Size = new System.Drawing.Size(117, 23);
            this.lblStepper.TabIndex = 7;
            this.lblStepper.Text = "Not Connected COM5";
            this.lblStepper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoving
            // 
            this.lblMoving.AutoSize = true;
            this.lblMoving.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoving.Location = new System.Drawing.Point(159, 71);
            this.lblMoving.Name = "lblMoving";
            this.lblMoving.Size = new System.Drawing.Size(100, 16);
            this.lblMoving.TabIndex = 6;
            this.lblMoving.Text = "Awaiting  data";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarget.Location = new System.Drawing.Point(159, 29);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(29, 16);
            this.lblTarget.TabIndex = 5;
            this.lblTarget.Text = "999";
            // 
            // lbl5
            // 
            this.lbl5.AccessibleDescription = "Sent from Encoder";
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(16, 113);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(117, 16);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Degrees to target";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(16, 92);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(91, 16);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Target Status";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(16, 71);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(117, 16);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Movement Status";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(16, 51);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(134, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Movement direction";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(16, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "ASCOM Target";
            // 
            // gpboxEncoder
            // 
            this.gpboxEncoder.Controls.Add(this.lblAzimuthValue);
            this.gpboxEncoder.Controls.Add(this.lblStatus);
            this.gpboxEncoder.Controls.Add(this.lbl9);
            this.gpboxEncoder.Controls.Add(this.lbl8);
            this.gpboxEncoder.Controls.Add(this.label1);
            this.gpboxEncoder.Controls.Add(this.lblEncoder);
            this.gpboxEncoder.Controls.Add(this.btnConnectToEncoder);
            this.gpboxEncoder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxEncoder.Location = new System.Drawing.Point(42, 225);
            this.gpboxEncoder.Name = "gpboxEncoder";
            this.gpboxEncoder.Size = new System.Drawing.Size(433, 139);
            this.gpboxEncoder.TabIndex = 1;
            this.gpboxEncoder.TabStop = false;
            this.gpboxEncoder.Text = "Encoder MCU";
            // 
            // lblAzimuthValue
            // 
            this.lblAzimuthValue.AutoSize = true;
            this.lblAzimuthValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzimuthValue.Location = new System.Drawing.Point(156, 59);
            this.lblAzimuthValue.Name = "lblAzimuthValue";
            this.lblAzimuthValue.Size = new System.Drawing.Size(29, 16);
            this.lblAzimuthValue.TabIndex = 7;
            this.lblAzimuthValue.Text = "999";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Info;
            this.lblStatus.Location = new System.Drawing.Point(162, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 16);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "..........";
            this.toolTipPK.SetToolTip(this.lblStatus, "Indicates that the comms between the Encoder and Stepper MCUs is live");
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(13, 59);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(111, 16);
            this.lbl9.TabIndex = 1;
            this.lbl9.Text = "Current Azimuth";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(13, 27);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(109, 16);
            this.lbl8.TabIndex = 0;
            this.lbl8.Text = "Stepper Comms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Connection Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEncoder
            // 
            this.lblEncoder.BackColor = System.Drawing.Color.Black;
            this.lblEncoder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncoder.ForeColor = System.Drawing.SystemColors.Info;
            this.lblEncoder.Location = new System.Drawing.Point(280, 103);
            this.lblEncoder.Name = "lblEncoder";
            this.lblEncoder.Size = new System.Drawing.Size(122, 22);
            this.lblEncoder.TabIndex = 8;
            this.lblEncoder.Text = "Not Connected COM4";
            this.lblEncoder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnectToEncoder
            // 
            this.btnConnectToEncoder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectToEncoder.Location = new System.Drawing.Point(282, 14);
            this.btnConnectToEncoder.Name = "btnConnectToEncoder";
            this.btnConnectToEncoder.Size = new System.Drawing.Size(117, 58);
            this.btnConnectToEncoder.TabIndex = 4;
            this.btnConnectToEncoder.Text = "Connect";
            this.btnConnectToEncoder.UseVisualStyleBackColor = true;
            this.btnConnectToEncoder.Click += new System.EventHandler(this.btnConnectToEncoder_Click);
            // 
            // cmbPickStepperPort
            // 
            this.cmbPickStepperPort.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPickStepperPort.FormattingEnabled = true;
            this.cmbPickStepperPort.Location = new System.Drawing.Point(111, 104);
            this.cmbPickStepperPort.Name = "cmbPickStepperPort";
            this.cmbPickStepperPort.Size = new System.Drawing.Size(138, 24);
            this.cmbPickStepperPort.TabIndex = 6;
            this.cmbPickStepperPort.Text = "Port info";
            this.toolTipPK.SetToolTip(this.cmbPickStepperPort, "Port info");
            // 
            // tmrStepperRequests
            // 
            this.tmrStepperRequests.Interval = 15;
            this.tmrStepperRequests.Tick += new System.EventHandler(this.tmrStepperRequests_Tick);
            // 
            // tmrEncoderRequests
            // 
            this.tmrEncoderRequests.Interval = 200;
            this.tmrEncoderRequests.Tick += new System.EventHandler(this.tmrEncoderRequests_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Version";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpowerActivate);
            this.groupBox1.Controls.Add(this.BTNCamon);
            this.groupBox1.Controls.Add(this.lblCamerapowerstatus);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 56);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera and Rotator Power";
            // 
            // btnpowerActivate
            // 
            this.btnpowerActivate.Enabled = false;
            this.btnpowerActivate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpowerActivate.Location = new System.Drawing.Point(16, 25);
            this.btnpowerActivate.Name = "btnpowerActivate";
            this.btnpowerActivate.Size = new System.Drawing.Size(114, 23);
            this.btnpowerActivate.TabIndex = 3;
            this.btnpowerActivate.Text = "Toggle";
            this.btnpowerActivate.UseVisualStyleBackColor = true;
            this.btnpowerActivate.Click += new System.EventHandler(this.btnpowerActivate_Click);
            // 
            // BTNCamon
            // 
            this.BTNCamon.Enabled = false;
            this.BTNCamon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCamon.Location = new System.Drawing.Point(156, 26);
            this.BTNCamon.Name = "BTNCamon";
            this.BTNCamon.Size = new System.Drawing.Size(96, 25);
            this.BTNCamon.TabIndex = 0;
            this.BTNCamon.Text = "Turn On";
            this.BTNCamon.UseVisualStyleBackColor = true;
            this.BTNCamon.Click += new System.EventHandler(this.BTNCamon_Click);
            // 
            // lblCamerapowerstatus
            // 
            this.lblCamerapowerstatus.AutoSize = true;
            this.lblCamerapowerstatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamerapowerstatus.Location = new System.Drawing.Point(295, 29);
            this.lblCamerapowerstatus.Name = "lblCamerapowerstatus";
            this.lblCamerapowerstatus.Size = new System.Drawing.Size(144, 16);
            this.lblCamerapowerstatus.TabIndex = 17;
            this.lblCamerapowerstatus.Text = "Camera Power State ";
            this.lblCamerapowerstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnresetStepper);
            this.groupBox2.Controls.Add(this.btnresetEncoder);
            this.groupBox2.Controls.Add(this.btnactivate);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 53);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resets";
            // 
            // btnresetStepper
            // 
            this.btnresetStepper.Enabled = false;
            this.btnresetStepper.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetStepper.Location = new System.Drawing.Point(298, 17);
            this.btnresetStepper.Name = "btnresetStepper";
            this.btnresetStepper.Size = new System.Drawing.Size(116, 25);
            this.btnresetStepper.TabIndex = 2;
            this.btnresetStepper.Text = "Reset Stepper";
            this.btnresetStepper.UseVisualStyleBackColor = true;
            this.btnresetStepper.Click += new System.EventHandler(this.btnresetStepper_Click);
            // 
            // btnresetEncoder
            // 
            this.btnresetEncoder.Enabled = false;
            this.btnresetEncoder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetEncoder.Location = new System.Drawing.Point(155, 16);
            this.btnresetEncoder.Name = "btnresetEncoder";
            this.btnresetEncoder.Size = new System.Drawing.Size(121, 25);
            this.btnresetEncoder.TabIndex = 1;
            this.btnresetEncoder.Text = "Reset Encoder";
            this.btnresetEncoder.UseVisualStyleBackColor = true;
            this.btnresetEncoder.Click += new System.EventHandler(this.btnresetEncoder_Click);
            // 
            // btnactivate
            // 
            this.btnactivate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.Location = new System.Drawing.Point(16, 19);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(114, 23);
            this.btnactivate.TabIndex = 0;
            this.btnactivate.Text = "Toggle";
            this.btnactivate.UseVisualStyleBackColor = true;
            this.btnactivate.Click += new System.EventHandler(this.btnactivate_Click);
            // 
            // tabMonitor
            // 
            this.tabMonitor.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMonitor.Controls.Add(this.tabDome);
            this.tabMonitor.Controls.Add(this.tabShutter);
            this.tabMonitor.Controls.Add(this.tabInfo);
            this.tabMonitor.ItemSize = new System.Drawing.Size(80, 30);
            this.tabMonitor.Location = new System.Drawing.Point(27, 6);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.SelectedIndex = 0;
            this.tabMonitor.Size = new System.Drawing.Size(525, 534);
            this.tabMonitor.TabIndex = 19;
            // 
            // tabDome
            // 
            this.tabDome.BackColor = System.Drawing.Color.Khaki;
            this.tabDome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabDome.Controls.Add(this.gpboxStepper);
            this.tabDome.Controls.Add(this.groupBox2);
            this.tabDome.Controls.Add(this.gpboxEncoder);
            this.tabDome.Controls.Add(this.groupBox1);
            this.tabDome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabDome.Location = new System.Drawing.Point(4, 34);
            this.tabDome.Name = "tabDome";
            this.tabDome.Padding = new System.Windows.Forms.Padding(3);
            this.tabDome.Size = new System.Drawing.Size(517, 496);
            this.tabDome.TabIndex = 0;
            this.tabDome.Text = "Dome";
            // 
            // tabShutter
            // 
            this.tabShutter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabShutter.Location = new System.Drawing.Point(4, 34);
            this.tabShutter.Name = "tabShutter";
            this.tabShutter.Padding = new System.Windows.Forms.Padding(3);
            this.tabShutter.Size = new System.Drawing.Size(517, 496);
            this.tabShutter.TabIndex = 1;
            this.tabShutter.Text = "Shutter";
            this.tabShutter.UseVisualStyleBackColor = true;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.label2);
            this.tabInfo.Controls.Add(this.cmbPickStepperPort);
            this.tabInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInfo.Location = new System.Drawing.Point(4, 34);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(517, 496);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // ArduinoMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(579, 552);
            this.Controls.Add(this.tabMonitor);
            this.Name = "ArduinoMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control MCU Monitoring";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArduinoMonitor_FormClosing);
            this.gpboxStepper.ResumeLayout(false);
            this.gpboxStepper.PerformLayout();
            this.gpboxEncoder.ResumeLayout(false);
            this.gpboxEncoder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabMonitor.ResumeLayout(false);
            this.tabDome.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxStepper;
        private System.Windows.Forms.GroupBox gpboxEncoder;
        private System.Windows.Forms.Button btnConnectToStepper;
        private System.Windows.Forms.Button btnConnectToEncoder;
        private System.Windows.Forms.ComboBox cmbPickStepperPort;
        private System.Windows.Forms.Label lblStepper;
        private System.Windows.Forms.Label lblEncoder;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblAzimuth;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblMoving;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lblAzimuthValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCommsEncoderValue;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Timer tmrStepperRequests;
        private System.Windows.Forms.Timer tmrEncoderRequests;
        private System.Windows.Forms.ToolTip toolTipPK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNCamon;
        private System.Windows.Forms.Label lblCamerapowerstatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnresetStepper;
        private System.Windows.Forms.Button btnresetEncoder;
        private System.Windows.Forms.Button btnactivate;
        private System.Windows.Forms.Button btnpowerActivate;
        private System.Windows.Forms.TabControl tabMonitor;
        private System.Windows.Forms.TabPage tabDome;
        private System.Windows.Forms.TabPage tabShutter;
        private System.Windows.Forms.TabPage tabInfo;
    }
}

