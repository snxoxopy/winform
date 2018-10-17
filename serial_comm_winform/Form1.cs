using System;
using System.IO.Ports;
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
        string[] baudrates;
        string[] comports;

        public Form1()
        {
            InitializeComponent();
            chk_close_port();
            try
            {
                comports = SerialPort.GetPortNames();
                baudrates = new string[] { "9600", "115200" };
                cmb_Baudrate.Items.AddRange(baudrates);
                cmb_Device.Items.AddRange(comports);
            }
            catch(Exception)
            {

            }
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
            bnt_Send.Enabled = true;
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
            bnt_Send.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try //시도를했는데 예외 상황이 발생하면 catch 실행
            {
                //cmb상태 반영
                serialPort1.PortName = cmb_Device.SelectedItem.ToString();               
                //int.Parse 문자형을 정수형으로 바꿔주는 메서드
                serialPort1.BaudRate = int.Parse(cmb_Baudrate.SelectedItem.ToString());
                chk_open_port();
                serialPort1.Open();

                richTextBox1.AppendText("Open PORT: ");
                richTextBox1.AppendText(serialPort1.PortName.ToString());
                richTextBox1.AppendText("\n");
                richTextBox1.ScrollToCaret();
            }
            catch(Exception) //exception 모든 예외 상황
            {
                richTextBox1.AppendText("COM 설정과 baudrate 설정을 해주세요.\n");
                richTextBox1.ScrollToCaret();
            }
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                chk_close_port();
                richTextBox1.AppendText("---Close PORT---\n");
                richTextBox1.ScrollToCaret();
            }
            catch(Exception)
            {
                richTextBox1.AppendText("닫을 수 없음\n");
                richTextBox1.ScrollToCaret();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            try
            {
                serialPort1.WriteLine("1");
                richTextBox1.AppendText("LED1\n");
                richTextBox1.ScrollToCaret();
            }
            catch(System.InvalidOperationException)
            {
                richTextBox1.AppendText("!LED1 포트 연결 확인!\n");
                richTextBox1.ScrollToCaret();
            }
        }

        private void LED2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("2");
                richTextBox1.AppendText("LED2\n");
                richTextBox1.ScrollToCaret();
            }
            catch(Exception)
            {
                richTextBox1.AppendText("!LED2 포트 연결 확인!\n");
                richTextBox1.ScrollToCaret();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("3");
                richTextBox1.AppendText("LED3\n");
                richTextBox1.ScrollToCaret();
            }
            catch(Exception)
            {
                richTextBox1.AppendText("!LED3 포트 연결 확인!\n");
                richTextBox1.ScrollToCaret();
            }
            
        }

        private void LED4_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("4");
                richTextBox1.AppendText("LED4\n");
                richTextBox1.ScrollToCaret();
            }
            catch(Exception)
            {
                richTextBox1.AppendText("!LED4 포트 연결 확인!\n");
                richTextBox1.ScrollToCaret();
            }
            
        }

        private void LED5_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("5");
                richTextBox1.AppendText("LED5\n");
                richTextBox1.ScrollToCaret();
            }
            catch(Exception)
            {
                richTextBox1.AppendText("!LED5 포트 연결 확인!\n");
                richTextBox1.ScrollToCaret();
            }
            
        }

        private void LED6_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("6");
                richTextBox1.AppendText("LED6\n");
                richTextBox1.ScrollToCaret();
            }
            catch(Exception)
            {
                richTextBox1.AppendText("!LED6 포트 연결 확인!\n");
                richTextBox1.ScrollToCaret();
            }
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
           // richTextBox1.AppendText(Console.ReadLine());
        }

        private void bnt_Send_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine(textBox1.Text);
                richTextBox1.AppendText("#LED ");
                richTextBox1.AppendText(textBox1.Text);
                richTextBox1.AppendText("\n");
                richTextBox1.ScrollToCaret();
            }
            catch(Exception)
            {
                richTextBox1.AppendText("chk textbox\n");
                richTextBox1.ScrollToCaret();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //e는 이벤트가 발생했을때 값을 갖고있음
                if (e.KeyChar == '\r')
                {
                    serialPort1.WriteLine(textBox1.Text);
                    richTextBox1.AppendText(textBox1.Text);
                    richTextBox1.AppendText("\n");
                    richTextBox1.ScrollToCaret();
                }
            }
            catch
            {
                richTextBox1.AppendText("확인해주세요~~~\n");
                richTextBox1.ScrollToCaret();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {           
            string readData;
            readData = serialPort1.ReadLine();

            try
            {
                //data 입력이되면 실행됨
                richTextBox1.AppendText("Data from AVR: ");
                richTextBox1.AppendText(readData);
                richTextBox1.AppendText("\n");
                richTextBox1.ScrollToCaret();
            }
            catch(Exception)
            {

            }
        }
    }
}
