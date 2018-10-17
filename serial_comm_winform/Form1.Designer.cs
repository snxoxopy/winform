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
            this.SuspendLayout();
            // 
            // LED1
            // 
            this.LED1.Location = new System.Drawing.Point(28, 102);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(103, 40);
            this.LED1.TabIndex = 0;
            this.LED1.Text = "LED1";
            this.LED1.UseVisualStyleBackColor = true;
            this.LED1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LED2
            // 
            this.LED2.Location = new System.Drawing.Point(155, 102);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(103, 40);
            this.LED2.TabIndex = 1;
            this.LED2.Text = "LED2";
            this.LED2.UseVisualStyleBackColor = true;
            this.LED2.Click += new System.EventHandler(this.LED2_Click);
            // 
            // LED3
            // 
            this.LED3.Location = new System.Drawing.Point(286, 102);
            this.LED3.Name = "LED3";
            this.LED3.Size = new System.Drawing.Size(103, 40);
            this.LED3.TabIndex = 2;
            this.LED3.Text = "LED3";
            this.LED3.UseVisualStyleBackColor = true;
            this.LED3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LED4
            // 
            this.LED4.Location = new System.Drawing.Point(416, 102);
            this.LED4.Name = "LED4";
            this.LED4.Size = new System.Drawing.Size(103, 40);
            this.LED4.TabIndex = 3;
            this.LED4.Text = "LED4";
            this.LED4.UseVisualStyleBackColor = true;
            this.LED4.Click += new System.EventHandler(this.LED4_Click);
            // 
            // LED5
            // 
            this.LED5.Location = new System.Drawing.Point(28, 195);
            this.LED5.Name = "LED5";
            this.LED5.Size = new System.Drawing.Size(103, 40);
            this.LED5.TabIndex = 4;
            this.LED5.Text = "LED5";
            this.LED5.UseVisualStyleBackColor = true;
            this.LED5.Click += new System.EventHandler(this.LED5_Click);
            // 
            // LED6
            // 
            this.LED6.Location = new System.Drawing.Point(155, 195);
            this.LED6.Name = "LED6";
            this.LED6.Size = new System.Drawing.Size(103, 40);
            this.LED6.TabIndex = 5;
            this.LED6.Text = "LED6";
            this.LED6.UseVisualStyleBackColor = true;
            this.LED6.Click += new System.EventHandler(this.LED6_Click);
            // 
            // LED7
            // 
            this.LED7.Location = new System.Drawing.Point(286, 195);
            this.LED7.Name = "LED7";
            this.LED7.Size = new System.Drawing.Size(103, 40);
            this.LED7.TabIndex = 6;
            this.LED7.Text = "LED7";
            this.LED7.UseVisualStyleBackColor = true;
            this.LED7.Click += new System.EventHandler(this.LED7_Click);
            // 
            // LED8
            // 
            this.LED8.Location = new System.Drawing.Point(416, 195);
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
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(399, 282);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(119, 59);
            this.Open.TabIndex = 9;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.button9_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(399, 375);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(119, 59);
            this.Close.TabIndex = 10;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 282);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(324, 152);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 460);
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
            this.Text = "r";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

