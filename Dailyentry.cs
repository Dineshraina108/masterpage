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
    public partial class Dailyentry : Form
    {
        package pack = new package();
        string username,uname;
        int usid;
        string wdate,pro,lan,scre,action;
        DataTable dtusid = new DataTable();
        DataTable dtuser = new DataTable();
        DataTable dtpro = new DataTable();
        public Dailyentry(string user)
        {
            InitializeComponent();
            username = user;
        }
        private void Dailyentry_Load(object sender, EventArgs e)
        {
            DataTable dttech = pack.GetTable();
            dtuser = pack.Getname(username);
            dtpro = pack.Getpro();
            try
            {
                if (dtuser.Rows .Count > 0)
                {
                    uname = dtuser.Rows[0]["UNAME"].ToString();
                    this.txtuser.Text = uname;
                    dtusid = pack.usid(uname);
                    usid = Convert.ToInt32(dtusid.Rows[0]["USID"].ToString());
                }
                else
                {
                    MessageBox.Show("USER CAN NOT LOGIN");
                }
                DateTime date = DateTime.Now.Date;
                txtdate.Text = Convert.ToString(date.ToString("dd/MM/yyyy"));
                if (dtpro.Rows.Count > 0)
                {
                    this.cmpproj.DataSource = dtpro;
                    this.cmpproj.DisplayMember = "PRJNAME";
                    this.cmpproj.ValueMember = "PRJID";
                }
                else
                {
                    MessageBox.Show("NO PROJECT AVAILABLE");
                }
                if (dttech.Rows.Count > 0)
                {
                    this.cmbtech.DataSource = dttech;
                    this.cmbtech.DisplayMember = "lan";
                    this.cmbtech.ValueMember = "lid";
                }
                else
                {
                    MessageBox.Show("NO TECHNOLOGY AVAILABLE");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
            // this.Location = dailypanel.Location;
            this.cmpproj.Focus();
            this.Update();
        }
        #region key down actions
        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtuser.Text != "")
                    txtdate.Focus();
                else
                    Console.WriteLine("Username required");
            }
        }
        private void txtdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtdate.Text != "")
                    cmpproj .Focus();
                else
                    Console.WriteLine("Date required");
            }
        } 
        private void cmpproj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                    cmbtech.Focus();    
        }
        private void cmbtech_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtscname.Focus();
        }
        private void txtscname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtscname.Text != "")
                    txtaction.Focus();
                else
                    Console.WriteLine("Screen name required");
            }
        }
        private void txtaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtaction.Text != "")
                    btnsub.Focus();
                else
                    Console.WriteLine("task action  required");
            }
        }
        #endregion
        #region button actions
        private void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                wdate = txtdate.Text;
                pro = cmpproj.Text;
                lan = cmbtech.Text;
                scre = txtscname.Text;
                action = txtaction.Text;
                pack.dailyactins(usid, uname, wdate, pro, lan, scre, action);
                pack.RunOracleTransaction();
                this.Close();
              
                    
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString ()); }
        }
        private void btncan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
