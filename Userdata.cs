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
    public partial class Userdata : Form
    {
        package pack = new package();
        int id, cid;
        string pos, proc, dept,mname;
        DataTable usdt = new DataTable();
        public Userdata(string user,string menuname)
        {
            InitializeComponent();
            txtname.Text = user;
            mname = menuname;
        }
        private void Userdata_Load(object sender, EventArgs e)
        {
            if(mname == "profile")
            {
                DataTable dt = new DataTable();
                DataTable uname = new DataTable();
                this.profileviewpanel.Visible = true;
                this.profileinspanel.Visible = false;
                try
                {
                    uname = pack.Getname(txtname.Text);
                    usdt = pack.usid(uname.Rows[0]["UNAME"].ToString());
                    id = Convert.ToInt32(usdt.Rows[0]["USID"].ToString());
                    dt = pack.profiledata(id);
                    txtusid.Text = dt.Rows[0]["USID"].ToString();
                    txtuname.Text = dt.Rows[0]["UNAME"].ToString();
                    txtdob.Text = dt.Rows[0]["DOB"].ToString();
                    txtcarrid.Text = dt.Rows[0]["CAREERID"].ToString();
                    txtcrdate.Text = dt.Rows[0]["CRDATE"].ToString();
                    txtposi.Text = dt.Rows[0]["POSITION"].ToString();
                    txtproc.Text = dt.Rows[0]["PROCESS"].ToString();
                    txtdeptm.Text = dt.Rows[0]["DEPT"].ToString();
                    txtgen.Text = dt.Rows[0]["GENDER"].ToString();
                    txtmobno.Text = dt.Rows[0]["MOBILENO"].ToString();
                    txtemail.Text = dt.Rows[0]["EMAILID"].ToString();
                    txtaddr.Text = dt.Rows[0]["ADDRESS"].ToString();
                    profileviewpanel.Location = profileinspanel.Location;
                    this.Width = profileviewpanel.Width;
                    this. Height = profileviewpanel.Height;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                profileviewpanel.Update();
            }
            else
            {
                this.profileviewpanel.Visible = false;
                this.profileinspanel.Visible = true;
                usdt = pack.Getname(txtname.Text);
                txtname.Text = usdt.Rows[0].Field<string>("UNAME");
            }       
        }
        #region KEY DOWN FUNCTIONS
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter )
            {
                if(txtname .Text !="")
                {
                    txtcarid.Focus();
                }
                else
                {
                    MessageBox.Show("INVALID NAME");
                }
            }
        }
        private void txtcarid_ImeModeChanged(object sender, EventArgs e)
        {

        }
        private void txtcarid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtcarid.Text != "")
                {
                   txtpos.Focus();
                }
                else
                {
                    MessageBox.Show("INVALID CARRIER ID");
                }
            }
        }
        private void txtpos_Enter(object sender, EventArgs e)
        {      
        }
        private void txtpos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtpos.Text != "")
                {
                    txtprocess .Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter your position");
                }
            }
        }
        private void txtprocess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtprocess.Text != "")
                {
                    txtdept.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter your process");
                }
            }
        }
        private void txtdept_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtprocess.Text != "")
                {
                   btnsub.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter your Department");
                }
            }
        }
        #endregion
        #region BUTTON CLICK FUNCTIONS
        private void btncan_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
        private void btnsub_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtcarid.Text != "" && txtpos.Text != "" && txtprocess.Text != "" && txtdept.Text != "")
            {
                usdt = pack.usid(txtname.Text);
                id = Convert.ToInt32(usdt.Rows[0]["USID"].ToString());
                cid = Convert.ToInt32(txtcarid.Text);
                pos = txtpos.Text;
                proc = txtprocess.Text;
                dept = txtdept.Text;
                pack.profileinsert(id, cid, dept, proc, pos);
                this.Close();
            }
            else
                MessageBox.Show("Please Enter all details");
        }
        #endregion
        //Date	Application	Technology	Resource	Screen/Report Name	Task
    }
}
