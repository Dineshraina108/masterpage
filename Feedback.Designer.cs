namespace Masterpagedesign
{
    partial class Feedback
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
            this.lblfetitle = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprocess = new System.Windows.Forms.TextBox();
            this.lblprocess = new System.Windows.Forms.Label();
            this.txtdept = new System.Windows.Forms.TextBox();
            this.lbldept = new System.Windows.Forms.Label();
            this.txtpos = new System.Windows.Forms.TextBox();
            this.lblpos = new System.Windows.Forms.Label();
            this.btnsub = new System.Windows.Forms.Button();
            this.btncan = new System.Windows.Forms.Button();
            this.lbldes = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblfetitle
            // 
            this.lblfetitle.AutoSize = true;
            this.lblfetitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfetitle.Location = new System.Drawing.Point(78, 20);
            this.lblfetitle.Name = "lblfetitle";
            this.lblfetitle.Size = new System.Drawing.Size(184, 22);
            this.lblfetitle.TabIndex = 0;
            this.lblfetitle.Text = "FEEDBACK  FORM";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(35, 73);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(52, 17);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "NAME";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(152, 68);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(188, 22);
            this.txtname.TabIndex = 2;
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // txtprocess
            // 
            this.txtprocess.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprocess.Location = new System.Drawing.Point(152, 155);
            this.txtprocess.Name = "txtprocess";
            this.txtprocess.ReadOnly = true;
            this.txtprocess.Size = new System.Drawing.Size(188, 22);
            this.txtprocess.TabIndex = 4;
            this.txtprocess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprocess_KeyDown);
            // 
            // lblprocess
            // 
            this.lblprocess.AutoSize = true;
            this.lblprocess.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprocess.Location = new System.Drawing.Point(35, 160);
            this.lblprocess.Name = "lblprocess";
            this.lblprocess.Size = new System.Drawing.Size(73, 17);
            this.lblprocess.TabIndex = 3;
            this.lblprocess.Text = "PROCESS";
            // 
            // txtdept
            // 
            this.txtdept.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdept.Location = new System.Drawing.Point(152, 198);
            this.txtdept.Name = "txtdept";
            this.txtdept.ReadOnly = true;
            this.txtdept.Size = new System.Drawing.Size(188, 22);
            this.txtdept.TabIndex = 6;
            this.txtdept.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdept_KeyDown);
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldept.Location = new System.Drawing.Point(35, 203);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(107, 17);
            this.lbldept.TabIndex = 5;
            this.lbldept.Text = "DEPARTMENT";
            // 
            // txtpos
            // 
            this.txtpos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpos.Location = new System.Drawing.Point(152, 109);
            this.txtpos.Name = "txtpos";
            this.txtpos.ReadOnly = true;
            this.txtpos.Size = new System.Drawing.Size(188, 22);
            this.txtpos.TabIndex = 8;
            this.txtpos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpos_KeyDown);
            // 
            // lblpos
            // 
            this.lblpos.AutoSize = true;
            this.lblpos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpos.Location = new System.Drawing.Point(35, 114);
            this.lblpos.Name = "lblpos";
            this.lblpos.Size = new System.Drawing.Size(77, 17);
            this.lblpos.TabIndex = 7;
            this.lblpos.Text = "POSITION";
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(82, 334);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 9;
            this.btnsub.Text = "SUBMIT";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btncan
            // 
            this.btncan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncan.Location = new System.Drawing.Point(191, 334);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(84, 23);
            this.btncan.TabIndex = 10;
            this.btncan.Text = "CANCEL";
            this.btncan.UseVisualStyleBackColor = true;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // lbldes
            // 
            this.lbldes.AutoSize = true;
            this.lbldes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldes.Location = new System.Drawing.Point(35, 243);
            this.lbldes.Name = "lbldes";
            this.lbldes.Size = new System.Drawing.Size(106, 17);
            this.lbldes.TabIndex = 11;
            this.lbldes.Text = "DESCRIPTION";
            // 
            // txtdes
            // 
            this.txtdes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.Location = new System.Drawing.Point(152, 240);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(188, 71);
            this.txtdes.TabIndex = 12;
            this.txtdes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdes_KeyDown);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(383, 377);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.lbldes);
            this.Controls.Add(this.btncan);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.txtpos);
            this.Controls.Add(this.lblpos);
            this.Controls.Add(this.txtdept);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.txtprocess);
            this.Controls.Add(this.lblprocess);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblfetitle);
            this.Name = "Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfetitle;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprocess;
        private System.Windows.Forms.Label lblprocess;
        private System.Windows.Forms.TextBox txtdept;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.TextBox txtpos;
        private System.Windows.Forms.Label lblpos;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Label lbldes;
        private System.Windows.Forms.TextBox txtdes;
    }
}