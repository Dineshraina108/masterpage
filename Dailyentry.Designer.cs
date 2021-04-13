namespace Masterpagedesign
{
    partial class Dailyentry
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
            this.dailypanel = new System.Windows.Forms.Panel();
            this.lblden = new System.Windows.Forms.Label();
            this.btncan = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.txtaction = new System.Windows.Forms.TextBox();
            this.LBLACTION = new System.Windows.Forms.Label();
            this.txtscname = new System.Windows.Forms.TextBox();
            this.lblscname = new System.Windows.Forms.Label();
            this.cmbtech = new System.Windows.Forms.ComboBox();
            this.lbltech = new System.Windows.Forms.Label();
            this.cmpproj = new System.Windows.Forms.ComboBox();
            this.lblproj = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.dailypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailypanel
            // 
            this.dailypanel.BackColor = System.Drawing.Color.Transparent;
            this.dailypanel.Controls.Add(this.lblden);
            this.dailypanel.Controls.Add(this.btncan);
            this.dailypanel.Controls.Add(this.btnsub);
            this.dailypanel.Controls.Add(this.txtaction);
            this.dailypanel.Controls.Add(this.LBLACTION);
            this.dailypanel.Controls.Add(this.txtscname);
            this.dailypanel.Controls.Add(this.lblscname);
            this.dailypanel.Controls.Add(this.cmbtech);
            this.dailypanel.Controls.Add(this.lbltech);
            this.dailypanel.Controls.Add(this.cmpproj);
            this.dailypanel.Controls.Add(this.lblproj);
            this.dailypanel.Controls.Add(this.txtdate);
            this.dailypanel.Controls.Add(this.lbldate);
            this.dailypanel.Controls.Add(this.txtuser);
            this.dailypanel.Controls.Add(this.lbluser);
            this.dailypanel.Location = new System.Drawing.Point(20, 28);
            this.dailypanel.Name = "dailypanel";
            this.dailypanel.Size = new System.Drawing.Size(396, 443);
            this.dailypanel.TabIndex = 0;
            // 
            // lblden
            // 
            this.lblden.AutoSize = true;
            this.lblden.BackColor = System.Drawing.Color.Transparent;
            this.lblden.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblden.Location = new System.Drawing.Point(108, 21);
            this.lblden.Name = "lblden";
            this.lblden.Size = new System.Drawing.Size(166, 24);
            this.lblden.TabIndex = 1;
            this.lblden.Text = "TODAY ACTION";
            // 
            // btncan
            // 
            this.btncan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncan.Location = new System.Drawing.Point(191, 398);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(83, 23);
            this.btncan.TabIndex = 13;
            this.btncan.Text = "CANCEL";
            this.btncan.UseVisualStyleBackColor = true;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(94, 398);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 12;
            this.btnsub.Text = "SUBMIT";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // txtaction
            // 
            this.txtaction.BackColor = System.Drawing.Color.LightCyan;
            this.txtaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaction.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaction.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtaction.Location = new System.Drawing.Point(168, 308);
            this.txtaction.Multiline = true;
            this.txtaction.Name = "txtaction";
            this.txtaction.Size = new System.Drawing.Size(193, 65);
            this.txtaction.TabIndex = 11;
            this.txtaction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaction_KeyDown);
            // 
            // LBLACTION
            // 
            this.LBLACTION.AutoSize = true;
            this.LBLACTION.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLACTION.Location = new System.Drawing.Point(23, 316);
            this.LBLACTION.Name = "LBLACTION";
            this.LBLACTION.Size = new System.Drawing.Size(101, 17);
            this.LBLACTION.TabIndex = 10;
            this.LBLACTION.Text = "YOUR WORK";
            // 
            // txtscname
            // 
            this.txtscname.BackColor = System.Drawing.Color.LightCyan;
            this.txtscname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtscname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtscname.Location = new System.Drawing.Point(168, 263);
            this.txtscname.Name = "txtscname";
            this.txtscname.Size = new System.Drawing.Size(193, 25);
            this.txtscname.TabIndex = 9;
            this.txtscname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtscname_KeyDown);
            // 
            // lblscname
            // 
            this.lblscname.AutoSize = true;
            this.lblscname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscname.Location = new System.Drawing.Point(23, 271);
            this.lblscname.Name = "lblscname";
            this.lblscname.Size = new System.Drawing.Size(113, 17);
            this.lblscname.TabIndex = 8;
            this.lblscname.Text = "SCREEN NAME";
            // 
            // cmbtech
            // 
            this.cmbtech.BackColor = System.Drawing.Color.LightCyan;
            this.cmbtech.FormattingEnabled = true;
            this.cmbtech.Location = new System.Drawing.Point(168, 217);
            this.cmbtech.Name = "cmbtech";
            this.cmbtech.Size = new System.Drawing.Size(193, 21);
            this.cmbtech.TabIndex = 7;
            this.cmbtech.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbtech_KeyDown);
            // 
            // lbltech
            // 
            this.lbltech.AutoSize = true;
            this.lbltech.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltech.Location = new System.Drawing.Point(23, 217);
            this.lbltech.Name = "lbltech";
            this.lbltech.Size = new System.Drawing.Size(110, 17);
            this.lbltech.TabIndex = 6;
            this.lbltech.Text = "TECHNOLOGY";
            // 
            // cmpproj
            // 
            this.cmpproj.BackColor = System.Drawing.Color.LightCyan;
            this.cmpproj.FormattingEnabled = true;
            this.cmpproj.Location = new System.Drawing.Point(168, 172);
            this.cmpproj.Name = "cmpproj";
            this.cmpproj.Size = new System.Drawing.Size(193, 21);
            this.cmpproj.TabIndex = 5;
            this.cmpproj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmpproj_KeyDown);
            // 
            // lblproj
            // 
            this.lblproj.AutoSize = true;
            this.lblproj.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproj.Location = new System.Drawing.Point(23, 173);
            this.lblproj.Name = "lblproj";
            this.lblproj.Size = new System.Drawing.Size(120, 17);
            this.lblproj.TabIndex = 4;
            this.lblproj.Text = "PROJECT NAME";
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.LightCyan;
            this.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdate.Location = new System.Drawing.Point(168, 117);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(193, 25);
            this.txtdate.TabIndex = 3;
            this.txtdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdate_KeyDown);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(23, 122);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(46, 17);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "DATE";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.LightCyan;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtuser.Location = new System.Drawing.Point(168, 66);
            this.txtuser.Name = "txtuser";
            this.txtuser.ReadOnly = true;
            this.txtuser.Size = new System.Drawing.Size(193, 25);
            this.txtuser.TabIndex = 1;
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(23, 74);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(46, 17);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "USER";
            // 
            // Dailyentry
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Masterpagedesign.Properties.Resources.d64ef645781f8026a1a0fa275e75cf55;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 495);
            this.Controls.Add(this.dailypanel);
            this.Location = new System.Drawing.Point(430, 180);
            this.Name = "Dailyentry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dailyentry";
            this.Load += new System.EventHandler(this.Dailyentry_Load);
            this.dailypanel.ResumeLayout(false);
            this.dailypanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dailypanel;
        private System.Windows.Forms.Label lblden;
        private System.Windows.Forms.ComboBox cmpproj;
        private System.Windows.Forms.Label lblproj;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.ComboBox cmbtech;
        private System.Windows.Forms.Label lbltech;
        private System.Windows.Forms.TextBox txtaction;
        private System.Windows.Forms.Label LBLACTION;
        private System.Windows.Forms.TextBox txtscname;
        private System.Windows.Forms.Label lblscname;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Button btnsub;
    }
}