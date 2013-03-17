namespace SerialPortTest
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.textCommand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.numPeriod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numDelayKey = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numDelayScreenShot = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numMousePosX = new System.Windows.Forms.NumericUpDown();
            this.numMousePosY = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.textSSDir = new System.Windows.Forms.TextBox();
            this.btnSetSSDir = new System.Windows.Forms.Button();
            this.ssFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Stop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textCurrPosX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textCurrPosY = new System.Windows.Forms.TextBox();
            this.timerCurrPos = new System.Windows.Forms.Timer(this.components);
            this.comboKey1 = new System.Windows.Forms.ComboBox();
            this.comboKey2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayScreenShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMousePosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMousePosY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(155, 11);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(55, 21);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(216, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 21);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "COM";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(101, 11);
            this.numPort.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(43, 19);
            this.numPort.TabIndex = 5;
            // 
            // textCommand
            // 
            this.textCommand.Location = new System.Drawing.Point(129, 69);
            this.textCommand.Name = "textCommand";
            this.textCommand.Size = new System.Drawing.Size(342, 19);
            this.textCommand.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Command:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(477, 67);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(57, 21);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM4";
            // 
            // numPeriod
            // 
            this.numPeriod.Location = new System.Drawing.Point(130, 43);
            this.numPeriod.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numPeriod.Name = "numPeriod";
            this.numPeriod.Size = new System.Drawing.Size(78, 19);
            this.numPeriod.TabIndex = 9;
            this.numPeriod.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Period:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "sec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "sec";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Delay to key:";
            // 
            // numDelayKey
            // 
            this.numDelayKey.Location = new System.Drawing.Point(130, 96);
            this.numDelayKey.Name = "numDelayKey";
            this.numDelayKey.Size = new System.Drawing.Size(78, 19);
            this.numDelayKey.TabIndex = 12;
            this.numDelayKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Key:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "sec";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "Delay to screen shot:";
            // 
            // numDelayScreenShot
            // 
            this.numDelayScreenShot.Location = new System.Drawing.Point(130, 178);
            this.numDelayScreenShot.Name = "numDelayScreenShot";
            this.numDelayScreenShot.Size = new System.Drawing.Size(78, 19);
            this.numDelayScreenShot.TabIndex = 17;
            this.numDelayScreenShot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "Mouse position:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "Y";
            // 
            // numMousePosX
            // 
            this.numMousePosX.Location = new System.Drawing.Point(130, 151);
            this.numMousePosX.Name = "numMousePosX";
            this.numMousePosX.Size = new System.Drawing.Size(63, 19);
            this.numMousePosX.TabIndex = 25;
            // 
            // numMousePosY
            // 
            this.numMousePosY.Location = new System.Drawing.Point(216, 152);
            this.numMousePosY.Name = "numMousePosY";
            this.numMousePosY.Size = new System.Drawing.Size(63, 19);
            this.numMousePosY.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "Screen shot directory:";
            // 
            // textSSDir
            // 
            this.textSSDir.Location = new System.Drawing.Point(130, 208);
            this.textSSDir.Name = "textSSDir";
            this.textSSDir.ReadOnly = true;
            this.textSSDir.Size = new System.Drawing.Size(311, 19);
            this.textSSDir.TabIndex = 27;
            // 
            // btnSetSSDir
            // 
            this.btnSetSSDir.Location = new System.Drawing.Point(446, 207);
            this.btnSetSSDir.Name = "btnSetSSDir";
            this.btnSetSSDir.Size = new System.Drawing.Size(39, 21);
            this.btnSetSSDir.TabIndex = 29;
            this.btnSetSSDir.Text = "...";
            this.btnSetSSDir.UseVisualStyleBackColor = true;
            this.btnSetSSDir.Click += new System.EventHandler(this.btnSetSSDir_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(343, 42);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(70, 21);
            this.Stop.TabIndex = 31;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(267, 42);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 21);
            this.btnStart.TabIndex = 30;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(296, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 32;
            this.label15.Text = "Current position:";
            // 
            // textCurrPosX
            // 
            this.textCurrPosX.Location = new System.Drawing.Point(410, 152);
            this.textCurrPosX.Name = "textCurrPosX";
            this.textCurrPosX.ReadOnly = true;
            this.textCurrPosX.Size = new System.Drawing.Size(50, 19);
            this.textCurrPosX.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(392, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 12);
            this.label16.TabIndex = 34;
            this.label16.Text = "X";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(466, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 12);
            this.label17.TabIndex = 35;
            this.label17.Text = "Y";
            // 
            // textCurrPosY
            // 
            this.textCurrPosY.Location = new System.Drawing.Point(484, 151);
            this.textCurrPosY.Name = "textCurrPosY";
            this.textCurrPosY.ReadOnly = true;
            this.textCurrPosY.Size = new System.Drawing.Size(50, 19);
            this.textCurrPosY.TabIndex = 36;
            // 
            // timerCurrPos
            // 
            this.timerCurrPos.Enabled = true;
            this.timerCurrPos.Tick += new System.EventHandler(this.timerCurrPos_Tick);
            // 
            // comboKey1
            // 
            this.comboKey1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKey1.FormattingEnabled = true;
            this.comboKey1.Items.AddRange(new object[] {
            "Shift",
            "Ctrl",
            "Alt"});
            this.comboKey1.Location = new System.Drawing.Point(132, 123);
            this.comboKey1.Name = "comboKey1";
            this.comboKey1.Size = new System.Drawing.Size(76, 20);
            this.comboKey1.TabIndex = 37;
            // 
            // comboKey2
            // 
            this.comboKey2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKey2.FormattingEnabled = true;
            this.comboKey2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboKey2.Location = new System.Drawing.Point(229, 123);
            this.comboKey2.Name = "comboKey2";
            this.comboKey2.Size = new System.Drawing.Size(50, 20);
            this.comboKey2.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(214, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 12);
            this.label18.TabIndex = 39;
            this.label18.Text = "+";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(296, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(224, 12);
            this.label19.TabIndex = 40;
            this.label19.Text = "Baud:115200, Bits:8, Stopbits:1, Parity:None";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 240);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comboKey2);
            this.Controls.Add(this.comboKey1);
            this.Controls.Add(this.textCurrPosY);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textCurrPosX);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSetSSDir);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textSSDir);
            this.Controls.Add(this.numMousePosY);
            this.Controls.Add(this.numMousePosX);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numDelayScreenShot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numDelayKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPeriod);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCommand);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "PC Auto Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayScreenShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMousePosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMousePosY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.TextBox textCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.NumericUpDown numPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numDelayKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numDelayScreenShot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numMousePosX;
        private System.Windows.Forms.NumericUpDown numMousePosY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textSSDir;
        private System.Windows.Forms.Button btnSetSSDir;
        private System.Windows.Forms.FolderBrowserDialog ssFolderBrowserDialog;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textCurrPosX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textCurrPosY;
        private System.Windows.Forms.Timer timerCurrPos;
        private System.Windows.Forms.ComboBox comboKey1;
        private System.Windows.Forms.ComboBox comboKey2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

