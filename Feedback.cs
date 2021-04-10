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
    public partial class Feedback : Form
    {
        int feid,uid;
        string uname, pos, dept, proc, descr,username;
        package pack = new package();
        DataTable data= new DataTable();
        DataTable usdetails = new DataTable();
        DataTable usname = new DataTable();
        public Feedback(string user)
        {
            InitializeComponent();
            username = user;
        }
        private void btncan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Feedback_Load(object sender, EventArgs e)
        {
            usname = pack.Getname(username);          
            try
            {
                if (usname.Rows[0]["UNAME"].ToString() != "")
                    txtname.Text = usname.Rows[0]["UNAME"].ToString();
                else
                    MessageBox.Show("invalid user");
                data = pack.usid(txtname.Text);
                if (Convert.ToInt32(data.Rows[0]["USID"].ToString()) != 0)
                    uid = Convert.ToInt32(data.Rows[0]["USID"].ToString());
                else
                    MessageBox.Show("Invaliud user");         
                
                usdetails = pack.profilesel(uid);
                if (usdetails.Rows.Count > 0)
                {
                    txtpos.Text = usdetails.Rows[0]["POSITION"].ToString();
                    txtprocess.Text = usdetails.Rows[0]["PROCESS"].ToString();
                    txtdept.Text = usdetails.Rows[0]["DEPT"].ToString();
                }
                else
                {
                    MessageBox.Show("NO RECORDS FGOUND");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
        private void btnsub_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = pack.Getfid();
                if (dt.Rows[0]["MAX(FID)"].ToString() != "")
                {
                    feid = Convert.ToInt32(dt.Rows[0]["MAX(FID)"].ToString()) + 1;
                }
                else
                {
                    feid = 1;
                }
                if (txtname.Text != "" && txtpos.Text != "" && txtdept.Text != "" && txtprocess.Text != "" && txtdes.Text != "")
                {
                    uname = txtname.Text;
                    pos = txtpos.Text;
                    dept = txtdept.Text;
                    proc = txtprocess.Text;
                    descr = txtdes.Text;
                    pack.feedbackins(feid, uname, pos, proc, dept, descr);
                    MessageBox.Show("Thank You for your valuable feedback");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("please flll all fields");
                    txtdes.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtname .Text != "")
                {
                    txtpos.Focus();
                }
                else
                {
                    MessageBox.Show("Provide name  ");
                }
            }
        }
        private void txtpos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtpos.Text != "")
                {
                    txtprocess.Focus();
                }
                else
                {
                    MessageBox.Show("Provide your position  ");
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
                    MessageBox.Show("Provide your process  ");
                }
            }
        }
        private void txtdept_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtdept.Text != "")
                {
                    txtdes.Focus();
                }
                else
                {
                    MessageBox.Show("Provide your feedback  ");
                }
            }
        }
        private void txtdes_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter)
            {
                if (txtdes.Text != "")
                {
                    btncan.Focus();
                }
                else
                {
                    MessageBox.Show("Provide your feedback  ");
                }
            }
        }
    }
}
