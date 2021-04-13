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
    public partial class Display : Form
    {
        package pack = new package();
        string username, uname;
        int usid;
        DataTable dtusid = new DataTable();
        DataTable dtuser = new DataTable();
        DataTable dtpro = new DataTable();
        public Display(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void Display_Load(object sender, EventArgs e)
        {
            dtuser = pack.Getname(username);
            dtpro = pack.Getpro();
            try
            {
                if (dtuser.Rows.Count > 0)
                {
                    uname = dtuser.Rows[0]["UNAME"].ToString();
                    dtusid = pack.usid(uname);
                    usid = Convert.ToInt32(dtusid.Rows[0]["USID"].ToString());
                }
                else
                {
                    MessageBox.Show("USER CAN NOT LOGIN");
                }
                if (dtpro.Rows.Count > 0)
                {
                    this.cmbpro .DataSource = dtpro;
                    this.cmbpro.DisplayMember = "PRJNAME";
                    this.cmbpro.ValueMember = "PRJID";
                }
                else
                {
                    MessageBox.Show("NO PROJECT AVAILABLE");
                }             
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }  
            this.Update();

        }

        private void cmbpro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter )
            {
                btnsub.Focus();
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string projectname = cmbpro.Text;
            dt = pack.dailyact(projectname);
            if(dt.Rows .Count > 0)
            {
                Rgvpro.DataSource = dt;
            }
            else
            {
                MessageBox.Show("NO DATA AVAILABLE FOR THIS PROJECT");
                Rgvpro.DataSource = dt;
            }
            tabviewbypro.Update();
            tabviewcon.Update();
            viewpanel.Update();
            this.Update();
        }
    }
}
