namespace Masterpagedesign
{
    partial class Task
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
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn7 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn8 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn9 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.Taskviewpanel = new System.Windows.Forms.Panel();
            this.rgvtask = new Telerik.WinControls.UI.RadGridView();
            this.lbltask = new System.Windows.Forms.Label();
            this.taskentrypanel = new System.Windows.Forms.Panel();
            this.lbltasken = new System.Windows.Forms.Label();
            this.txttaskname = new System.Windows.Forms.TextBox();
            this.lbltaskname = new System.Windows.Forms.Label();
            this.txtdur = new System.Windows.Forms.TextBox();
            this.lbldur = new System.Windows.Forms.Label();
            this.btncan = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.taskmodpanel = new System.Windows.Forms.Panel();
            this.lbltaskmod = new System.Windows.Forms.Label();
            this.cmptask = new System.Windows.Forms.ComboBox();
            this.lblseltask = new System.Windows.Forms.Label();
            this.btnmodcan = new System.Windows.Forms.Button();
            this.btnmodsub = new System.Windows.Forms.Button();
            this.txtmoddur = new System.Windows.Forms.TextBox();
            this.lblmoddur = new System.Windows.Forms.Label();
            this.txtmodtaskname = new System.Windows.Forms.TextBox();
            this.lblseltname = new System.Windows.Forms.Label();
            this.Taskviewpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvtask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvtask.MasterTemplate)).BeginInit();
            this.taskentrypanel.SuspendLayout();
            this.taskmodpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Taskviewpanel
            // 
            this.Taskviewpanel.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.Taskviewpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Taskviewpanel.Controls.Add(this.lbltask);
            this.Taskviewpanel.Controls.Add(this.rgvtask);
            this.Taskviewpanel.Location = new System.Drawing.Point(13, 13);
            this.Taskviewpanel.Name = "Taskviewpanel";
            this.Taskviewpanel.Size = new System.Drawing.Size(386, 307);
            this.Taskviewpanel.TabIndex = 0;
            // 
            // rgvtask
            // 
            this.rgvtask.BackColor = System.Drawing.SystemColors.Control;
            this.rgvtask.Cursor = System.Windows.Forms.Cursors.Default;
            this.rgvtask.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rgvtask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rgvtask.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rgvtask.Location = new System.Drawing.Point(18, 69);
            // 
            // 
            // 
            this.rgvtask.MasterTemplate.AllowAddNewRow = false;
            this.rgvtask.MasterTemplate.AllowColumnReorder = false;
            gridViewBrowseColumn7.EnableExpressionEditor = false;
            gridViewBrowseColumn7.FieldName = "TASKID";
            gridViewBrowseColumn7.HeaderText = "TASK ID";
            gridViewBrowseColumn7.Name = "TASKID";
            gridViewBrowseColumn7.Width = 56;
            gridViewBrowseColumn8.EnableExpressionEditor = false;
            gridViewBrowseColumn8.FieldName = "TASKNAME";
            gridViewBrowseColumn8.HeaderText = "TASK NAME";
            gridViewBrowseColumn8.Name = "TASKNAME";
            gridViewBrowseColumn8.Width = 154;
            gridViewBrowseColumn9.EnableExpressionEditor = false;
            gridViewBrowseColumn9.FieldName = "DURATION";
            gridViewBrowseColumn9.HeaderText = "DURATION";
            gridViewBrowseColumn9.Name = "DURATION";
            gridViewBrowseColumn9.Width = 92;
            this.rgvtask.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewBrowseColumn7,
            gridViewBrowseColumn8,
            gridViewBrowseColumn9});
            this.rgvtask.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgvtask.Name = "rgvtask";
            this.rgvtask.ReadOnly = true;
            this.rgvtask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgvtask.Size = new System.Drawing.Size(327, 150);
            this.rgvtask.TabIndex = 0;
            // 
            // lbltask
            // 
            this.lbltask.AutoSize = true;
            this.lbltask.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltask.Location = new System.Drawing.Point(15, 27);
            this.lbltask.Name = "lbltask";
            this.lbltask.Size = new System.Drawing.Size(133, 18);
            this.lbltask.TabIndex = 2;
            this.lbltask.Text = "Task details are....";
            // 
            // taskentrypanel
            // 
            this.taskentrypanel.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.taskentrypanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.taskentrypanel.Controls.Add(this.btncan);
            this.taskentrypanel.Controls.Add(this.btnsub);
            this.taskentrypanel.Controls.Add(this.txtdur);
            this.taskentrypanel.Controls.Add(this.lbldur);
            this.taskentrypanel.Controls.Add(this.txttaskname);
            this.taskentrypanel.Controls.Add(this.lbltaskname);
            this.taskentrypanel.Controls.Add(this.lbltasken);
            this.taskentrypanel.Location = new System.Drawing.Point(438, 13);
            this.taskentrypanel.Name = "taskentrypanel";
            this.taskentrypanel.Size = new System.Drawing.Size(312, 217);
            this.taskentrypanel.TabIndex = 1;
            // 
            // lbltasken
            // 
            this.lbltasken.AutoSize = true;
            this.lbltasken.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltasken.Location = new System.Drawing.Point(73, 18);
            this.lbltasken.Name = "lbltasken";
            this.lbltasken.Size = new System.Drawing.Size(104, 18);
            this.lbltasken.TabIndex = 1;
            this.lbltasken.Text = "TASK ENTRY";
            // 
            // txttaskname
            // 
            this.txttaskname.Location = new System.Drawing.Point(136, 54);
            this.txttaskname.Name = "txttaskname";
            this.txttaskname.Size = new System.Drawing.Size(134, 20);
            this.txttaskname.TabIndex = 4;
            this.txttaskname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttaskname_KeyDown);
            // 
            // lbltaskname
            // 
            this.lbltaskname.AutoSize = true;
            this.lbltaskname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaskname.Location = new System.Drawing.Point(15, 57);
            this.lbltaskname.Name = "lbltaskname";
            this.lbltaskname.Size = new System.Drawing.Size(94, 17);
            this.lbltaskname.TabIndex = 3;
            this.lbltaskname.Text = "TASK NAME";
            // 
            // txtdur
            // 
            this.txtdur.Location = new System.Drawing.Point(136, 104);
            this.txtdur.Name = "txtdur";
            this.txtdur.Size = new System.Drawing.Size(134, 20);
            this.txtdur.TabIndex = 6;
            this.txtdur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdur_KeyDown);
            // 
            // lbldur
            // 
            this.lbldur.AutoSize = true;
            this.lbldur.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldur.Location = new System.Drawing.Point(15, 104);
            this.lbldur.Name = "lbldur";
            this.lbldur.Size = new System.Drawing.Size(85, 17);
            this.lbldur.TabIndex = 5;
            this.lbldur.Text = "DURATION";
            // 
            // btncan
            // 
            this.btncan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncan.Location = new System.Drawing.Point(154, 147);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(84, 23);
            this.btncan.TabIndex = 14;
            this.btncan.Text = "CANCEL";
            this.btncan.UseVisualStyleBackColor = true;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(44, 147);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 13;
            this.btnsub.Text = "SUBMIT";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // taskmodpanel
            // 
            this.taskmodpanel.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.taskmodpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.taskmodpanel.Controls.Add(this.btnmodcan);
            this.taskmodpanel.Controls.Add(this.btnmodsub);
            this.taskmodpanel.Controls.Add(this.txtmoddur);
            this.taskmodpanel.Controls.Add(this.lblmoddur);
            this.taskmodpanel.Controls.Add(this.txtmodtaskname);
            this.taskmodpanel.Controls.Add(this.lblseltname);
            this.taskmodpanel.Controls.Add(this.cmptask);
            this.taskmodpanel.Controls.Add(this.lblseltask);
            this.taskmodpanel.Controls.Add(this.lbltaskmod);
            this.taskmodpanel.Location = new System.Drawing.Point(419, 236);
            this.taskmodpanel.Name = "taskmodpanel";
            this.taskmodpanel.Size = new System.Drawing.Size(352, 229);
            this.taskmodpanel.TabIndex = 2;
            // 
            // lbltaskmod
            // 
            this.lbltaskmod.AutoSize = true;
            this.lbltaskmod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaskmod.Location = new System.Drawing.Point(100, 22);
            this.lbltaskmod.Name = "lbltaskmod";
            this.lbltaskmod.Size = new System.Drawing.Size(163, 18);
            this.lbltaskmod.TabIndex = 2;
            this.lbltaskmod.Text = "TASK MODIFICATION";
            // 
            // cmptask
            // 
            this.cmptask.FormattingEnabled = true;
            this.cmptask.Location = new System.Drawing.Point(196, 63);
            this.cmptask.Name = "cmptask";
            this.cmptask.Size = new System.Drawing.Size(126, 21);
            this.cmptask.TabIndex = 27;
            this.cmptask.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmptask_KeyDown);
            // 
            // lblseltask
            // 
            this.lblseltask.AutoSize = true;
            this.lblseltask.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseltask.Location = new System.Drawing.Point(16, 65);
            this.lblseltask.Name = "lblseltask";
            this.lblseltask.Size = new System.Drawing.Size(150, 17);
            this.lblseltask.TabIndex = 26;
            this.lblseltask.Text = "SELECT YOUR TASK";
            // 
            // btnmodcan
            // 
            this.btnmodcan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodcan.Location = new System.Drawing.Point(196, 185);
            this.btnmodcan.Name = "btnmodcan";
            this.btnmodcan.Size = new System.Drawing.Size(84, 23);
            this.btnmodcan.TabIndex = 33;
            this.btnmodcan.Text = "CANCEL";
            this.btnmodcan.UseVisualStyleBackColor = true;
            this.btnmodcan.Click += new System.EventHandler(this.btnmodcan_Click);
            // 
            // btnmodsub
            // 
            this.btnmodsub.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodsub.Location = new System.Drawing.Point(91, 185);
            this.btnmodsub.Name = "btnmodsub";
            this.btnmodsub.Size = new System.Drawing.Size(75, 23);
            this.btnmodsub.TabIndex = 32;
            this.btnmodsub.Text = "SUBMIT";
            this.btnmodsub.UseVisualStyleBackColor = true;
            this.btnmodsub.Click += new System.EventHandler(this.btnmodsub_Click);
            // 
            // txtmoddur
            // 
            this.txtmoddur.Location = new System.Drawing.Point(196, 139);
            this.txtmoddur.Name = "txtmoddur";
            this.txtmoddur.Size = new System.Drawing.Size(126, 20);
            this.txtmoddur.TabIndex = 31;
            this.txtmoddur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmoddur_KeyDown);
            // 
            // lblmoddur
            // 
            this.lblmoddur.AutoSize = true;
            this.lblmoddur.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoddur.Location = new System.Drawing.Point(16, 142);
            this.lblmoddur.Name = "lblmoddur";
            this.lblmoddur.Size = new System.Drawing.Size(85, 17);
            this.lblmoddur.TabIndex = 30;
            this.lblmoddur.Text = "DURATION";
            // 
            // txtmodtaskname
            // 
            this.txtmodtaskname.Location = new System.Drawing.Point(196, 104);
            this.txtmodtaskname.Name = "txtmodtaskname";
            this.txtmodtaskname.Size = new System.Drawing.Size(126, 20);
            this.txtmodtaskname.TabIndex = 29;
            this.txtmodtaskname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmodtaskname_KeyDown);
            // 
            // lblseltname
            // 
            this.lblseltname.AutoSize = true;
            this.lblseltname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseltname.Location = new System.Drawing.Point(16, 105);
            this.lblseltname.Name = "lblseltname";
            this.lblseltname.Size = new System.Drawing.Size(94, 17);
            this.lblseltname.TabIndex = 28;
            this.lblseltname.Text = "TASK NAME";
            // 
            // Task
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Masterpagedesign.Properties.Resources.log11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 486);
            this.Controls.Add(this.taskmodpanel);
            this.Controls.Add(this.taskentrypanel);
            this.Controls.Add(this.Taskviewpanel);
            this.Name = "Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Task_Load);
            this.Taskviewpanel.ResumeLayout(false);
            this.Taskviewpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvtask.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvtask)).EndInit();
            this.taskentrypanel.ResumeLayout(false);
            this.taskentrypanel.PerformLayout();
            this.taskmodpanel.ResumeLayout(false);
            this.taskmodpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Taskviewpanel;
        private Telerik.WinControls.UI.RadGridView rgvtask;
        private System.Windows.Forms.Label lbltask;
        private System.Windows.Forms.Panel taskentrypanel;
        private System.Windows.Forms.Label lbltasken;
        private System.Windows.Forms.TextBox txtdur;
        private System.Windows.Forms.Label lbldur;
        private System.Windows.Forms.TextBox txttaskname;
        private System.Windows.Forms.Label lbltaskname;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Panel taskmodpanel;
        private System.Windows.Forms.Label lbltaskmod;
        private System.Windows.Forms.Button btnmodcan;
        private System.Windows.Forms.Button btnmodsub;
        private System.Windows.Forms.TextBox txtmoddur;
        private System.Windows.Forms.Label lblmoddur;
        private System.Windows.Forms.TextBox txtmodtaskname;
        private System.Windows.Forms.Label lblseltname;
        private System.Windows.Forms.ComboBox cmptask;
        private System.Windows.Forms.Label lblseltask;
    }
}