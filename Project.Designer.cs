namespace Masterpagedesign
{
    partial class Project
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
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn6 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn7 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn8 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn9 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn10 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.proinspanel = new System.Windows.Forms.Panel();
            this.cmblan = new System.Windows.Forms.ComboBox();
            this.btncan = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.dtpendate = new System.Windows.Forms.DateTimePicker();
            this.lblproendate = new System.Windows.Forms.Label();
            this.dtpst = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblstdate = new System.Windows.Forms.Label();
            this.lblprolan = new System.Windows.Forms.Label();
            this.txtproname = new System.Windows.Forms.TextBox();
            this.lblproname = new System.Windows.Forms.Label();
            this.lblproent = new System.Windows.Forms.Label();
            this.proviewpanel = new System.Windows.Forms.Panel();
            this.Rgvpro = new Telerik.WinControls.UI.RadGridView();
            this.lblprodet = new System.Windows.Forms.Label();
            this.promodpanel = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.cmppro = new System.Windows.Forms.ComboBox();
            this.lblselpro = new System.Windows.Forms.Label();
            this.cmblang = new System.Windows.Forms.ComboBox();
            this.dtpen = new System.Windows.Forms.DateTimePicker();
            this.lblend = new System.Windows.Forms.Label();
            this.lbllan = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.lblpro = new System.Windows.Forms.Label();
            this.lblprotitle = new System.Windows.Forms.Label();
            this.proinspanel.SuspendLayout();
            this.proviewpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rgvpro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rgvpro.MasterTemplate)).BeginInit();
            this.promodpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // proinspanel
            // 
            this.proinspanel.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.proinspanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.proinspanel.Controls.Add(this.cmblan);
            this.proinspanel.Controls.Add(this.btncan);
            this.proinspanel.Controls.Add(this.btnsub);
            this.proinspanel.Controls.Add(this.dtpendate);
            this.proinspanel.Controls.Add(this.lblproendate);
            this.proinspanel.Controls.Add(this.dtpst);
            this.proinspanel.Controls.Add(this.label2);
            this.proinspanel.Controls.Add(this.lblstdate);
            this.proinspanel.Controls.Add(this.lblprolan);
            this.proinspanel.Controls.Add(this.txtproname);
            this.proinspanel.Controls.Add(this.lblproname);
            this.proinspanel.Controls.Add(this.lblproent);
            this.proinspanel.Location = new System.Drawing.Point(5, 4);
            this.proinspanel.Name = "proinspanel";
            this.proinspanel.Size = new System.Drawing.Size(339, 308);
            this.proinspanel.TabIndex = 0;
            // 
            // cmblan
            // 
            this.cmblan.FormattingEnabled = true;
            this.cmblan.Location = new System.Drawing.Point(162, 101);
            this.cmblan.Name = "cmblan";
            this.cmblan.Size = new System.Drawing.Size(126, 21);
            this.cmblan.TabIndex = 13;
            this.cmblan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmblan_KeyDown);
            // 
            // btncan
            // 
            this.btncan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncan.Location = new System.Drawing.Point(162, 220);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(84, 23);
            this.btncan.TabIndex = 12;
            this.btncan.Text = "CANCEL";
            this.btncan.UseVisualStyleBackColor = true;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(52, 220);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 11;
            this.btnsub.Text = "SUBMIT";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // dtpendate
            // 
            this.dtpendate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpendate.Location = new System.Drawing.Point(162, 181);
            this.dtpendate.MinDate = new System.DateTime(2021, 4, 10, 0, 0, 0, 0);
            this.dtpendate.Name = "dtpendate";
            this.dtpendate.Size = new System.Drawing.Size(126, 20);
            this.dtpendate.TabIndex = 9;
            this.dtpendate.Value = new System.DateTime(2021, 4, 10, 10, 46, 28, 0);
            this.dtpendate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpendate_KeyDown);
            // 
            // lblproendate
            // 
            this.lblproendate.AutoSize = true;
            this.lblproendate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproendate.Location = new System.Drawing.Point(14, 181);
            this.lblproendate.Name = "lblproendate";
            this.lblproendate.Size = new System.Drawing.Size(81, 17);
            this.lblproendate.TabIndex = 8;
            this.lblproendate.Text = "END DATE";
            this.lblproendate.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpst
            // 
            this.dtpst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpst.Location = new System.Drawing.Point(162, 141);
            this.dtpst.MinDate = new System.DateTime(2021, 4, 10, 0, 0, 0, 0);
            this.dtpst.Name = "dtpst";
            this.dtpst.Size = new System.Drawing.Size(126, 20);
            this.dtpst.TabIndex = 7;
            this.dtpst.Value = new System.DateTime(2021, 4, 10, 10, 46, 28, 0);
            this.dtpst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpst_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // lblstdate
            // 
            this.lblstdate.AutoSize = true;
            this.lblstdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstdate.Location = new System.Drawing.Point(14, 141);
            this.lblstdate.Name = "lblstdate";
            this.lblstdate.Size = new System.Drawing.Size(95, 17);
            this.lblstdate.TabIndex = 5;
            this.lblstdate.Text = "START DATE";
            // 
            // lblprolan
            // 
            this.lblprolan.AutoSize = true;
            this.lblprolan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprolan.Location = new System.Drawing.Point(14, 101);
            this.lblprolan.Name = "lblprolan";
            this.lblprolan.Size = new System.Drawing.Size(90, 17);
            this.lblprolan.TabIndex = 3;
            this.lblprolan.Text = "LANGUAGE";
            // 
            // txtproname
            // 
            this.txtproname.Location = new System.Drawing.Point(162, 58);
            this.txtproname.Name = "txtproname";
            this.txtproname.Size = new System.Drawing.Size(126, 20);
            this.txtproname.TabIndex = 2;
            this.txtproname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtproname_KeyDown);
            // 
            // lblproname
            // 
            this.lblproname.AutoSize = true;
            this.lblproname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproname.Location = new System.Drawing.Point(14, 58);
            this.lblproname.Name = "lblproname";
            this.lblproname.Size = new System.Drawing.Size(120, 17);
            this.lblproname.TabIndex = 1;
            this.lblproname.Text = "PROJECT NAME";
            // 
            // lblproent
            // 
            this.lblproent.AutoSize = true;
            this.lblproent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproent.Location = new System.Drawing.Point(72, 18);
            this.lblproent.Name = "lblproent";
            this.lblproent.Size = new System.Drawing.Size(137, 18);
            this.lblproent.TabIndex = 0;
            this.lblproent.Text = "PROJECT ENTRY";
            // 
            // proviewpanel
            // 
            this.proviewpanel.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.proviewpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.proviewpanel.Controls.Add(this.Rgvpro);
            this.proviewpanel.Controls.Add(this.lblprodet);
            this.proviewpanel.Location = new System.Drawing.Point(358, 4);
            this.proviewpanel.Name = "proviewpanel";
            this.proviewpanel.Size = new System.Drawing.Size(546, 308);
            this.proviewpanel.TabIndex = 1;
            // 
            // Rgvpro
            // 
            this.Rgvpro.BackColor = System.Drawing.SystemColors.Control;
            this.Rgvpro.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rgvpro.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Rgvpro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Rgvpro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Rgvpro.Location = new System.Drawing.Point(29, 58);
            // 
            // 
            // 
            this.Rgvpro.MasterTemplate.AllowAddNewRow = false;
            this.Rgvpro.MasterTemplate.AllowColumnReorder = false;
            gridViewBrowseColumn6.EnableExpressionEditor = false;
            gridViewBrowseColumn6.FieldName = "PRJID";
            gridViewBrowseColumn6.HeaderText = "PROJECT ID";
            gridViewBrowseColumn6.Name = "PRJID";
            gridViewBrowseColumn6.Width = 78;
            gridViewBrowseColumn7.EnableExpressionEditor = false;
            gridViewBrowseColumn7.FieldName = "PRJNAME";
            gridViewBrowseColumn7.HeaderText = "PROJECT NAME";
            gridViewBrowseColumn7.Name = "PRJNAME";
            gridViewBrowseColumn7.Width = 154;
            gridViewBrowseColumn8.EnableExpressionEditor = false;
            gridViewBrowseColumn8.FieldName = "PRJLAN";
            gridViewBrowseColumn8.HeaderText = "LANGUAGE";
            gridViewBrowseColumn8.Name = "PRJLAN";
            gridViewBrowseColumn8.Width = 73;
            gridViewBrowseColumn9.EnableExpressionEditor = false;
            gridViewBrowseColumn9.FieldName = "STDATE";
            gridViewBrowseColumn9.HeaderText = "START DATE";
            gridViewBrowseColumn9.Name = "STDATE";
            gridViewBrowseColumn9.Width = 90;
            gridViewBrowseColumn10.EnableExpressionEditor = false;
            gridViewBrowseColumn10.FieldName = "ENDATE";
            gridViewBrowseColumn10.HeaderText = "END DATE";
            gridViewBrowseColumn10.Name = "ENDATE";
            gridViewBrowseColumn10.Width = 72;
            this.Rgvpro.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewBrowseColumn6,
            gridViewBrowseColumn7,
            gridViewBrowseColumn8,
            gridViewBrowseColumn9,
            gridViewBrowseColumn10});
            this.Rgvpro.MasterTemplate.EnableAlternatingRowColor = true;
            this.Rgvpro.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.Rgvpro.Name = "Rgvpro";
            this.Rgvpro.ReadOnly = true;
            this.Rgvpro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rgvpro.Size = new System.Drawing.Size(484, 185);
            this.Rgvpro.TabIndex = 2;
            // 
            // lblprodet
            // 
            this.lblprodet.AutoSize = true;
            this.lblprodet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodet.Location = new System.Drawing.Point(12, 18);
            this.lblprodet.Name = "lblprodet";
            this.lblprodet.Size = new System.Drawing.Size(150, 18);
            this.lblprodet.TabIndex = 1;
            this.lblprodet.Text = "Project details are....";
            // 
            // promodpanel
            // 
            this.promodpanel.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.promodpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.promodpanel.Controls.Add(this.btncancel);
            this.promodpanel.Controls.Add(this.btnsubmit);
            this.promodpanel.Controls.Add(this.cmppro);
            this.promodpanel.Controls.Add(this.lblselpro);
            this.promodpanel.Controls.Add(this.cmblang);
            this.promodpanel.Controls.Add(this.dtpen);
            this.promodpanel.Controls.Add(this.lblend);
            this.promodpanel.Controls.Add(this.lbllan);
            this.promodpanel.Controls.Add(this.txtpname);
            this.promodpanel.Controls.Add(this.lblpro);
            this.promodpanel.Controls.Add(this.lblprotitle);
            this.promodpanel.Location = new System.Drawing.Point(215, 318);
            this.promodpanel.Name = "promodpanel";
            this.promodpanel.Size = new System.Drawing.Size(403, 312);
            this.promodpanel.TabIndex = 2;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(203, 231);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(84, 23);
            this.btncancel.TabIndex = 27;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(93, 231);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 26;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // cmppro
            // 
            this.cmppro.FormattingEnabled = true;
            this.cmppro.Location = new System.Drawing.Point(230, 67);
            this.cmppro.Name = "cmppro";
            this.cmppro.Size = new System.Drawing.Size(126, 21);
            this.cmppro.TabIndex = 25;
            this.cmppro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmppro_KeyDown);
            // 
            // lblselpro
            // 
            this.lblselpro.AutoSize = true;
            this.lblselpro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselpro.Location = new System.Drawing.Point(37, 67);
            this.lblselpro.Name = "lblselpro";
            this.lblselpro.Size = new System.Drawing.Size(176, 17);
            this.lblselpro.TabIndex = 24;
            this.lblselpro.Text = "SELECT YOUR PROJECT";
            // 
            // cmblang
            // 
            this.cmblang.FormattingEnabled = true;
            this.cmblang.Location = new System.Drawing.Point(230, 142);
            this.cmblang.Name = "cmblang";
            this.cmblang.Size = new System.Drawing.Size(126, 21);
            this.cmblang.TabIndex = 23;
            this.cmblang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmblang_KeyDown);
            // 
            // dtpen
            // 
            this.dtpen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpen.Location = new System.Drawing.Point(230, 186);
            this.dtpen.MinDate = new System.DateTime(2021, 4, 10, 0, 0, 0, 0);
            this.dtpen.Name = "dtpen";
            this.dtpen.Size = new System.Drawing.Size(126, 20);
            this.dtpen.TabIndex = 20;
            this.dtpen.Value = new System.DateTime(2021, 4, 10, 10, 46, 28, 0);
            this.dtpen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend.Location = new System.Drawing.Point(39, 190);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(81, 17);
            this.lblend.TabIndex = 19;
            this.lblend.Text = "END DATE";
            // 
            // lbllan
            // 
            this.lbllan.AutoSize = true;
            this.lbllan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllan.Location = new System.Drawing.Point(39, 146);
            this.lbllan.Name = "lbllan";
            this.lbllan.Size = new System.Drawing.Size(90, 17);
            this.lbllan.TabIndex = 16;
            this.lbllan.Text = "LANGUAGE";
            // 
            // txtpname
            // 
            this.txtpname.Location = new System.Drawing.Point(230, 106);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(126, 20);
            this.txtpname.TabIndex = 15;
            this.txtpname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpname_KeyDown);
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpro.Location = new System.Drawing.Point(39, 106);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(120, 17);
            this.lblpro.TabIndex = 14;
            this.lblpro.Text = "PROJECT NAME";
            // 
            // lblprotitle
            // 
            this.lblprotitle.AutoSize = true;
            this.lblprotitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprotitle.Location = new System.Drawing.Point(90, 26);
            this.lblprotitle.Name = "lblprotitle";
            this.lblprotitle.Size = new System.Drawing.Size(196, 18);
            this.lblprotitle.TabIndex = 1;
            this.lblprotitle.Text = "PROJECT MODIFICATION";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 633);
            this.Controls.Add(this.promodpanel);
            this.Controls.Add(this.proviewpanel);
            this.Controls.Add(this.proinspanel);
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            this.proinspanel.ResumeLayout(false);
            this.proinspanel.PerformLayout();
            this.proviewpanel.ResumeLayout(false);
            this.proviewpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rgvpro.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rgvpro)).EndInit();
            this.promodpanel.ResumeLayout(false);
            this.promodpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel proinspanel;
        private System.Windows.Forms.Label lblproname;
        private System.Windows.Forms.Label lblproent;
        private System.Windows.Forms.Label lblprolan;
        private System.Windows.Forms.TextBox txtproname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblstdate;
        private System.Windows.Forms.DateTimePicker dtpst;
        private System.Windows.Forms.DateTimePicker dtpendate;
        private System.Windows.Forms.Label lblproendate;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.ComboBox cmblan;
        private System.Windows.Forms.Panel proviewpanel;
        private Telerik.WinControls.UI.RadGridView Rgvpro;
        private System.Windows.Forms.Label lblprodet;
        private System.Windows.Forms.Panel promodpanel;
        private System.Windows.Forms.Label lblprotitle;
        private System.Windows.Forms.ComboBox cmppro;
        private System.Windows.Forms.Label lblselpro;
        private System.Windows.Forms.ComboBox cmblang;
        private System.Windows.Forms.DateTimePicker dtpen;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Label lbllan;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label lblpro;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsubmit;
    }
}