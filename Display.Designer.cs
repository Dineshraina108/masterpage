namespace Masterpagedesign
{
    partial class Display
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
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn21 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn22 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn23 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn24 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn25 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition5 = new Telerik.WinControls.UI.TableViewDefinition();
            this.viewpanel = new System.Windows.Forms.Panel();
            this.tabviewcon = new System.Windows.Forms.TabControl();
            this.tabviewbypro = new System.Windows.Forms.TabPage();
            this.tabviewbyday = new System.Windows.Forms.TabPage();
            this.tabviewbymonth = new System.Windows.Forms.TabPage();
            this.lblpro = new System.Windows.Forms.Label();
            this.cmbpro = new System.Windows.Forms.ComboBox();
            this.btnsub = new System.Windows.Forms.Button();
            this.Rgvpro = new Telerik.WinControls.UI.RadGridView();
            this.viewpanel.SuspendLayout();
            this.tabviewcon.SuspendLayout();
            this.tabviewbypro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rgvpro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rgvpro.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // viewpanel
            // 
            this.viewpanel.BackColor = System.Drawing.Color.Transparent;
            this.viewpanel.Controls.Add(this.tabviewcon);
            this.viewpanel.Location = new System.Drawing.Point(12, 19);
            this.viewpanel.Name = "viewpanel";
            this.viewpanel.Size = new System.Drawing.Size(869, 491);
            this.viewpanel.TabIndex = 0;
            // 
            // tabviewcon
            // 
            this.tabviewcon.Controls.Add(this.tabviewbypro);
            this.tabviewcon.Controls.Add(this.tabviewbyday);
            this.tabviewcon.Controls.Add(this.tabviewbymonth);
            this.tabviewcon.Location = new System.Drawing.Point(12, 13);
            this.tabviewcon.Name = "tabviewcon";
            this.tabviewcon.SelectedIndex = 0;
            this.tabviewcon.Size = new System.Drawing.Size(838, 463);
            this.tabviewcon.TabIndex = 0;
            // 
            // tabviewbypro
            // 
            this.tabviewbypro.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.tabviewbypro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabviewbypro.Controls.Add(this.Rgvpro);
            this.tabviewbypro.Controls.Add(this.btnsub);
            this.tabviewbypro.Controls.Add(this.cmbpro);
            this.tabviewbypro.Controls.Add(this.lblpro);
            this.tabviewbypro.Location = new System.Drawing.Point(4, 22);
            this.tabviewbypro.Name = "tabviewbypro";
            this.tabviewbypro.Padding = new System.Windows.Forms.Padding(3);
            this.tabviewbypro.Size = new System.Drawing.Size(830, 437);
            this.tabviewbypro.TabIndex = 0;
            this.tabviewbypro.Text = "VIEW BY PROJECT ";
            this.tabviewbypro.UseVisualStyleBackColor = true;
            // 
            // tabviewbyday
            // 
            this.tabviewbyday.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.tabviewbyday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabviewbyday.Location = new System.Drawing.Point(4, 22);
            this.tabviewbyday.Name = "tabviewbyday";
            this.tabviewbyday.Padding = new System.Windows.Forms.Padding(3);
            this.tabviewbyday.Size = new System.Drawing.Size(656, 436);
            this.tabviewbyday.TabIndex = 1;
            this.tabviewbyday.Text = "VIEW BY DAY";
            this.tabviewbyday.UseVisualStyleBackColor = true;
            // 
            // tabviewbymonth
            // 
            this.tabviewbymonth.BackColor = System.Drawing.Color.Transparent;
            this.tabviewbymonth.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.tabviewbymonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabviewbymonth.Location = new System.Drawing.Point(4, 22);
            this.tabviewbymonth.Name = "tabviewbymonth";
            this.tabviewbymonth.Size = new System.Drawing.Size(656, 436);
            this.tabviewbymonth.TabIndex = 2;
            this.tabviewbymonth.Text = "VIEW BY MONTH";
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpro.Location = new System.Drawing.Point(57, 30);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(113, 19);
            this.lblpro.TabIndex = 1;
            this.lblpro.Text = "Select a Project";
            // 
            // cmbpro
            // 
            this.cmbpro.FormattingEnabled = true;
            this.cmbpro.Location = new System.Drawing.Point(216, 30);
            this.cmbpro.Name = "cmbpro";
            this.cmbpro.Size = new System.Drawing.Size(121, 21);
            this.cmbpro.TabIndex = 2;
            this.cmbpro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbpro_KeyDown);
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(192, 74);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(76, 25);
            this.btnsub.TabIndex = 3;
            this.btnsub.Text = "Get";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // Rgvpro
            // 
            this.Rgvpro.BackColor = System.Drawing.Color.Transparent;
            this.Rgvpro.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rgvpro.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Rgvpro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Rgvpro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Rgvpro.Location = new System.Drawing.Point(20, 129);
            // 
            // 
            // 
            this.Rgvpro.MasterTemplate.AllowAddNewRow = false;
            this.Rgvpro.MasterTemplate.AllowColumnReorder = false;
            gridViewBrowseColumn21.EnableExpressionEditor = false;
            gridViewBrowseColumn21.FieldName = "SNO";
            gridViewBrowseColumn21.HeaderText = "S NO";
            gridViewBrowseColumn21.Name = "S NO";
            gridViewBrowseColumn22.EnableExpressionEditor = false;
            gridViewBrowseColumn22.FieldName = "WRDATE";
            gridViewBrowseColumn22.HeaderText = "WORK DATE";
            gridViewBrowseColumn22.Name = "WORK DATE";
            gridViewBrowseColumn22.Width = 96;
            gridViewBrowseColumn23.EnableExpressionEditor = false;
            gridViewBrowseColumn23.FieldName = "TECHNOLOGY";
            gridViewBrowseColumn23.HeaderText = "LANGUAGE";
            gridViewBrowseColumn23.Name = "TECHNOLOGY";
            gridViewBrowseColumn23.Width = 84;
            gridViewBrowseColumn24.EnableExpressionEditor = false;
            gridViewBrowseColumn24.FieldName = "SCREENNAME";
            gridViewBrowseColumn24.HeaderText = "SCREENNAME";
            gridViewBrowseColumn24.Name = "SCREEN NAME";
            gridViewBrowseColumn24.Width = 124;
            gridViewBrowseColumn25.EnableExpressionEditor = false;
            gridViewBrowseColumn25.FieldName = "TKACTION";
            gridViewBrowseColumn25.HeaderText = "YOUR ACTION";
            gridViewBrowseColumn25.Name = "YOUR ACTION";
            gridViewBrowseColumn25.Width = 407;
            this.Rgvpro.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewBrowseColumn21,
            gridViewBrowseColumn22,
            gridViewBrowseColumn23,
            gridViewBrowseColumn24,
            gridViewBrowseColumn25});
            this.Rgvpro.MasterTemplate.EnableAlternatingRowColor = true;
            this.Rgvpro.MasterTemplate.ViewDefinition = tableViewDefinition5;
            this.Rgvpro.Name = "Rgvpro";
            this.Rgvpro.ReadOnly = true;
            this.Rgvpro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rgvpro.Size = new System.Drawing.Size(785, 214);
            this.Rgvpro.TabIndex = 4;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 525);
            this.Controls.Add(this.viewpanel);
            this.Name = "Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            this.viewpanel.ResumeLayout(false);
            this.tabviewcon.ResumeLayout(false);
            this.tabviewbypro.ResumeLayout(false);
            this.tabviewbypro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rgvpro.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rgvpro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewpanel;
        private System.Windows.Forms.TabControl tabviewcon;
        private System.Windows.Forms.TabPage tabviewbypro;
        private System.Windows.Forms.TabPage tabviewbyday;
        private System.Windows.Forms.TabPage tabviewbymonth;
        private Telerik.WinControls.UI.RadGridView Rgvpro;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.ComboBox cmbpro;
        private System.Windows.Forms.Label lblpro;
    }
}