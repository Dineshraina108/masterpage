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
    public partial class Project : Form
    {
        string mname,prname,stdt,endt,prlan;
        int prid;
        package pack = new package();
        public Project(string menuname)
        {
            InitializeComponent();
            mname = menuname;
        }        
        private void Project_Load(object sender, EventArgs e)
        {
            DataTable dt = pack.GetTable();
            DataTable pro= pack.Getpro();
            if (mname == "New project")
            {
                this.proinspanel.Visible = true;
                this.proviewpanel.Visible = false;
                this.promodpanel.Visible = false;
                this.cmblan.DataSource = dt;
                this.cmblan.DisplayMember = "lan";
                this.cmblan.ValueMember = "lid";
                this.Width = proinspanel.Width;
                this.Height = proinspanel.Height;
                this.Update();          
            }
            else if(mname == "Viewing project")
            {
                this.proviewpanel.Visible = true;
                this.proinspanel.Visible = false;
                this.promodpanel.Visible = false;
                this.Width = proviewpanel.Width;
                this.Height = proviewpanel.Height;
                proviewpanel.Location = proinspanel.Location;
                Rgvpro.DataSource = pack.projectsel();
                this.Update();
            }            
            else
            {
                this.proinspanel.Visible = false;
                this.proviewpanel.Visible = false;
                this.promodpanel.Visible = true;
                this.cmblang.DataSource = dt;
                this.cmblang.DisplayMember = "lan";
                this.cmblang.ValueMember = "lid";
                this.cmppro.DataSource = pro;
                this.cmppro.DisplayMember = "PRJNAME";
                this.cmppro.ValueMember = "PRJID";
                this.Width = promodpanel.Width;
                this.Height = promodpanel.Height;
                promodpanel.Location = proinspanel.Location;      
                this.Update();
            }
        }     
        #region key down actions
        private void txtproname_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter )
            {
                if (txtproname.Text != "")
                    cmblan.Focus();
                else 
                    MessageBox .Show ("PLease enter project name");
            }
        }
        private void cmblan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmblan.Text != "")
                    dtpst.Focus();
                else
                    MessageBox.Show("Please enter choose language");
            }
        }
        private void dtpst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (dtpst.Text != "")
                dtpendate.Focus();
                // else
                //     MessageBox.Show("Please enter choose language");
            }
        }
        private void dtpendate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsub.Focus();
            }
        }
        private void cmppro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = new DataTable();
                dt = pack.projectmod(Convert.ToInt32(cmppro.SelectedValue));
                try
                {
                    txtpname.Text = dt.Rows[0]["PRJNAME"].ToString();
                    txtpname.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no records"+ ex.ToString());
                }
            }
        }
        private void txtpname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtpname.Text != "")
                    cmblang.Focus();
                else
                    MessageBox.Show("PLease enter project name");
            }
        }
        private void cmblang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpen.Focus();
            }
        }
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsubmit.Focus();
            }
        }    
        #endregion
        #region button actions
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btncan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnsub_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pack.proid();
            try
            {
                if (dt.Rows[0]["MAX(PRJID)"].ToString() != "")
                    prid = Convert.ToInt32(dt.Rows[0]["MAX(PRJID)"].ToString()) + 1;
                else
                    prid = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //proinspanel.Dispose();
            prname = txtproname.Text;
            prlan = cmblan.Text;        
            stdt = Convert.ToString(dtpst.Value.Date.ToString("dd/MM/yyyy"));
            endt = Convert.ToString(dtpendate.Value.Date.ToString("dd/MM/yyyy"));
            pack.Projectins(prid,prname,prlan,stdt,endt);
            this.Close();
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            prid = Convert.ToInt32(cmppro.SelectedValue);
            prname = txtpname.Text;
            prlan = cmblang.Text;
            endt = Convert.ToString(dtpen.Value.Date.ToString("dd/MM/yyyy"));
            pack.projectupdate(prid, prname, prlan, endt);
            this.Close();
        }
        #endregion
    }
}
