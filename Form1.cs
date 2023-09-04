using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace _01Basic
{
    public partial class winform : Form
    {
        private SerialPort seiralPort = new SerialPort();

        public winform()
        {
            InitializeComponent();

            if (SerialPort.GetPortNames().Length > 0)
            {
                foreach (string portnumber in SerialPort.GetPortNames())
                {
                    PortNumber.Items.Add(portnumber);
                }
                PortNumber.SelectedIndex = 0;
            }
            else
            {
                this.PortNumber.Items.AddRange(new object[] { "COM1", "COM2" });
                PortNumber.SelectedIndex = 0;
            }
        }



        private void PortNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            Console.Write("Selected Idx : " + cb.SelectedIndex);
            Console.WriteLine(" Selected Value : " + cb.Items[cb.SelectedIndex]);
            this.textArea.AppendText("Selected Idx : " + cb.SelectedIndex + "\r\n" + "Selected Value : " + cb.Items[cb.SelectedIndex] + "\r\n");
        }

        private ManualResetEvent dataReceivedEvent = new ManualResetEvent(true);

        private void SerialPort_DataRecived(object sender, SerialDataReceivedEventArgs e)
        {
            //충돌 방지 안돼
            //dataReceivedEvent.Reset(); // Reset the event to block
            String recvData = this.seiralPort.ReadLine();
            //dataReceivedEvent.Set(); // Set the event to unblock

            //스레드 생성 코드
            //Invoke(new Action(() => {}));
            /* LED 점등 유무 확인 스레드 */
            if (recvData.StartsWith("LED :")) 
            { 
                Invoke(new Action(() => { Console.WriteLine(recvData); this.textArea.AppendText(recvData + "\r\n"); }));
            }
            /* 온도 센서 확인 스레드 */
            if (recvData.StartsWith("TEMP :")) 
            {
                Invoke(new Action(() => { this.TEMP_BOX.Text = "";  this.TEMP_BOX.Text = recvData.Replace("TEMP :", "") + " °C"; }));
                //"°C" 기호 아두이노로 불러오면 ???떠서 스튜디오 코드에서 받는걸로 수정

            }
            /* 조도 센서 확인 스레드 */
            if (recvData.StartsWith("SUN :"))
            {
                Invoke(new Action(() => { this.SUN_BOX.Text = ""; this.SUN_BOX.Text = recvData.Replace("SUN :", ""); }));
            }
            /* 초음파 센서 확인 스레드 */
            if (recvData.StartsWith("DIS :"))
            {
                Invoke(new Action(() => { this.DIS_BOX.Text = ""; this.DIS_BOX.Text = recvData.Replace("DIS :", ""); }));
            }
        }

        private void conn_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Conn_btn click : " + this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString());
            this.textArea.AppendText("Conn_btn click : " + this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString() + "\r\n");
            try
            {
                this.seiralPort.PortName = this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString();
                this.seiralPort.BaudRate = 9600;
                this.seiralPort.DataBits = 8;
                this.seiralPort.StopBits = System.IO.Ports.StopBits.One;
                this.seiralPort.Parity = System.IO.Ports.Parity.None;
                this.seiralPort.Open();
                Console.WriteLine(this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString() + " CONNECTION SUCCESS");
                this.textArea.AppendText("Connected!" + "\r\n");
                this.seiralPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataRecived);
            } catch(Exception ex) {
                Console.WriteLine(this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString() + " CONNECTION FAIL");
                this.seiralPort.Close();
                this.textArea.AppendText("Fail..." + ex + "\r\n");
            }
        }

        private void led01On_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED01_ON Clicked!");
            if (seiralPort.IsOpen)
            {
                seiralPort.Write("1");
                this.textArea.AppendText("LED01_ON SUCCESS" + "\r\n");
            }
            else 
            {
                Console.WriteLine("포트가 열리지 않았습니다.");
                this.textArea.AppendText("LED01_ON FAIL" + "\r\n");
                this.textArea.AppendText("포트가 열리지 않았습니다." + "\r\n");
            }
        }

        private void led01Off_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED01_OFF Clicked!");
            if (seiralPort.IsOpen)
            {
                seiralPort.Write("0");
                this.textArea.AppendText("LED01_OFF SUCCESS" + "\r\n");
            }
            else
            {
                Console.WriteLine("포트가 열리지 않았습니다.");
                this.textArea.AppendText("LED01_OFF FAIL" + "\r\n");
                this.textArea.AppendText("포트가 열리지 않았습니다." + "\r\n");
            }
        }

        private void Dis_conn_btn_Click(object sender, EventArgs e)
        {
            //연결이 되어있는 경우에만 작동
            //가끔가다 연결 해제시 String recvData = this.seiralPort.ReadLine(); 이 부분과 충돌남 =>seiralPort.ReadLine의 스레드가 끝나지 않았는데 Close 시켜버리니 뜨는거 같음 Close시엔 I/O가 모두 끝나있는 상태여야함
            //그럼 모든 스레드가 끝날때 까지 기다려주는 코드가 필요한가?  => 스택오버플로우 보니 this.seiralPort.DataReceived -= SerialPort_DataRecived; 로 닫아주라고 함(똑같았음)
            //SerialPort_DataRecived에 충돌 방지 코드 추가
            if (this.seiralPort.IsOpen) 
            {
                try
                {
                    //this.seiralPort.DataReceived -= new SerialDataReceivedEventHandler(SerialPort_DataRecived);
                    //DataReceived handler가 완료 될때까지 기다리기
                    //되는건가? 원래도 오락가락 하다가 갑자기 오류 떠서 솔직히 모르겠다 아닌듯?
                    //dataReceivedEvent.WaitOne();
                    this.seiralPort.Close();
                    Console.WriteLine("DISCONNECTION SUCCESS");
                    this.textArea.AppendText("Disconnected!" + "\r\n");
                    this.TEMP_BOX.Clear();
                    this.SUN_BOX.Clear();
                    this.DIS_BOX.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("DISCONNECTION FAIL");
                    this.textArea.AppendText("Disconnection fail..." + ex + "\r\n");
                }
            } else
            {
                Console.WriteLine("시리얼포트에 연결되어 있지 않습니다.");
                this.textArea.AppendText("시리얼포트에 연결되어 있지 않습니다." + "\r\n");
            }
        }

        private void textArea_Remove_Click(object sender, EventArgs e)
        {
            this.textArea.Clear();
        }
    }
}
