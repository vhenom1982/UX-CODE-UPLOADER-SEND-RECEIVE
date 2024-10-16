namespace _4UK_Hitachi_IJP_Remote_Interface_Program
{
    partial class frm_Main
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
            this.grp_ONE = new System.Windows.Forms.GroupBox();
            this.txt_ROW4 = new System.Windows.Forms.TextBox();
            this.txt_ROW3 = new System.Windows.Forms.TextBox();
            this.txt_ROW2 = new System.Windows.Forms.TextBox();
            this.txt_ROW1 = new System.Windows.Forms.TextBox();
            this.cmd_Send = new System.Windows.Forms.Button();
            this.cmd_Close = new System.Windows.Forms.Button();
            this.cmd_SETCOM = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_TRACER = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_GO_ONLINE = new System.Windows.Forms.Button();
            this.cmd_CONNECT = new System.Windows.Forms.Button();
            this.cmd_EJECT = new System.Windows.Forms.Button();
            this.cmd_Ready = new System.Windows.Forms.Button();
            this.cmd_Stop = new System.Windows.Forms.Button();
            this.cmd_Stadby = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_ONE.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_ONE
            // 
            this.grp_ONE.Controls.Add(this.txt_ROW4);
            this.grp_ONE.Controls.Add(this.txt_ROW3);
            this.grp_ONE.Controls.Add(this.txt_ROW2);
            this.grp_ONE.Controls.Add(this.txt_ROW1);
            this.grp_ONE.Location = new System.Drawing.Point(16, 87);
            this.grp_ONE.Name = "grp_ONE";
            this.grp_ONE.Size = new System.Drawing.Size(483, 176);
            this.grp_ONE.TabIndex = 0;
            this.grp_ONE.TabStop = false;
            this.grp_ONE.Text = "SENDING MESSAGE:";
            // 
            // txt_ROW4
            // 
            this.txt_ROW4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ROW4.Location = new System.Drawing.Point(6, 130);
            this.txt_ROW4.Name = "txt_ROW4";
            this.txt_ROW4.Size = new System.Drawing.Size(471, 31);
            this.txt_ROW4.TabIndex = 3;
            this.txt_ROW4.Text = "WWWWWWWWWW";
            // 
            // txt_ROW3
            // 
            this.txt_ROW3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ROW3.Location = new System.Drawing.Point(6, 93);
            this.txt_ROW3.Name = "txt_ROW3";
            this.txt_ROW3.Size = new System.Drawing.Size(471, 31);
            this.txt_ROW3.TabIndex = 2;
            this.txt_ROW3.Text = "WWWWWWWWWW";
            // 
            // txt_ROW2
            // 
            this.txt_ROW2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ROW2.Location = new System.Drawing.Point(6, 56);
            this.txt_ROW2.Name = "txt_ROW2";
            this.txt_ROW2.Size = new System.Drawing.Size(471, 31);
            this.txt_ROW2.TabIndex = 1;
            this.txt_ROW2.Text = "WWWWWWWWWW";
            // 
            // txt_ROW1
            // 
            this.txt_ROW1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ROW1.Location = new System.Drawing.Point(6, 19);
            this.txt_ROW1.Name = "txt_ROW1";
            this.txt_ROW1.Size = new System.Drawing.Size(471, 31);
            this.txt_ROW1.TabIndex = 0;
            this.txt_ROW1.Text = "WWWWWWWWWW";
            // 
            // cmd_Send
            // 
            this.cmd_Send.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmd_Send.CausesValidation = false;
            this.cmd_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Send.Location = new System.Drawing.Point(21, 269);
            this.cmd_Send.Name = "cmd_Send";
            this.cmd_Send.Size = new System.Drawing.Size(161, 31);
            this.cmd_Send.TabIndex = 4;
            this.cmd_Send.Text = "SEND to PRINTER";
            this.cmd_Send.UseVisualStyleBackColor = false;
            this.cmd_Send.Click += new System.EventHandler(this.cmd_Send_Click);
            // 
            // cmd_Close
            // 
            this.cmd_Close.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmd_Close.CausesValidation = false;
            this.cmd_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Close.Location = new System.Drawing.Point(581, 284);
            this.cmd_Close.Name = "cmd_Close";
            this.cmd_Close.Size = new System.Drawing.Size(154, 31);
            this.cmd_Close.TabIndex = 8;
            this.cmd_Close.Text = "CLOSE";
            this.cmd_Close.UseVisualStyleBackColor = false;
            this.cmd_Close.Click += new System.EventHandler(this.cmd_Close_Click);
            // 
            // cmd_SETCOM
            // 
            this.cmd_SETCOM.BackColor = System.Drawing.Color.Yellow;
            this.cmd_SETCOM.CausesValidation = false;
            this.cmd_SETCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_SETCOM.Location = new System.Drawing.Point(414, 284);
            this.cmd_SETCOM.Name = "cmd_SETCOM";
            this.cmd_SETCOM.Size = new System.Drawing.Size(161, 31);
            this.cmd_SETCOM.TabIndex = 6;
            this.cmd_SETCOM.Text = "SET COMM. PORT";
            this.cmd_SETCOM.UseVisualStyleBackColor = false;
            this.cmd_SETCOM.Click += new System.EventHandler(this.cmd_SETCOM_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(631, 24);
            this.label13.TabIndex = 30;
            this.label13.Text = "RAINE-RENA REMOTE INTERFACE PROGRAM FOR HITACHI IJP";
            // 
            // txt_TRACER
            // 
            this.txt_TRACER.BackColor = System.Drawing.Color.Black;
            this.txt_TRACER.Enabled = false;
            this.txt_TRACER.ForeColor = System.Drawing.Color.White;
            this.txt_TRACER.Location = new System.Drawing.Point(796, 10);
            this.txt_TRACER.Multiline = true;
            this.txt_TRACER.Name = "txt_TRACER";
            this.txt_TRACER.Size = new System.Drawing.Size(241, 372);
            this.txt_TRACER.TabIndex = 34;
            this.txt_TRACER.TextChanged += new System.EventHandler(this.txt_TRACER_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(470, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(268, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Demonstration Program Developed by: Edgar R. Rubas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(616, 356);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "edgar.rubas@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "COM:";
            // 
            // cmd_GO_ONLINE
            // 
            this.cmd_GO_ONLINE.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmd_GO_ONLINE.CausesValidation = false;
            this.cmd_GO_ONLINE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_GO_ONLINE.Location = new System.Drawing.Point(574, 87);
            this.cmd_GO_ONLINE.Name = "cmd_GO_ONLINE";
            this.cmd_GO_ONLINE.Size = new System.Drawing.Size(162, 34);
            this.cmd_GO_ONLINE.TabIndex = 40;
            this.cmd_GO_ONLINE.Text = "OFFLINE [0]";
            this.cmd_GO_ONLINE.UseVisualStyleBackColor = false;
            this.cmd_GO_ONLINE.Click += new System.EventHandler(this.cmd_GO_ONLINE_Click);
            // 
            // cmd_CONNECT
            // 
            this.cmd_CONNECT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmd_CONNECT.CausesValidation = false;
            this.cmd_CONNECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_CONNECT.Location = new System.Drawing.Point(581, 247);
            this.cmd_CONNECT.Name = "cmd_CONNECT";
            this.cmd_CONNECT.Size = new System.Drawing.Size(154, 31);
            this.cmd_CONNECT.TabIndex = 41;
            this.cmd_CONNECT.Text = "DISCONNECTED";
            this.cmd_CONNECT.UseVisualStyleBackColor = false;
            this.cmd_CONNECT.Click += new System.EventHandler(this.cmd_CONNECT_Click);
            // 
            // cmd_EJECT
            // 
            this.cmd_EJECT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmd_EJECT.CausesValidation = false;
            this.cmd_EJECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_EJECT.ForeColor = System.Drawing.Color.White;
            this.cmd_EJECT.Location = new System.Drawing.Point(581, 127);
            this.cmd_EJECT.Name = "cmd_EJECT";
            this.cmd_EJECT.Size = new System.Drawing.Size(74, 31);
            this.cmd_EJECT.TabIndex = 42;
            this.cmd_EJECT.Text = "Eject Ink";
            this.cmd_EJECT.UseVisualStyleBackColor = false;
            this.cmd_EJECT.Click += new System.EventHandler(this.cmd_EJECT_Click);
            // 
            // cmd_Ready
            // 
            this.cmd_Ready.BackColor = System.Drawing.Color.Blue;
            this.cmd_Ready.CausesValidation = false;
            this.cmd_Ready.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Ready.ForeColor = System.Drawing.Color.White;
            this.cmd_Ready.Location = new System.Drawing.Point(661, 164);
            this.cmd_Ready.Name = "cmd_Ready";
            this.cmd_Ready.Size = new System.Drawing.Size(74, 31);
            this.cmd_Ready.TabIndex = 43;
            this.cmd_Ready.Text = "Ready";
            this.cmd_Ready.UseVisualStyleBackColor = false;
            this.cmd_Ready.Click += new System.EventHandler(this.cmd_Ready_Click);
            // 
            // cmd_Stop
            // 
            this.cmd_Stop.BackColor = System.Drawing.Color.Red;
            this.cmd_Stop.CausesValidation = false;
            this.cmd_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Stop.ForeColor = System.Drawing.Color.White;
            this.cmd_Stop.Location = new System.Drawing.Point(661, 127);
            this.cmd_Stop.Name = "cmd_Stop";
            this.cmd_Stop.Size = new System.Drawing.Size(74, 31);
            this.cmd_Stop.TabIndex = 44;
            this.cmd_Stop.Text = "Stop";
            this.cmd_Stop.UseVisualStyleBackColor = false;
            this.cmd_Stop.Click += new System.EventHandler(this.cmd_Stop_Click);
            // 
            // cmd_Stadby
            // 
            this.cmd_Stadby.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmd_Stadby.CausesValidation = false;
            this.cmd_Stadby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Stadby.Location = new System.Drawing.Point(581, 164);
            this.cmd_Stadby.Name = "cmd_Stadby";
            this.cmd_Stadby.Size = new System.Drawing.Size(74, 31);
            this.cmd_Stadby.TabIndex = 45;
            this.cmd_Stadby.Text = "Standby";
            this.cmd_Stadby.UseVisualStyleBackColor = false;
            this.cmd_Stadby.Click += new System.EventHandler(this.cmd_Stadby_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "(Demo Program)";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 381);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_Stadby);
            this.Controls.Add(this.cmd_Stop);
            this.Controls.Add(this.cmd_Ready);
            this.Controls.Add(this.cmd_EJECT);
            this.Controls.Add(this.cmd_CONNECT);
            this.Controls.Add(this.cmd_GO_ONLINE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmd_Close);
            this.Controls.Add(this.cmd_Send);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmd_SETCOM);
            this.Controls.Add(this.txt_TRACER);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.grp_ONE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAINE-RENA REMOTE INTERFACE PROGRAM FOR HITACHI IJP (Demo Program)";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.grp_ONE.ResumeLayout(false);
            this.grp_ONE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_ONE;
        private System.Windows.Forms.TextBox txt_ROW4;
        private System.Windows.Forms.TextBox txt_ROW3;
        private System.Windows.Forms.TextBox txt_ROW2;
        private System.Windows.Forms.TextBox txt_ROW1;
        private System.Windows.Forms.Button cmd_Send;
        private System.Windows.Forms.Button cmd_Close;
        private System.Windows.Forms.Button cmd_SETCOM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_TRACER;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_GO_ONLINE;
        private System.Windows.Forms.Button cmd_CONNECT;
        private System.Windows.Forms.Button cmd_EJECT;
        private System.Windows.Forms.Button cmd_Ready;
        private System.Windows.Forms.Button cmd_Stop;
        private System.Windows.Forms.Button cmd_Stadby;
        private System.Windows.Forms.Label label1;
    }
}

