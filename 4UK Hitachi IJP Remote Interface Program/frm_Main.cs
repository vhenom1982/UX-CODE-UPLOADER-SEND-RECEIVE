using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Net.Mail;

using System.Media;

namespace _4UK_Hitachi_IJP_Remote_Interface_Program
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        public cls_4UkLibrary myLIBRARY = new cls_4UkLibrary();
        delegate void setTextCallBack(string text);

        private void invoke_COMONOFF(string text)
        {
            if (this.cmd_GO_ONLINE.InvokeRequired)
            {
                setTextCallBack d = new setTextCallBack(invoke_COMONOFF);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.cmd_GO_ONLINE.Text = text;
            }
        }
        private void invoke_CONNECT(string text)
        {
            if (this.cmd_CONNECT.InvokeRequired)
            {
                setTextCallBack d = new setTextCallBack(invoke_CONNECT);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.cmd_CONNECT.Text = text;
            }
        }

        private void xDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //intIndex = COMMPORT.Read(bytBUFFER, 3, COMMPORT.BytesToRead);

            cls_4UkClass.CAPTUREDDATA = cls_4UkClass.mainCOMM.ReadExisting();

            if (cls_4UkClass.CAPTUREDDATA == myLIBRARY.chACK.ToString())
            {
                invoke_CONNECT("CONNECTED");
            }
        }

        public void SETUP_COMM()
        {
            if (cls_4UkClass.mainCOMM == null)
            {
                cls_4UkClass.mainCOMM = new SerialPort(cls_4UkClass.comPORT, cls_4UkClass.comBAUD, Parity.None, 8, StopBits.One);
            }

            if (cls_4UkClass.mainCOMM.IsOpen == false)
            {
                try
                {
                    cls_4UkClass.mainCOMM.DataReceived += new SerialDataReceivedEventHandler(xDataReceived);
                    cls_4UkClass.mainCOMM.Handshake = Handshake.None;
                    cls_4UkClass.mainCOMM.Open();
                    cls_4UkClass.mainCOMM.DtrEnable = true;
                }

                catch (Exception ERR)
                {
                    MessageBox.Show(ERR.Message, "Notification 022: Technical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                cls_4UkClass.mainCOMM.Close();
                invoke_CONNECT("DISCONNECTED");
            }
        }

        #region SYSTEM SETTINGS
        public SmtpClient smtpMYSERVER;
        #endregion

        #region CONTROLS
        private void frm_Main_Load(object sender, EventArgs e)
        {
            CLEAR_ALL_TEXT();
            cls_4UkClass.LOAD_COM_SETTINGS();
        }
        private void cmd_Close_Click(object sender, EventArgs e)
        {
            DialogResult my_Goodbye = MessageBox.Show("Are you sure you want to quit the program?", "Closing the Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (my_Goodbye == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void cmd_SETCOM_Click(object sender, EventArgs e)
        {
            frm_CONN CommSet = new frm_CONN();
            CommSet.ShowDialog();
        }
        private void cmd_SETEML_Click(object sender, EventArgs e)
        {

        }
        private void cmd_COMSTATUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TRACER_TextChanged(object sender, EventArgs e)
        {
            if (txt_TRACER.Text.Length > 32700)
            {
                txt_TRACER.Clear();
            }
        }
        #endregion

        #region COMMAND
        private void CLEAR_ALL_TEXT()
        {
            txt_ROW1.Clear();
            txt_ROW2.Clear();
            txt_ROW3.Clear();
            txt_ROW4.Clear();
        }


        private void cmd_Send_Click(object sender, EventArgs e)
        {
            if (cmd_CONNECT.Text == "CONNECTED" && cmd_GO_ONLINE.Text == "ONLINE[1]")
            {
                if (cls_4UkClass.mainCOMM != null)
                {
                    if (cls_4UkClass.mainCOMM.IsOpen)
                    {
                        cls_4UkClass.mainCOMM.Write(
                                                        Convert.ToString(myLIBRARY.chSTX) +
                                                                                                Convert.ToString(myLIBRARY.chESC_2) + Convert.ToString((char)0x22) + Convert.ToString((char)0x32) + "4" + "2" +
                                                                                                Convert.ToString(myLIBRARY.chDLE) + Convert.ToString(1) + txt_ROW1.Text +
                                                                                                Convert.ToString(myLIBRARY.chDLE) + Convert.ToString(2) + txt_ROW2.Text +
                                                                                                Convert.ToString(myLIBRARY.chDLE) + Convert.ToString(3) + txt_ROW3.Text +
                                                                                                Convert.ToString(myLIBRARY.chDLE) + Convert.ToString(4) + txt_ROW4.Text +
                                                        Convert.ToString(myLIBRARY.chETX)

                        );
                    }
                }
            }
            else
            {
                MessageBox.Show("Communication Serial Port is not Connected! or The Printer is Offline", "Communication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void cmd_CONNECT_Click(object sender, EventArgs e)
        {
            SETUP_COMM();

            if (cls_4UkClass.mainCOMM.IsOpen)
            {
                cls_4UkClass.mainCOMM.Write(myLIBRARY.chENQ.ToString());
            }
        }

        private void cmd_GO_ONLINE_Click(object sender, EventArgs e)
        {
            if (cmd_CONNECT.Text == "CONNECTED")
            {
                if (cls_4UkClass.mainCOMM != null)
                {
                    if (cls_4UkClass.mainCOMM.IsOpen)
                    {
                        if (cmd_GO_ONLINE.Text == "OFFLINE[0]")
                        {
                            cls_4UkClass.mainCOMM.Write( Convert.ToString(myLIBRARY.chESC_2) + Convert.ToString((char)0x73));
                            cmd_GO_ONLINE.Text = "ONLINE[1]";
                        }
                        else
                        {
                            cls_4UkClass.mainCOMM.Write(Convert.ToString(myLIBRARY.chESC_2) + Convert.ToString((char)0x74));
                            cmd_GO_ONLINE.Text = "OFFLINE[0]";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Communication Serial Port is not Connected!", "Serial Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmd_EJECT_Click(object sender, EventArgs e)
        {
            if (cmd_CONNECT.Text == "CONNECTED" && cmd_GO_ONLINE.Text == "ONLINE[1]")
            {
                if (cls_4UkClass.mainCOMM != null)
                {
                    if (cls_4UkClass.mainCOMM.IsOpen)
                    {
                        cls_4UkClass.mainCOMM.Write(myLIBRARY.chSTX.ToString() + Convert.ToString(myLIBRARY.chESC_2) + Convert.ToString((char)0x72) + Convert.ToString((char)0x30) + myLIBRARY.chETX.ToString());
                    }
                    else
                    {
                        SystemSounds.Beep.Play();
                    }
                }
                else
                {
                    SystemSounds.Beep.Play();
                }
            }
            else
            {
                MessageBox.Show("Communication Serial Port is not Connected! or The Printer is Offline", "Communication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cmd_Stop_Click(object sender, EventArgs e)
        {
            if (cmd_CONNECT.Text == "CONNECTED" && cmd_GO_ONLINE.Text == "ONLINE[1]")
            {
                if (cls_4UkClass.mainCOMM != null)
                {
                    if (cls_4UkClass.mainCOMM.IsOpen)
                    {
                        cls_4UkClass.mainCOMM.Write(myLIBRARY.chSTX.ToString() + Convert.ToString(myLIBRARY.chESC_2) + Convert.ToString((char)0x72) + Convert.ToString((char)0x31) + myLIBRARY.chETX.ToString());
                    }
                    else
                    {
                        SystemSounds.Beep.Play();
                    }
                }
                else
                {
                    SystemSounds.Beep.Play();
                }
            }
            else
            {
                MessageBox.Show("Communication Serial Port is not Connected! or The Printer is Offline", "Communication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cmd_Stadby_Click(object sender, EventArgs e)
        {
            if (cmd_CONNECT.Text == "CONNECTED" && cmd_GO_ONLINE.Text == "ONLINE[1]")
            {
                if (cls_4UkClass.mainCOMM != null)
                {
                    if (cls_4UkClass.mainCOMM.IsOpen)
                    {
                        cls_4UkClass.mainCOMM.Write(myLIBRARY.chSTX.ToString() + Convert.ToString(myLIBRARY.chESC_2) + Convert.ToString((char)0x72) + Convert.ToString((char)0x33) + myLIBRARY.chETX.ToString());
                    }
                    else
                    {
                        SystemSounds.Beep.Play();
                    }
                }
                else
                {
                    SystemSounds.Beep.Play();
                }
            }
            else
            {
                MessageBox.Show("Communication Serial Port is not Connected! or The Printer is Offline", "Communication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cmd_Ready_Click(object sender, EventArgs e)
        {
            if (cmd_CONNECT.Text == "CONNECTED" && cmd_GO_ONLINE.Text == "ONLINE[1]")
            {
                if (cls_4UkClass.mainCOMM != null)
                {
                    if (cls_4UkClass.mainCOMM.IsOpen)
                    {
                        cls_4UkClass.mainCOMM.Write(myLIBRARY.chSTX.ToString() + Convert.ToString(myLIBRARY.chESC_2) + Convert.ToString((char)0x72) + Convert.ToString((char)0x32) + myLIBRARY.chETX.ToString());
                    }
                    else
                    {
                        SystemSounds.Beep.Play();
                    }
                }
                else
                {
                    SystemSounds.Beep.Play();
                }
            }
            else
            {
                MessageBox.Show("Communication Serial Port is not Connected! or The Printer is Offline", "Communication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }















        #region DATA

        #endregion


    }
}
