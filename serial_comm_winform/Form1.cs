using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serial_comm_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chk_close_port();

        }


        private void chk_open_port()
        {
            LED1.Enabled = true;
            LED2.Enabled = true;
            LED3.Enabled = true;
            LED4.Enabled = true;
            LED5.Enabled = true;
            LED6.Enabled = true;
            LED7.Enabled = true;
            LED8.Enabled = true;
        }

        private void chk_close_port()
        {
            LED1.Enabled = false;
            LED2.Enabled = false;
            LED3.Enabled = false;
            LED4.Enabled = false;
            LED5.Enabled = false;
            LED6.Enabled = false;
            LED7.Enabled = false;
            LED8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            richTextBox1.AppendText("Open PORT: ");
            richTextBox1.AppendText(serialPort1.PortName.ToString());
            richTextBox1.AppendText("\n");
            chk_open_port();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            LED1.Enabled = false;
            LED2.Enabled = false;
            LED3.Enabled = false;
            LED4.Enabled = false;
            LED5.Enabled = false;
            LED6.Enabled = false;
            LED7.Enabled = false;
            LED8.Enabled = false;
            richTextBox1.AppendText("---Close PORT---\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("1");
            richTextBox1.AppendText("LED1\n");
            richTextBox1.ScrollToCaret();
        }

        private void LED2_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("2");
            richTextBox1.AppendText("LED2\n");
            richTextBox1.ScrollToCaret();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("3");
            richTextBox1.AppendText("LED3\n");
            richTextBox1.ScrollToCaret();
        }

        private void LED4_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("4");
            richTextBox1.AppendText("LED4\n");
            richTextBox1.ScrollToCaret();
        }

        private void LED5_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("5");
            richTextBox1.AppendText("LED5\n");
            richTextBox1.ScrollToCaret();
        }

        private void LED6_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("6");
            richTextBox1.AppendText("LED6\n");
            richTextBox1.ScrollToCaret();
        }

        private void LED7_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("7");
            richTextBox1.AppendText("LED7\n");
            richTextBox1.ScrollToCaret();
        }

        private void LED8_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("8");
            richTextBox1.AppendText("LED8\n");
            richTextBox1.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
