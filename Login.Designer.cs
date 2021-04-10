namespace Masterpagedesign
{
    partial class Login
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
            this.lbltile = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.btnsignin = new System.Windows.Forms.Button();
            this.llblsignup = new System.Windows.Forms.LinkLabel();
            this.lblslash = new System.Windows.Forms.Label();
            this.llblforgetpassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbltile
            // 
            this.lbltile.AutoSize = true;
            this.lbltile.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltile.Location = new System.Drawing.Point(100, 22);
            this.lbltile.Name = "lbltile";
            this.lbltile.Size = new System.Drawing.Size(70, 22);
            this.lbltile.TabIndex = 0;
            this.lbltile.Text = "LOGIN";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(28, 77);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(90, 17);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "USERNAME";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(143, 77);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 2;
            this.txtuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuser_KeyDown);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(143, 113);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 4;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(28, 113);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(89, 17);
            this.lblpass.TabIndex = 3;
            this.lblpass.Text = "PASSWORD";
            // 
            // btnsignin
            // 
            this.btnsignin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.Location = new System.Drawing.Point(104, 177);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(75, 23);
            this.btnsignin.TabIndex = 5;
            this.btnsignin.Text = "SIGN IN";
            this.btnsignin.UseVisualStyleBackColor = true;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // llblsignup
            // 
            this.llblsignup.AutoSize = true;
            this.llblsignup.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblsignup.Location = new System.Drawing.Point(286, 149);
            this.llblsignup.Name = "llblsignup";
            this.llblsignup.Size = new System.Drawing.Size(45, 15);
            this.llblsignup.TabIndex = 12;
            this.llblsignup.TabStop = true;
            this.llblsignup.Text = "Signup";
            this.llblsignup.Visible = false;
            this.llblsignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblsignup_LinkClicked);
            // 
            // lblslash
            // 
            this.lblslash.AutoSize = true;
            this.lblslash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblslash.Location = new System.Drawing.Point(274, 148);
            this.lblslash.Name = "lblslash";
            this.lblslash.Size = new System.Drawing.Size(12, 16);
            this.lblslash.TabIndex = 11;
            this.lblslash.Text = "/";
            this.lblslash.Visible = false;
            // 
            // llblforgetpassword
            // 
            this.llblforgetpassword.AutoSize = true;
            this.llblforgetpassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblforgetpassword.Location = new System.Drawing.Point(177, 148);
            this.llblforgetpassword.Name = "llblforgetpassword";
            this.llblforgetpassword.Size = new System.Drawing.Size(97, 15);
            this.llblforgetpassword.TabIndex = 10;
            this.llblforgetpassword.TabStop = true;
            this.llblforgetpassword.Text = "Forget Password";
            this.llblforgetpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblforgetpassword_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Masterpagedesign.Properties.Resources.log2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 235);
            this.Controls.Add(this.llblsignup);
            this.Controls.Add(this.lblslash);
            this.Controls.Add(this.llblforgetpassword);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lbltile);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltile;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Button btnsignin;
        internal System.Windows.Forms.LinkLabel llblsignup;
        internal System.Windows.Forms.Label lblslash;
        internal System.Windows.Forms.LinkLabel llblforgetpassword;
    }
}

