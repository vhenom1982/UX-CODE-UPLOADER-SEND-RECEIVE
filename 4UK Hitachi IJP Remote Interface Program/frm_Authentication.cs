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
    public partial class frm_Authentication : Form
    {
        public frm_Authentication()
        {
            InitializeComponent();
        }

        private void frm_Authentication_Load(object sender, EventArgs e)
        {
            txt_PASSWORD.Clear();
        }
        private void txt_PASSWORD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (txt_PASSWORD.Text == "soundcheck@" + DateTime.Now.ToString("MMdd"))
                if (txt_PASSWORD.Text == "123")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Password!!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_PASSWORD.Clear();
                    txt_PASSWORD.SelectionStart = 0;
                    txt_PASSWORD.SelectionLength = txt_PASSWORD.Text.Length;
                }
            }
        }

    }
}
