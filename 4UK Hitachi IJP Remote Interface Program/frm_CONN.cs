using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4UK_Hitachi_IJP_Remote_Interface_Program
{
    public partial class frm_CONN : Form
    {
        cls_4UkLibrary HITACHILIB = new cls_4UkLibrary();
        cls_4UkClass HITACHICLASS = new cls_4UkClass();

        public void LOAD_COMM_DATA()
        {
            cls_4UkClass.LOAD_COM_SETTINGS();
            txt_PORT.Text = cls_4UkClass.comPORT;
            txt_BAUD.Text = cls_4UkClass.comBAUD.ToString();
        }

        //---------------------------------------------------------------------------------------------------------------------------

        public frm_CONN()
        {
            InitializeComponent();
        }

        private void frm_COM_Load(object sender, EventArgs e)
        {
            LOAD_COMM_DATA();
        }
        private void cmd_Apply_Click(object sender, EventArgs e)
        {
            cls_4UkClass.comPORT = txt_PORT.Text;
            cls_4UkClass.comBAUD = int.Parse(txt_BAUD.Text);
            cls_4UkClass.SAVE_COM_SETTINGS();

            LOAD_COMM_DATA();

            this.Close();
        }
        private void cmd_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setupCONN()
        {
            cmd_Apply.Text = "CONNECT";
            cmd_Close.Text = "CLOSE";

            txt_PORT.Clear();
            txt_BAUD.Clear();
        }
        private void fill_BAUDRATE()
        {

        }
    }
}
