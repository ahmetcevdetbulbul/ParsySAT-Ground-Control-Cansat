namespace ParsySAT_Ground_Control
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
            this.excele_aktar = new System.Windows.Forms.PictureBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.glControl1 = new OpenTK.GLControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl4 = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sEnable = new System.Windows.Forms.Button();
            this.sActivate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.ToExcel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.set_time = new System.Windows.Forms.Button();
            this.On_telemetry = new System.Windows.Forms.Button();
            this.sim_TextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.calib_altitude = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.sim_mode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.off_telemetry = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.simDisable = new System.Windows.Forms.Button();
            this.sim_timer = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.excele_aktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // excele_aktar
            // 
            this.excele_aktar.Image = global::ParsySAT_Ground_Control.Properties.Resources.parsy_logo;
            this.excele_aktar.Location = new System.Drawing.Point(12, 12);
            this.excele_aktar.Name = "excele_aktar";
            this.excele_aktar.Size = new System.Drawing.Size(746, 274);
            this.excele_aktar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.excele_aktar.TabIndex = 1;
            this.excele_aktar.TabStop = false;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl1.Location = new System.Drawing.Point(678, 92);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(356, 335);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(1466, 26);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(408, 344);
            this.glControl1.TabIndex = 8;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(1042, 91);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(356, 335);
            this.zedGraphControl2.TabIndex = 9;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Location = new System.Drawing.Point(678, 480);
            this.zedGraphControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(356, 335);
            this.zedGraphControl3.TabIndex = 10;
            this.zedGraphControl3.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl4
            // 
            this.zedGraphControl4.Location = new System.Drawing.Point(1042, 480);
            this.zedGraphControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl4.Name = "zedGraphControl4";
            this.zedGraphControl4.ScrollGrace = 0D;
            this.zedGraphControl4.ScrollMaxX = 0D;
            this.zedGraphControl4.ScrollMaxY = 0D;
            this.zedGraphControl4.ScrollMaxY2 = 0D;
            this.zedGraphControl4.ScrollMinX = 0D;
            this.zedGraphControl4.ScrollMinY = 0D;
            this.zedGraphControl4.ScrollMinY2 = 0D;
            this.zedGraphControl4.Size = new System.Drawing.Size(356, 335);
            this.zedGraphControl4.TabIndex = 11;
            this.zedGraphControl4.UseExtendedPrintDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Altitude (m) - Time (s) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1049, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pressure(kPa) - Time (s) ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temperature (°C) - Time (s) ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1039, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Voltage - Time (s) ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 831);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1878, 159);
            this.dataGridView1.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1722, 377);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(46, 22);
            this.textBox10.TabIndex = 66;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1618, 377);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(46, 22);
            this.textBox9.TabIndex = 65;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1508, 378);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(46, 22);
            this.textBox8.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1682, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 16);
            this.label14.TabIndex = 63;
            this.label14.Text = "Roll:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1573, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 62;
            this.label13.Text = "Pitch:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1466, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "Yaw:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(1418, 430);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 200;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(456, 394);
            this.map.TabIndex = 68;
            this.map.Zoom = 0D;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1415, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "GPS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(310, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 25);
            this.label17.TabIndex = 70;
            this.label17.Text = "label17";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1463, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 16);
            this.label8.TabIndex = 71;
            this.label8.Text = "Satellite Status (Yaw,Pitch,Roll)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 72;
            this.label9.Text = "Team Id : 1077";
            // 
            // sEnable
            // 
            this.sEnable.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sEnable.Location = new System.Drawing.Point(42, 451);
            this.sEnable.Name = "sEnable";
            this.sEnable.Size = new System.Drawing.Size(144, 49);
            this.sEnable.TabIndex = 73;
            this.sEnable.Text = "Simulation Enable";
            this.sEnable.UseVisualStyleBackColor = false;
            this.sEnable.Click += new System.EventHandler(this.sEnable_Click);
            // 
            // sActivate
            // 
            this.sActivate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sActivate.Location = new System.Drawing.Point(42, 521);
            this.sActivate.Name = "sActivate";
            this.sActivate.Size = new System.Drawing.Size(144, 49);
            this.sActivate.TabIndex = 74;
            this.sActivate.Text = "Simulation Activate";
            this.sActivate.UseVisualStyleBackColor = false;
            this.sActivate.Click += new System.EventHandler(this.sActivate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 75;
            this.label10.Text = "PORT:";
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(167, 318);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(121, 24);
            this.cboPort.TabIndex = 76;
            // 
            // ToExcel
            // 
            this.ToExcel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ToExcel.Location = new System.Drawing.Point(174, 783);
            this.ToExcel.Name = "ToExcel";
            this.ToExcel.Size = new System.Drawing.Size(144, 42);
            this.ToExcel.TabIndex = 77;
            this.ToExcel.Text = "Export to Excel";
            this.ToExcel.UseVisualStyleBackColor = false;
            this.ToExcel.Click += new System.EventHandler(this.ToExcel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 799);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 25);
            this.label11.TabIndex = 78;
            this.label11.Text = "Telemetry Data :";
            // 
            // set_time
            // 
            this.set_time.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.set_time.Location = new System.Drawing.Point(495, 521);
            this.set_time.Name = "set_time";
            this.set_time.Size = new System.Drawing.Size(144, 49);
            this.set_time.TabIndex = 79;
            this.set_time.Text = "Set Time";
            this.set_time.UseVisualStyleBackColor = false;
            this.set_time.Click += new System.EventHandler(this.set_time_Click);
            // 
            // On_telemetry
            // 
            this.On_telemetry.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.On_telemetry.Location = new System.Drawing.Point(315, 305);
            this.On_telemetry.Name = "On_telemetry";
            this.On_telemetry.Size = new System.Drawing.Size(144, 49);
            this.On_telemetry.TabIndex = 80;
            this.On_telemetry.Text = "ON";
            this.On_telemetry.UseVisualStyleBackColor = false;
            this.On_telemetry.Click += new System.EventHandler(this.On_telemetry_Click);
            // 
            // sim_TextBox
            // 
            this.sim_TextBox.Location = new System.Drawing.Point(42, 591);
            this.sim_TextBox.Multiline = true;
            this.sim_TextBox.Name = "sim_TextBox";
            this.sim_TextBox.ReadOnly = true;
            this.sim_TextBox.Size = new System.Drawing.Size(144, 49);
            this.sim_TextBox.TabIndex = 83;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(201, 468);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 84;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(201, 538);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 85;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // calib_altitude
            // 
            this.calib_altitude.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.calib_altitude.Location = new System.Drawing.Point(301, 521);
            this.calib_altitude.Name = "calib_altitude";
            this.calib_altitude.Size = new System.Drawing.Size(144, 49);
            this.calib_altitude.TabIndex = 86;
            this.calib_altitude.Text = "Separation";
            this.calib_altitude.UseVisualStyleBackColor = false;
            this.calib_altitude.Click += new System.EventHandler(this.calib_altitude_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(201, 614);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 87;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // sim_mode
            // 
            this.sim_mode.AutoSize = true;
            this.sim_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sim_mode.Location = new System.Drawing.Point(37, 423);
            this.sim_mode.Name = "sim_mode";
            this.sim_mode.Size = new System.Drawing.Size(158, 25);
            this.sim_mode.TabIndex = 88;
            this.sim_mode.Text = "Simulation Mode";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(495, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 49);
            this.button1.TabIndex = 89;
            this.button1.Text = "Calibrate Altitude";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // off_telemetry
            // 
            this.off_telemetry.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.off_telemetry.Location = new System.Drawing.Point(495, 305);
            this.off_telemetry.Name = "off_telemetry";
            this.off_telemetry.Size = new System.Drawing.Size(144, 49);
            this.off_telemetry.TabIndex = 82;
            this.off_telemetry.Text = "OFF";
            this.off_telemetry.UseVisualStyleBackColor = false;
            this.off_telemetry.Click += new System.EventHandler(this.off_telemetry_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(37, 360);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 25);
            this.label15.TabIndex = 91;
            this.label15.Text = "Baud Rate:";
            // 
            // baudRate
            // 
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Items.AddRange(new object[] {
            "110 ",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudRate.Location = new System.Drawing.Point(167, 361);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(121, 24);
            this.baudRate.TabIndex = 92;
            // 
            // simDisable
            // 
            this.simDisable.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.simDisable.Location = new System.Drawing.Point(301, 451);
            this.simDisable.Name = "simDisable";
            this.simDisable.Size = new System.Drawing.Size(144, 49);
            this.simDisable.TabIndex = 93;
            this.simDisable.Text = "Simulation Disable";
            this.simDisable.UseVisualStyleBackColor = false;
            this.simDisable.Click += new System.EventHandler(this.simDisable_Click);
            // 
            // sim_timer
            // 
            this.sim_timer.Tick += new System.EventHandler(this.sim_timer_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(351, 610);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(288, 205);
            this.richTextBox1.TabIndex = 94;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 95;
            this.label5.Text = "Simulation Data";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 97;
            this.label6.Text = "Packet Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1002);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.simDisable);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sim_mode);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.calib_altitude);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sim_TextBox);
            this.Controls.Add(this.off_telemetry);
            this.Controls.Add(this.On_telemetry);
            this.Controls.Add(this.set_time);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ToExcel);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sActivate);
            this.Controls.Add(this.sEnable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.map);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraphControl4);
            this.Controls.Add(this.zedGraphControl3);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.excele_aktar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ParsySAT Ground Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.excele_aktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox excele_aktar;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private OpenTK.GLControl glControl1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private ZedGraph.ZedGraphControl zedGraphControl4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sEnable;
        private System.Windows.Forms.Button sActivate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button ToExcel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button set_time;
        private System.Windows.Forms.Button On_telemetry;
        private System.Windows.Forms.TextBox sim_TextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button calib_altitude;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label sim_mode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button off_telemetry;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.Button simDisable;
        private System.Windows.Forms.Timer sim_timer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}

