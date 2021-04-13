using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Masterpagedesign
{
    public partial class Register : Form
    {
        internal string btnname;
        string name, usname, pass, repass, dob, gen, mobno, email, address, role;
        DataTable dt = new DataTable();
        int uid;
        package  pack = new package();
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            if (btnname == "Forget Password")
            {
                lbltitle.Text = "FORGET PASSWORD";
                forgetpanel.Visible = true;
                Regmainpanel.Visible = false;
                btnsignup.Text = "RESET";
                forgetpanel.Location = Regmainpanel.Location;
                forgetpanel.Width = Regmainpanel.Width;
                regpanel.Width = forgetpanel.Width;
                regpanel.Height = forgetpanel.Height;
                this.Width = regpanel.Width;
                this.Height = regpanel.Height;
                regpanel.Update();
                this.Update();
            }
            if (btnname == "Signup")
            {
                forgetpanel.Visible = false;
                Regmainpanel.Visible = true;
                regpanel.Width = Regmainpanel.Width;
                regpanel.Height = Regmainpanel.Height;
                this.Width = regpanel.Width;
                this.Height = regpanel.Height;
                regpanel.Update();
                this.Update();
            }
        }
        #region KEY DOWN FUNCTIONS
        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            Regex name = new Regex("^[A-Z][a-zA-Z]*$");
            if (e.KeyCode == Keys.Enter)
            {
                if (txtname.Text != "")
                {
                    if (name.IsMatch(txtname.Text))
                    {
                        dtbdob.Focus();
                    }
                    else
                    {
                        Console.WriteLine("INVALID NAME");
                        txtname.Focus();
                    }
                }
                else
                {
                    Console.WriteLine(" NAME CANNOT BE EMPTY");
                    txtname.Focus();
                }
            }

        }
        private void dtbdob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbgen.Focus();
        }
        private void cmbgen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmobno.Focus();
            }
        }
        private void txtmobno_KeyDown(object sender, KeyEventArgs e)
        {
            Regex Mno = new Regex(@"^[6-9]\d{9}$");
            if (e.KeyCode == Keys.Enter)
            {
                if (txtmobno.Text != "")
                {
                    if (Mno.IsMatch(txtmobno.Text))
                    {
                        txtemail.Focus();
                    }
                    else
                    {
                        Console.WriteLine("INVALID MOBILE NUMBER");
                        txtmobno.Focus();
                    }
                }
                else
                {
                    Console.WriteLine(" MOBILE NUMBER CANNOT BE EMPTY");
                    txtmobno.Focus();
                }
            }
        }
        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            Regex emailformat = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (e.KeyCode == Keys.Enter)
            {
                if (txtemail.Text != "")
                {
                    if (emailformat.IsMatch(txtemail.Text))
                        rtxtaddr.Focus();
                    else
                    {
                        Console.WriteLine("INVALID EMAIL ID");
                        txtemail.Focus();
                    }
                }
                else
                {
                    Console.WriteLine("EMAIL ID CANNOT BE EMPTY");
                    txtemail.Focus();
                }
            }
        }
        private void rtxtaddr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rtxtaddr.Text != "")
                    rbyes.Focus();
                else
                {
                    Console.WriteLine("ADDRESS CANNOT BE EMPTY");
                    rtxtaddr.Focus();
                }
            }
        }
        private void rbyes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rbyes.Checked == true)
                {
                    rbno.Checked = false;
                    btnreg.Focus();
                }
            }
        }
        private void rbno_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }
        private void rbno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rbno.Checked == true)
                {
                    rbyes.Checked = false;
                    btnreg.Focus();
                }
            }
        }
        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable dt = new DataTable();
            if (e.KeyCode == Keys.Enter)
            {
                if (txtuser.Text != "")
                {
                    if (lbltitle.Text == "Forget Password")
                    { 
                        dt = pack.priv(txtuser.Text);
                    try
                    {
                        if (dt.Rows.Count > 0)
                        {
                            txtpass.Focus();
                        }
                        else
                        {
                            Console.WriteLine("INVALID USER");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("INVALID USER" + ex.ToString());
                    }
                }
                else
                {
                    txtpass.Focus();
                }        
                }
                else
                {
                    Console.WriteLine("USERNAME NOT EMPTY");
                    txtuser.Focus();
                }
            }
        }
        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            Regex pass = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,12}$");
            if (e.KeyCode == Keys.Enter)
            {
                if (txtpass.Text != "")
                {
                    if (pass.IsMatch(txtpass.Text))
                    {
                        txtrepass.Focus();
                    }
                    else
                    {
                        Console.WriteLine("PASSWORD NOT STRONG");
                        txtpass.Focus();
                    }
                }
                else
                {
                    Console.WriteLine("PASWWORD NOT EMPTY");
                    txtpass.Focus();
                }
            }
        }
        private void txtrepass_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (txtrepass.Text != "")
                {
                    if (txtpass.Text == txtrepass.Text)
                        btnsignup.Focus();
                    else
                    {
                        Console.WriteLine(" PASWORD AND REPASSWORD NOT MATCH");
                        txtpass.Text = "";
                        txtrepass.Text = "";
                        txtpass.Focus();
                    }
                }
                else
                {
                    Console.WriteLine("REPASSWORD NOT EMPTY");
                    txtrepass.Focus();
                }
            }
        }
        #endregion
        #region BUTTON CLICK FUNCTIONS
        private void btnreg_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && cmbgen.Text != "" && txtmobno.Text != "" && txtemail.Text != "" && rtxtaddr.Text != "")
            {
                name = txtname.Text;
                dob = dtbdob.Value.ToString("dd/MM/yyyy");
                gen = cmbgen.Text;
                mobno = txtmobno.Text;
                email = txtemail.Text;
                address = rtxtaddr.Text;
                if (rbyes.Checked == true)
                {
                    role = "Y";
                }
                else
                {
                    role = "N";
                }
                dt = pack.sel();
                if (dt.Rows.Count != 0)
                {
                    uid = dt.Rows.Count + 1;
                }
                else
                {
                    uid =1;
                }
                forgetpanel.Visible = true;
                Regmainpanel.Visible = false;
                forgetpanel.Location = Regmainpanel.Location;
                forgetpanel.Width = Regmainpanel.Width;
                regpanel.Width = forgetpanel.Width;
                regpanel.Height = forgetpanel.Height;
                this.Width = regpanel.Width;
                this.Height = regpanel.Height;
                regpanel.Update();
                this.Update();
            }
            else
            {
                MessageBox.Show("Please Enter all fields");
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }
        private void llblallogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();
        }
        private void llblalacc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();
        }
        private void btnsignup_Click(object sender, EventArgs e)
        {
            usname = txtuser.Text;
            pass = txtpass.Text;
            repass = txtrepass.Text;
            if (txtuser.Text != "" && txtpass.Text != "" && txtrepass.Text != "")
            {
                if (btnname == "Forget Password")
                {
                    pack.passupdate(usname, pass, repass);
                    Login log = new Login();
                    this.Close();
                    log.Show();
                }
                else
                {
                    pack.userinsert(uid, name, usname, pass, repass, dob, gen, mobno, email, address, role);
                    Userdata us = new Userdata(usname,"Register");
                    this.Close();
                    us.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Please Enter all fields");
            }

        }
        private void btnfcan_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
        }
        #endregion
    }
}
