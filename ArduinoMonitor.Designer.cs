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
            this.label1 = new System.Windows.Forms.Label();
            this.lbldataTick = new System.Windows.Forms.Label();
            this.lblDomeAzimuth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lbldegreesToTarget = new System.Windows.Forms.Label();
            this.lbltargetStatus = new System.Windows.Forms.Label();
            this.lblControlBox = new System.Windows.Forms.Label();
            this.lblMoving = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblTargetDescription = new System.Windows.Forms.Label();
            this.tmrControloxRequests = new System.Windows.Forms.Timer(this.components);
            this.toolTipPK = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblsync = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpowerActivate = new System.Windows.Forms.Button();
            this.BTNCameraSwitch = new System.Windows.Forms.Button();
            this.lblCamerapowerstatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnresetControlBox = new System.Windows.Forms.Button();
            this.btnactivate = new System.Windows.Forms.Button();
            this.tabMonitor = new System.Windows.Forms.TabControl();
            this.tabDome = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.panelHomePark = new System.Windows.Forms.Panel();
            this.btnGet = new System.Windows.Forms.Button();
            this.numericUpDownHome = new System.Windows.Forms.NumericUpDown();
            this.lblParkValue = new System.Windows.Forms.Label();
            this.numericUpDownPark = new System.Windows.Forms.NumericUpDown();
            this.lblHomeValue = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblPark = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.tabMotor = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.numericUpDownMotorShaftRevsPerDomeRev = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownControllerDIP = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabEncoder = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDownEncoderRevsPerDomeRev = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownTicksPerDomeRev = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownEncoderTicks = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.rbtnConnect = new Monitoring.RoundButton();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gpboxStepper.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            this.tabDome.SuspendLayout();
            this.panelHomePark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPark)).BeginInit();
            this.tabMotor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMotorShaftRevsPerDomeRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownControllerDIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabEncoder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEncoderRevsPerDomeRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicksPerDomeRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEncoderTicks)).BeginInit();
            this.SuspendLayout();
            // 
            // gpboxStepper
            // 
            this.gpboxStepper.Controls.Add(this.rbtnConnect);
            this.gpboxStepper.Controls.Add(this.label1);
            this.gpboxStepper.Controls.Add(this.lbldataTick);
            this.gpboxStepper.Controls.Add(this.lblDomeAzimuth);
            this.gpboxStepper.Controls.Add(this.label3);
            this.gpboxStepper.Controls.Add(this.lbl6);
            this.gpboxStepper.Controls.Add(this.lblDirection);
            this.gpboxStepper.Controls.Add(this.lbldegreesToTarget);
            this.gpboxStepper.Controls.Add(this.lbltargetStatus);
            this.gpboxStepper.Controls.Add(this.lblControlBox);
            this.gpboxStepper.Controls.Add(this.lblMoving);
            this.gpboxStepper.Controls.Add(this.lblTarget);
            this.gpboxStepper.Controls.Add(this.lbl5);
            this.gpboxStepper.Controls.Add(this.lbl4);
            this.gpboxStepper.Controls.Add(this.lbl3);
            this.gpboxStepper.Controls.Add(this.lbl2);
            this.gpboxStepper.Controls.Add(this.lblTargetDescription);
            this.gpboxStepper.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxStepper.Location = new System.Drawing.Point(42, 20);
            this.gpboxStepper.Name = "gpboxStepper";
            this.gpboxStepper.Size = new System.Drawing.Size(465, 207);
            this.gpboxStepper.TabIndex = 0;
            this.gpboxStepper.TabStop = false;
            this.gpboxStepper.Text = "Monitoring Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data Request indicator";
            // 
            // lbldataTick
            // 
            this.lbldataTick.AutoSize = true;
            this.lbldataTick.Location = new System.Drawing.Point(408, 166);
            this.lbldataTick.Name = "lbldataTick";
            this.lbldataTick.Size = new System.Drawing.Size(32, 16);
            this.lbldataTick.TabIndex = 16;
            this.lbldataTick.Text = "Pull";
            // 
            // lblDomeAzimuth
            // 
            this.lblDomeAzimuth.AutoSize = true;
            this.lblDomeAzimuth.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomeAzimuth.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDomeAzimuth.Location = new System.Drawing.Point(159, 161);
            this.lblDomeAzimuth.Name = "lblDomeAzimuth";
            this.lblDomeAzimuth.Size = new System.Drawing.Size(46, 24);
            this.lblDomeAzimuth.TabIndex = 11;
            this.lblDomeAzimuth.Text = "999";
            this.toolTipPK.SetToolTip(this.lblDomeAzimuth, "This is the comms state between the two Arduino MCUs");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Connection Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl6.Location = new System.Drawing.Point(17, 162);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(120, 19);
            this.lbl6.TabIndex = 10;
            this.lbl6.Text = "Dome Azimuth";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.Location = new System.Drawing.Point(159, 51);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(99, 16);
            this.lblDirection.TabIndex = 9;
            this.lblDirection.Text = "Awaiting  data";
            // 
            // lbldegreesToTarget
            // 
            this.lbldegreesToTarget.AutoSize = true;
            this.lbldegreesToTarget.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldegreesToTarget.ForeColor = System.Drawing.Color.Maroon;
            this.lbldegreesToTarget.Location = new System.Drawing.Point(159, 120);
            this.lbldegreesToTarget.Name = "lbldegreesToTarget";
            this.lbldegreesToTarget.Size = new System.Drawing.Size(36, 19);
            this.lbldegreesToTarget.TabIndex = 8;
            this.lbldegreesToTarget.Text = "999";
            // 
            // lbltargetStatus
            // 
            this.lbltargetStatus.AutoSize = true;
            this.lbltargetStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltargetStatus.Location = new System.Drawing.Point(159, 89);
            this.lbltargetStatus.Name = "lbltargetStatus";
            this.lbltargetStatus.Size = new System.Drawing.Size(99, 16);
            this.lbltargetStatus.TabIndex = 7;
            this.lbltargetStatus.Text = "Awaiting  data";
            // 
            // lblControlBox
            // 
            this.lblControlBox.BackColor = System.Drawing.Color.Black;
            this.lblControlBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlBox.ForeColor = System.Drawing.SystemColors.Info;
            this.lblControlBox.Location = new System.Drawing.Point(291, 115);
            this.lblControlBox.Name = "lblControlBox";
            this.lblControlBox.Size = new System.Drawing.Size(176, 30);
            this.lblControlBox.TabIndex = 7;
            this.lblControlBox.Text = "Not Connected";
            this.lblControlBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoving
            // 
            this.lblMoving.AutoSize = true;
            this.lblMoving.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoving.Location = new System.Drawing.Point(159, 71);
            this.lblMoving.Name = "lblMoving";
            this.lblMoving.Size = new System.Drawing.Size(99, 16);
            this.lblMoving.TabIndex = 6;
            this.lblMoving.Text = "Awaiting  data";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarget.ForeColor = System.Drawing.Color.Black;
            this.lblTarget.Location = new System.Drawing.Point(159, 29);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(28, 16);
            this.lblTarget.TabIndex = 5;
            this.lblTarget.Text = "999";
            // 
            // lbl5
            // 
            this.lbl5.AccessibleDescription = "Sent from Encoder";
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(16, 120);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(116, 16);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Degrees to target";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(16, 89);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(90, 16);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Target Status";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(16, 71);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(116, 16);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Movement Status";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(16, 51);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(133, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Movement direction";
            // 
            // lblTargetDescription
            // 
            this.lblTargetDescription.AutoSize = true;
            this.lblTargetDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetDescription.ForeColor = System.Drawing.Color.Black;
            this.lblTargetDescription.Location = new System.Drawing.Point(16, 29);
            this.lblTargetDescription.Name = "lblTargetDescription";
            this.lblTargetDescription.Size = new System.Drawing.Size(99, 16);
            this.lblTargetDescription.TabIndex = 0;
            this.lblTargetDescription.Text = "ASCOM Target";
            // 
            // tmrControloxRequests
            // 
            this.tmrControloxRequests.Interval = 1500;
            this.tmrControloxRequests.Tick += new System.EventHandler(this.tmrControlBoxRequests_Tick);
            // 
            // toolTipPK
            // 
            this.toolTipPK.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipPK_Popup);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblsync);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(344, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 50);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dome Sync";
            this.toolTipPK.SetToolTip(this.groupBox3, "Has the Dome Azimuth sync\'d ");
            // 
            // lblsync
            // 
            this.lblsync.AutoSize = true;
            this.lblsync.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsync.Location = new System.Drawing.Point(11, 34);
            this.lblsync.Name = "lblsync";
            this.lblsync.Size = new System.Drawing.Size(56, 16);
            this.lblsync.TabIndex = 19;
            this.lblsync.Text = "No data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpowerActivate);
            this.groupBox1.Controls.Add(this.BTNCameraSwitch);
            this.groupBox1.Controls.Add(this.lblCamerapowerstatus);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 230);
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
            this.btnpowerActivate.Location = new System.Drawing.Point(16, 30);
            this.btnpowerActivate.Name = "btnpowerActivate";
            this.btnpowerActivate.Size = new System.Drawing.Size(114, 23);
            this.btnpowerActivate.TabIndex = 3;
            this.btnpowerActivate.Text = "Toggle";
            this.btnpowerActivate.UseVisualStyleBackColor = true;
            this.btnpowerActivate.Click += new System.EventHandler(this.btnpowerActivate_Click);
            // 
            // BTNCameraSwitch
            // 
            this.BTNCameraSwitch.Enabled = false;
            this.BTNCameraSwitch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCameraSwitch.Location = new System.Drawing.Point(156, 31);
            this.BTNCameraSwitch.Name = "BTNCameraSwitch";
            this.BTNCameraSwitch.Size = new System.Drawing.Size(96, 25);
            this.BTNCameraSwitch.TabIndex = 0;
            this.BTNCameraSwitch.Text = "Turn On";
            this.BTNCameraSwitch.UseVisualStyleBackColor = true;
            this.BTNCameraSwitch.Click += new System.EventHandler(this.BTNCameraSwitch_Click);
            // 
            // lblCamerapowerstatus
            // 
            this.lblCamerapowerstatus.AutoSize = true;
            this.lblCamerapowerstatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamerapowerstatus.Location = new System.Drawing.Point(295, 34);
            this.lblCamerapowerstatus.Name = "lblCamerapowerstatus";
            this.lblCamerapowerstatus.Size = new System.Drawing.Size(143, 16);
            this.lblCamerapowerstatus.TabIndex = 17;
            this.lblCamerapowerstatus.Text = "Camera Power State ";
            this.lblCamerapowerstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnresetControlBox);
            this.groupBox2.Controls.Add(this.btnactivate);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 53);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resets";
            // 
            // btnresetControlBox
            // 
            this.btnresetControlBox.Location = new System.Drawing.Point(160, 28);
            this.btnresetControlBox.Name = "btnresetControlBox";
            this.btnresetControlBox.Size = new System.Drawing.Size(110, 24);
            this.btnresetControlBox.TabIndex = 2;
            this.btnresetControlBox.Text = "Reset the MCU";
            this.btnresetControlBox.UseVisualStyleBackColor = true;
            this.btnresetControlBox.Click += new System.EventHandler(this.btnresetControlBox_Click);
            // 
            // btnactivate
            // 
            this.btnactivate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.Location = new System.Drawing.Point(16, 29);
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
            this.tabMonitor.Controls.Add(this.tabMotor);
            this.tabMonitor.Controls.Add(this.tabEncoder);
            this.tabMonitor.ItemSize = new System.Drawing.Size(80, 30);
            this.tabMonitor.Location = new System.Drawing.Point(28, 6);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.SelectedIndex = 0;
            this.tabMonitor.Size = new System.Drawing.Size(525, 534);
            this.tabMonitor.TabIndex = 19;
            // 
            // tabDome
            // 
            this.tabDome.BackColor = System.Drawing.Color.Moccasin;
            this.tabDome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabDome.Controls.Add(this.label4);
            this.tabDome.Controls.Add(this.panelHomePark);
            this.tabDome.Controls.Add(this.groupBox3);
            this.tabDome.Controls.Add(this.gpboxStepper);
            this.tabDome.Controls.Add(this.groupBox2);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Home && Park";
            // 
            // panelHomePark
            // 
            this.panelHomePark.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHomePark.Controls.Add(this.btnGet);
            this.panelHomePark.Controls.Add(this.numericUpDownHome);
            this.panelHomePark.Controls.Add(this.lblParkValue);
            this.panelHomePark.Controls.Add(this.numericUpDownPark);
            this.panelHomePark.Controls.Add(this.lblHomeValue);
            this.panelHomePark.Controls.Add(this.lblHome);
            this.panelHomePark.Controls.Add(this.lblPark);
            this.panelHomePark.Controls.Add(this.btnSet);
            this.panelHomePark.Location = new System.Drawing.Point(21, 398);
            this.panelHomePark.Name = "panelHomePark";
            this.panelHomePark.Size = new System.Drawing.Size(248, 81);
            this.panelHomePark.TabIndex = 29;
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(79, 3);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(58, 24);
            this.btnGet.TabIndex = 26;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // numericUpDownHome
            // 
            this.numericUpDownHome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHome.Location = new System.Drawing.Point(154, 33);
            this.numericUpDownHome.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownHome.Name = "numericUpDownHome";
            this.numericUpDownHome.Size = new System.Drawing.Size(62, 22);
            this.numericUpDownHome.TabIndex = 21;
            this.numericUpDownHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownHome.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // lblParkValue
            // 
            this.lblParkValue.AutoSize = true;
            this.lblParkValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkValue.Location = new System.Drawing.Point(97, 59);
            this.lblParkValue.Name = "lblParkValue";
            this.lblParkValue.Size = new System.Drawing.Size(28, 16);
            this.lblParkValue.TabIndex = 27;
            this.lblParkValue.Text = "999";
            // 
            // numericUpDownPark
            // 
            this.numericUpDownPark.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPark.Location = new System.Drawing.Point(153, 57);
            this.numericUpDownPark.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownPark.Name = "numericUpDownPark";
            this.numericUpDownPark.Size = new System.Drawing.Size(62, 22);
            this.numericUpDownPark.TabIndex = 23;
            this.numericUpDownPark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPark.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // lblHomeValue
            // 
            this.lblHomeValue.AutoSize = true;
            this.lblHomeValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeValue.Location = new System.Drawing.Point(96, 35);
            this.lblHomeValue.Name = "lblHomeValue";
            this.lblHomeValue.Size = new System.Drawing.Size(28, 16);
            this.lblHomeValue.TabIndex = 21;
            this.lblHomeValue.Text = "999";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(19, 35);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(44, 16);
            this.lblHome.TabIndex = 21;
            this.lblHome.Text = "Home";
            // 
            // lblPark
            // 
            this.lblPark.AutoSize = true;
            this.lblPark.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPark.Location = new System.Drawing.Point(20, 57);
            this.lblPark.Name = "lblPark";
            this.lblPark.Size = new System.Drawing.Size(36, 16);
            this.lblPark.TabIndex = 24;
            this.lblPark.Text = "Park";
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(153, 3);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(58, 24);
            this.btnSet.TabIndex = 25;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tabMotor
            // 
            this.tabMotor.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tabMotor.Controls.Add(this.label19);
            this.tabMotor.Controls.Add(this.btnLoad);
            this.tabMotor.Controls.Add(this.label18);
            this.tabMotor.Controls.Add(this.label11);
            this.tabMotor.Controls.Add(this.label10);
            this.tabMotor.Controls.Add(this.label9);
            this.tabMotor.Controls.Add(this.label8);
            this.tabMotor.Controls.Add(this.label7);
            this.tabMotor.Controls.Add(this.button1);
            this.tabMotor.Controls.Add(this.btnCalc);
            this.tabMotor.Controls.Add(this.numericUpDownMotorShaftRevsPerDomeRev);
            this.tabMotor.Controls.Add(this.label6);
            this.tabMotor.Controls.Add(this.numericUpDownControllerDIP);
            this.tabMotor.Controls.Add(this.label2);
            this.tabMotor.Controls.Add(this.numericUpDown1);
            this.tabMotor.Controls.Add(this.label5);
            this.tabMotor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMotor.Location = new System.Drawing.Point(4, 34);
            this.tabMotor.Name = "tabMotor";
            this.tabMotor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMotor.Size = new System.Drawing.Size(517, 496);
            this.tabMotor.TabIndex = 1;
            this.tabMotor.Text = "Motor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 22);
            this.label11.TabIndex = 45;
            this.label11.Text = "(3)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 22);
            this.label10.TabIndex = 44;
            this.label10.Text = "(2)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "(1)";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(189, 310);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(186, 27);
            this.label8.TabIndex = 42;
            this.label8.Text = "Calculates 2 from 1 and 3 ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 355);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(187, 55);
            this.label7.TabIndex = 41;
            this.label7.Text = "Saves the Motor shaft revolutions per dome revolution to EEPROM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 40;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(44, 300);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(116, 34);
            this.btnCalc.TabIndex = 39;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMotorShaftRevsPerDomeRev
            // 
            this.numericUpDownMotorShaftRevsPerDomeRev.DecimalPlaces = 2;
            this.numericUpDownMotorShaftRevsPerDomeRev.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMotorShaftRevsPerDomeRev.Location = new System.Drawing.Point(223, 237);
            this.numericUpDownMotorShaftRevsPerDomeRev.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownMotorShaftRevsPerDomeRev.Name = "numericUpDownMotorShaftRevsPerDomeRev";
            this.numericUpDownMotorShaftRevsPerDomeRev.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownMotorShaftRevsPerDomeRev.TabIndex = 38;
            this.numericUpDownMotorShaftRevsPerDomeRev.Value = new decimal(new int[] {
            345,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 223);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(140, 55);
            this.label6.TabIndex = 37;
            this.label6.Text = "Motor shaft revolutions per dome revolution";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDownControllerDIP
            // 
            this.numericUpDownControllerDIP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownControllerDIP.Location = new System.Drawing.Point(222, 120);
            this.numericUpDownControllerDIP.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownControllerDIP.Name = "numericUpDownControllerDIP";
            this.numericUpDownControllerDIP.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownControllerDIP.TabIndex = 36;
            this.numericUpDownControllerDIP.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(140, 49);
            this.label2.TabIndex = 35;
            this.label2.Text = "Controller DIP settings for one shaft rotation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(222, 174);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown1.TabIndex = 34;
            this.numericUpDown1.Value = new decimal(new int[] {
            76333,
            0,
            0,
            196608});
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 167);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 33;
            this.label5.Text = "Motor steps / degree of dome movement";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabEncoder
            // 
            this.tabEncoder.BackColor = System.Drawing.Color.Goldenrod;
            this.tabEncoder.Controls.Add(this.label20);
            this.tabEncoder.Controls.Add(this.label17);
            this.tabEncoder.Controls.Add(this.numericUpDownEncoderRevsPerDomeRev);
            this.tabEncoder.Controls.Add(this.label16);
            this.tabEncoder.Controls.Add(this.label15);
            this.tabEncoder.Controls.Add(this.numericUpDownTicksPerDomeRev);
            this.tabEncoder.Controls.Add(this.label14);
            this.tabEncoder.Controls.Add(this.label13);
            this.tabEncoder.Controls.Add(this.numericUpDownEncoderTicks);
            this.tabEncoder.Controls.Add(this.label12);
            this.tabEncoder.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEncoder.Location = new System.Drawing.Point(4, 34);
            this.tabEncoder.Name = "tabEncoder";
            this.tabEncoder.Size = new System.Drawing.Size(517, 496);
            this.tabEncoder.TabIndex = 2;
            this.tabEncoder.Text = "Encoder";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(227, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 16);
            this.label17.TabIndex = 53;
            this.label17.Text = "per dome revolution";
            // 
            // numericUpDownEncoderRevsPerDomeRev
            // 
            this.numericUpDownEncoderRevsPerDomeRev.DecimalPlaces = 2;
            this.numericUpDownEncoderRevsPerDomeRev.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEncoderRevsPerDomeRev.Location = new System.Drawing.Point(143, 196);
            this.numericUpDownEncoderRevsPerDomeRev.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownEncoderRevsPerDomeRev.Name = "numericUpDownEncoderRevsPerDomeRev";
            this.numericUpDownEncoderRevsPerDomeRev.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownEncoderRevsPerDomeRev.TabIndex = 52;
            this.numericUpDownEncoderRevsPerDomeRev.Value = new decimal(new int[] {
            345,
            0,
            0,
            65536});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 16);
            this.label16.TabIndex = 51;
            this.label16.Text = "Shaft revolutions";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(227, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 16);
            this.label15.TabIndex = 50;
            this.label15.Text = "per dome revolution";
            // 
            // numericUpDownTicksPerDomeRev
            // 
            this.numericUpDownTicksPerDomeRev.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTicksPerDomeRev.Location = new System.Drawing.Point(143, 147);
            this.numericUpDownTicksPerDomeRev.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDownTicksPerDomeRev.Name = "numericUpDownTicksPerDomeRev";
            this.numericUpDownTicksPerDomeRev.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownTicksPerDomeRev.TabIndex = 49;
            this.numericUpDownTicksPerDomeRev.Value = new decimal(new int[] {
            20700,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 16);
            this.label14.TabIndex = 48;
            this.label14.Text = "encoder Ticks =";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(226, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 16);
            this.label13.TabIndex = 47;
            this.label13.Text = "Per shaft revolution";
            // 
            // numericUpDownEncoderTicks
            // 
            this.numericUpDownEncoderTicks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEncoderTicks.Location = new System.Drawing.Point(143, 87);
            this.numericUpDownEncoderTicks.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownEncoderTicks.Name = "numericUpDownEncoderTicks";
            this.numericUpDownEncoderTicks.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownEncoderTicks.TabIndex = 46;
            this.numericUpDownEncoderTicks.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "encoder Ticks =";
            // 
            // rbtnConnect
            // 
            this.rbtnConnect.AutoEllipsis = true;
            this.rbtnConnect.BackColor = System.Drawing.Color.YellowGreen;
            this.rbtnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnConnect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnConnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnConnect.Location = new System.Drawing.Point(341, 21);
            this.rbtnConnect.Name = "rbtnConnect";
            this.rbtnConnect.Size = new System.Drawing.Size(92, 66);
            this.rbtnConnect.TabIndex = 20;
            this.rbtnConnect.Text = "Connect";
            this.rbtnConnect.UseVisualStyleBackColor = false;
            this.rbtnConnect.Click += new System.EventHandler(this.rbtnConnect_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(40, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(220, 16);
            this.label18.TabIndex = 46;
            this.label18.Text = "Load Values below from EEPROM";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(311, 35);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(136, 33);
            this.btnLoad.TabIndex = 47;
            this.btnLoad.Text = "Load fields";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(134, 445);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(190, 16);
            this.label19.TabIndex = 48;
            this.label19.Text = "This form not yet operational";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(140, 400);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(190, 16);
            this.label20.TabIndex = 54;
            this.label20.Text = "This form not yet operational";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabMonitor.ResumeLayout(false);
            this.tabDome.ResumeLayout(false);
            this.tabDome.PerformLayout();
            this.panelHomePark.ResumeLayout(false);
            this.panelHomePark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPark)).EndInit();
            this.tabMotor.ResumeLayout(false);
            this.tabMotor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMotorShaftRevsPerDomeRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownControllerDIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabEncoder.ResumeLayout(false);
            this.tabEncoder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEncoderRevsPerDomeRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicksPerDomeRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEncoderTicks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxStepper;
        private System.Windows.Forms.Label lblControlBox;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblTargetDescription;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lbldegreesToTarget;
        private System.Windows.Forms.Label lbltargetStatus;
        private System.Windows.Forms.Label lblMoving;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Timer tmrControloxRequests;
        private System.Windows.Forms.ToolTip toolTipPK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNCameraSwitch;
        private System.Windows.Forms.Label lblCamerapowerstatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnactivate;
        private System.Windows.Forms.Button btnpowerActivate;
        private System.Windows.Forms.TabControl tabMonitor;
        private System.Windows.Forms.TabPage tabDome;
        private System.Windows.Forms.TabPage tabMotor;
        private System.Windows.Forms.TabPage tabEncoder;
        private System.Windows.Forms.Label lblDomeAzimuth;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Button btnresetControlBox;
        private System.Windows.Forms.Label lbldataTick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsync;
        private RoundButton rbtnConnect;
        private System.Windows.Forms.NumericUpDown numericUpDownHome;
        private System.Windows.Forms.Label lblPark;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.NumericUpDown numericUpDownPark;
        private System.Windows.Forms.Label lblParkValue;
        private System.Windows.Forms.Label lblHomeValue;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelHomePark;
        private System.Windows.Forms.NumericUpDown numericUpDownMotorShaftRevsPerDomeRev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownControllerDIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDownEncoderRevsPerDomeRev;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownTicksPerDomeRev;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownEncoderTicks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

