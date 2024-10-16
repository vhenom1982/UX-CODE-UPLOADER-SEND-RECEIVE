namespace _4UK_Hitachi_IJP_Remote_Interface_Program
{
    partial class frm_Authentication
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PASSWORD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the Password and press Enter to Login...";
            // 
            // txt_PASSWORD
            // 
            this.txt_PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PASSWORD.Location = new System.Drawing.Point(39, 40);
            this.txt_PASSWORD.MaxLength = 20;
            this.txt_PASSWORD.Name = "txt_PASSWORD";
            this.txt_PASSWORD.PasswordChar = '*';
            this.txt_PASSWORD.Size = new System.Drawing.Size(286, 26);
            this.txt_PASSWORD.TabIndex = 1;
            this.txt_PASSWORD.Text = "12345678901234567890";
            this.txt_PASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PASSWORD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PASSWORD_KeyDown);
            // 
            // frm_Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(369, 104);
            this.Controls.Add(this.txt_PASSWORD);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Authentication";
            this.Load += new System.EventHandler(this.frm_Authentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PASSWORD;
    }
}