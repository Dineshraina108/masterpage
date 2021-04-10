using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masterpagedesign
{
    public partial class Task : Form
    {
        package pack = new package();
        string mname;
        string taskname, taskdur;
        int taid;
        public Task(string menuname)
        {
            InitializeComponent();
            mname = menuname; 
        }
        private void Task_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                if (mname == "New Task")
                {
                    this.taskentrypanel.Visible = true;
                    this.Taskviewpanel.Visible = false;
                    this.taskmodpanel.Visible = false;
                    this.Width = this.Taskviewpanel.Width;
                    this .Height = this.Taskviewpanel.Height;
                    this.taskentrypanel.Location = this.Taskviewpanel.Location;
                    this.Update();           
                }
                else if (mname == "Modify Task")
                {
                    dt = pack.Gettask();
                    this.cmptask.DataSource = dt;
                    this.cmptask.DisplayMember = "TASKNAME";
                    this.cmptask.ValueMember = "TASKID";
                    this.taskentrypanel.Visible = false;
                    this.Taskviewpanel.Visible = false;
                    this.taskmodpanel.Visible = true;
                    this.Width = this.Taskviewpanel.Width;
                    this.Height = this.Taskviewpanel.Height;
                    this.taskmodpanel.Location = this.Taskviewpanel.Location;
                    this.Update();
                }
                else
                {
                    this.taskentrypanel.Visible = false;
                    this.Taskviewpanel.Visible = true;
                    this.taskmodpanel.Visible = false;
                    this.Width = this.Taskviewpanel.Width;
                    this.Height = this.Taskviewpanel.Height;
                    rgvtask.DataSource = pack.Gettaskdet();
                    this.Update();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }           
        }
        #region key down actions
        private void txttaskname_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                if (txttaskname.Text != "")
                    txtdur.Focus();
                else
                    MessageBox.Show("Please Enter task name");
            }
        }
        private void txtdur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtdur.Text != "")
                    btnsub.Focus();
                else
                    MessageBox.Show("Please Enter duaration");
            }
        }
        private void cmptask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                dt = pack.Gettask(Convert.ToInt32(cmptask.SelectedValue));
                try
                {
                    txtmodtaskname.Text = dt.Rows[0]["TASKNAME"].ToString();
                    txtmoddur.Text = dt.Rows[0]["DURATION"].ToString(); 
                    txtmodtaskname.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no records" + ex.ToString());
                }
            }
        }
        private void txtmodtaskname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtmodtaskname.Text != "")
                    txtmoddur.Focus();
                else
                    MessageBox.Show("Please Enter task name");
            }
        }
        private void txtmoddur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtmoddur.Text != "")
                    btnmodsub.Focus();
                else
                    MessageBox.Show("Please Enter duaration");
            }
        }
        #endregion
        #region button actions
        private void btnsub_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pack.taskid();
            try
            {
                if (dt.Rows[0]["MAX(TASKID)"].ToString() != "")
                    taid = Convert.ToInt32(dt.Rows[0]["MAX(TASKID)"].ToString()) + 1;
                else
                    taid = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            taskname = txttaskname.Text;
            taskdur = txtdur.Text;
            pack.Taskins(taid, taskname, taskdur);
            this.Close();
        }
        private void btncan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnmodsub_Click(object sender, EventArgs e)
        {
            taid = Convert.ToInt32(cmptask.SelectedValue);
            taskname = txtmodtaskname.Text;
            taskdur = txtmoddur.Text;
            pack.taskupdate(taid, taskname, taskdur);
            this.Close();
        }
        private void btnmodcan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
