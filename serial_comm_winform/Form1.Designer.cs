namespace serial_comm_winform
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LED1 = new System.Windows.Forms.Button();
            this.LED2 = new System.Windows.Forms.Button();
            this.LED3 = new System.Windows.Forms.Button();
            this.LED4 = new System.Windows.Forms.Button();
            this.LED5 = new System.Windows.Forms.Button();
            this.LED6 = new System.Windows.Forms.Button();
            this.LED7 = new System.Windows.Forms.Button();
            this.LED8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Open = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmb_Device = new System.Windows.Forms.ComboBox();
            this.cmb_Baudrate = new System.Windows.Forms.ComboBox();
            this.lbl_Device = new System.Windows.Forms.Label();
            this.lbl_Baudrate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bnt_Send = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LED1
            // 
            this.LED1.Location = new System.Drawing.Point(478, 86);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(103, 40);
            this.LED1.TabIndex = 0;
            this.LED1.Text = "LED1";
            this.LED1.UseVisualStyleBackColor = true;
            this.LED1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LED2
            // 
            this.LED2.Location = new System.Drawing.Point(605, 86);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(103, 40);
            this.LED2.TabIndex = 1;
            this.LED2.Text = "LED2";
            this.LED2.UseVisualStyleBackColor = true;
            this.LED2.Click += new System.EventHandler(this.LED2_Click);
            // 
            // LED3
            // 
            this.LED3.Location = new System.Drawing.Point(736, 86);
            this.LED3.Name = "LED3";
            this.LED3.Size = new System.Drawing.Size(103, 40);
            this.LED3.TabIndex = 2;
            this.LED3.Text = "LED3";
            this.LED3.UseVisualStyleBackColor = true;
            this.LED3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LED4
            // 
            this.LED4.Location = new System.Drawing.Point(866, 86);
            this.LED4.Name = "LED4";
            this.LED4.Size = new System.Drawing.Size(103, 40);
            this.LED4.TabIndex = 3;
            this.LED4.Text = "LED4";
            this.LED4.UseVisualStyleBackColor = true;
            this.LED4.Click += new System.EventHandler(this.LED4_Click);
            // 
            // LED5
            // 
            this.LED5.Location = new System.Drawing.Point(478, 179);
            this.LED5.Name = "LED5";
            this.LED5.Size = new System.Drawing.Size(103, 40);
            this.LED5.TabIndex = 4;
            this.LED5.Text = "LED5";
            this.LED5.UseVisualStyleBackColor = true;
            this.LED5.Click += new System.EventHandler(this.LED5_Click);
            // 
            // LED6
            // 
            this.LED6.Location = new System.Drawing.Point(605, 179);
            this.LED6.Name = "LED6";
            this.LED6.Size = new System.Drawing.Size(103, 40);
            this.LED6.TabIndex = 5;
            this.LED6.Text = "LED6";
            this.LED6.UseVisualStyleBackColor = true;
            this.LED6.Click += new System.EventHandler(this.LED6_Click);
            // 
            // LED7
            // 
            this.LED7.Location = new System.Drawing.Point(736, 179);
            this.LED7.Name = "LED7";
            this.LED7.Size = new System.Drawing.Size(103, 40);
            this.LED7.TabIndex = 6;
            this.LED7.Text = "LED7";
            this.LED7.UseVisualStyleBackColor = true;
            this.LED7.Click += new System.EventHandler(this.LED7_Click);
            // 
            // LED8
            // 
            this.LED8.Location = new System.Drawing.Point(866, 179);
            this.LED8.Name = "LED8";
            this.LED8.Size = new System.Drawing.Size(103, 40);
            this.LED8.TabIndex = 7;
            this.LED8.Text = "LED8";
            this.LED8.UseVisualStyleBackColor = true;
            this.LED8.Click += new System.EventHandler(this.LED8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "LED ON OFF";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(225, 178);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(103, 34);
            this.Open.TabIndex = 9;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.button9_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(334, 178);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(103, 34);
            this.Close.TabIndex = 10;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(478, 254);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(491, 176);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // cmb_Device
            // 
            this.cmb_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Device.FormattingEnabled = true;
            this.cmb_Device.Location = new System.Drawing.Point(316, 96);
            this.cmb_Device.Name = "cmb_Device";
            this.cmb_Device.Size = new System.Drawing.Size(121, 23);
            this.cmb_Device.TabIndex = 12;
            // 
            // cmb_Baudrate
            // 
            this.cmb_Baudrate.FormattingEnabled = true;
            this.cmb_Baudrate.Location = new System.Drawing.Point(316, 134);
            this.cmb_Baudrate.Name = "cmb_Baudrate";
            this.cmb_Baudrate.Size = new System.Drawing.Size(121, 23);
            this.cmb_Baudrate.TabIndex = 13;
            // 
            // lbl_Device
            // 
            this.lbl_Device.AutoSize = true;
            this.lbl_Device.Font = new System.Drawing.Font("굴림", 12F);
            this.lbl_Device.Location = new System.Drawing.Point(221, 99);
            this.lbl_Device.Name = "lbl_Device";
            this.lbl_Device.Size = new System.Drawing.Size(68, 20);
            this.lbl_Device.TabIndex = 14;
            this.lbl_Device.Text = "Device";
            // 
            // lbl_Baudrate
            // 
            this.lbl_Baudrate.AutoSize = true;
            this.lbl_Baudrate.Font = new System.Drawing.Font("굴림", 12F);
            this.lbl_Baudrate.Location = new System.Drawing.Point(221, 137);
            this.lbl_Baudrate.Name = "lbl_Baudrate";
            this.lbl_Baudrate.Size = new System.Drawing.Size(83, 20);
            this.lbl_Baudrate.TabIndex = 15;
            this.lbl_Baudrate.Text = "Baudrate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 25);
            this.textBox1.TabIndex = 16;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // bnt_Send
            // 
            this.bnt_Send.Location = new System.Drawing.Point(362, 254);
            this.bnt_Send.Name = "bnt_Send";
            this.bnt_Send.Size = new System.Drawing.Size(75, 25);
            this.bnt_Send.TabIndex = 17;
            this.bnt_Send.Text = "Send";
            this.bnt_Send.UseVisualStyleBackColor = true;
            this.bnt_Send.Click += new System.EventHandler(this.bnt_Send_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 126);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bnt_Send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Baudrate);
            this.Controls.Add(this.lbl_Device);
            this.Controls.Add(this.cmb_Baudrate);
            this.Controls.Add(this.cmb_Device);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LED8);
            this.Controls.Add(this.LED7);
            this.Controls.Add(this.LED6);
            this.Controls.Add(this.LED5);
            this.Controls.Add(this.LED4);
            this.Controls.Add(this.LED3);
            this.Controls.Add(this.LED2);
            this.Controls.Add(this.LED1);
            this.Name = "Form1";
            this.Text = "Comport_Master_USZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LED1;
        private System.Windows.Forms.Button LED2;
        private System.Windows.Forms.Button LED3;
        private System.Windows.Forms.Button LED4;
        private System.Windows.Forms.Button LED5;
        private System.Windows.Forms.Button LED6;
        private System.Windows.Forms.Button LED7;
        private System.Windows.Forms.Button LED8;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cmb_Device;
        private System.Windows.Forms.ComboBox cmb_Baudrate;
        private System.Windows.Forms.Label lbl_Device;
        private System.Windows.Forms.Label lbl_Baudrate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bnt_Send;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

