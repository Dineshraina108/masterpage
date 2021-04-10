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
    public partial class Mainmaster : Form
    {
        private int childFormNumber = 0;
        public string username,menuname;
        package pack = new package();
        private int xpos = 0, ypos = 0, x1pos = 0, y1pos=0;
        private int h = 530, h1=260;
        public string mode = "Top to bottom";
        public Mainmaster(string user)
        {
            InitializeComponent();
            loginmenu.Text = user;
            username = user;
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void queriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback fb = new Masterpagedesign.Feedback(username);
            fb.Show();
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void maspanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuname = "Viewing project";
            Project pro = new Masterpagedesign.Project(menuname);
            pro.Show();
        }
        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuname = "Modify project";
            Project pro = new Masterpagedesign.Project(menuname);
            pro.Show();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuname = "New project";
            Project pro = new Masterpagedesign.Project(menuname);
            pro.Show();
        }
        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuname = "View Task";
            Task tk = new Masterpagedesign.Task(menuname);
            tk.Show();
        }
        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuname = "Modify Task";
            Task tk = new Masterpagedesign.Task(menuname);
            tk.Show();
        }
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuname = "New Task";
            Task tk = new Masterpagedesign.Task(menuname);
            tk.Show();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void scrolltimer_Tick(object sender, EventArgs e)
        {
            if(h ==ypos  )
            {
                this.lblproject.Location = new System.Drawing.Point(xpos,430 );
                ypos = lblproject.Location.Y;
                //scrolltimer.Stop();
            }
            else
            {
                this.lblproject.Location = new System.Drawing.Point(xpos, ypos);
                ypos += 2;
            }
           if (h1 == y1pos)
            {
                this.lblgar.Location = new System.Drawing.Point(x1pos, 158);
                y1pos = lblgar.Location.Y;
            }
            else
            {          
                this.lblgar.Location = new System.Drawing.Point(x1pos, y1pos);
                y1pos += 2;

            }
        }
        private void Mainmaster_Load(object sender, EventArgs e)
        {
            // Login log = new Masterpagedesign.Login();
            // log.MdiParent = this;
            //  log.Show();
            xpos = lblproject.Location.X;
            ypos = lblproject.Location.Y;
            proscrollbar.Hide();
            //scrolltimer.Start();
            x1pos = lblgar .Location.X;
            y1pos = lblgar.Location.Y;
            scrolltimer.Start();
            if (username == "Admin")
            {
                projectsToolStripMenuItem.Visible = true;
                newToolStripMenuItem1.Visible = true;
                modifyToolStripMenuItem1.Visible = true;
            }          
            else
            {
                projectsToolStripMenuItem.Visible = false;
                newToolStripMenuItem1.Visible = false;
                modifyToolStripMenuItem1.Visible = false;
            }         
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userdata us = new Userdata(username);
            us.Show();
        }
    }
}
