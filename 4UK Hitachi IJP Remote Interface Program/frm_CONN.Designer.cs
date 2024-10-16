namespace _4UK_Hitachi_IJP_Remote_Interface_Program
{
    partial class frm_CONN
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
            this.cmd_Close = new System.Windows.Forms.Button();
            this.cmd_Apply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PORT = new System.Windows.Forms.TextBox();
            this.txt_BAUD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baud Rate";
            // 
            // cmd_Close
            // 
            this.cmd_Close.Location = new System.Drawing.Point(321, 115);
            this.cmd_Close.Name = "cmd_Close";
            this.cmd_Close.Size = new System.Drawing.Size(97, 23);
            this.cmd_Close.TabIndex = 4;
            this.cmd_Close.Text = "Close";
            this.cmd_Close.UseVisualStyleBackColor = true;
            this.cmd_Close.Click += new System.EventHandler(this.cmd_Close_Click);
            // 
            // cmd_Apply
            // 
            this.cmd_Apply.Location = new System.Drawing.Point(188, 115);
            this.cmd_Apply.Name = "cmd_Apply";
            this.cmd_Apply.Size = new System.Drawing.Size(97, 23);
            this.cmd_Apply.TabIndex = 5;
            this.cmd_Apply.Text = "Appy";
            this.cmd_Apply.UseVisualStyleBackColor = true;
            this.cmd_Apply.Click += new System.EventHandler(this.cmd_Apply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port Number:";
            // 
            // txt_PORT
            // 
            this.txt_PORT.Location = new System.Drawing.Point(188, 29);
            this.txt_PORT.Name = "txt_PORT";
            this.txt_PORT.Size = new System.Drawing.Size(230, 20);
            this.txt_PORT.TabIndex = 8;
            // 
            // txt_BAUD
            // 
            this.txt_BAUD.Location = new System.Drawing.Point(188, 54);
            this.txt_BAUD.Name = "txt_BAUD";
            this.txt_BAUD.Size = new System.Drawing.Size(230, 20);
            this.txt_BAUD.TabIndex = 9;
            // 
            // frm_CONN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(430, 152);
            this.Controls.Add(this.txt_BAUD);
            this.Controls.Add(this.txt_PORT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmd_Apply);
            this.Controls.Add(this.cmd_Close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CONN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_COM";
            this.Load += new System.EventHandler(this.frm_COM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_Close;
        private System.Windows.Forms.Button cmd_Apply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PORT;
        private System.Windows.Forms.TextBox txt_BAUD;
    }
}