using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace AttendanceSystem
{
    public partial class MainMenu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );
        public MainMenu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Trainee Obj = new Trainee();
            Obj.Show();
            this.Hide();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            frmLogin Obj = new frmLogin();
            Obj.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            panels1.Visible = true;
            Dashboard ds = new Dashboard();
            ds.TopLevel = false;
            ds.AutoScroll = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(ds);
            ds.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Trainee stu = new Trainee();
            stu.TopLevel = false;
            stu.AutoScroll = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(stu);
            stu.Show();

            panels1.Visible = false;
            panels2.Visible = true;
            paneladd.Visible = false;
            panelt.Visible = false;
            panels3.Visible = false;
            panels4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instructors ins = new Instructors();
            ins.TopLevel = false;
            ins.AutoScroll = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(ins);
            ins.Show();

            panels1.Visible = false;
            panels2.Visible = false;
            paneladd.Visible = false;
            panelt.Visible = false;
            panels3.Visible = true;
            panels4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Attendances att = new Attendances();
            att.TopLevel = false;
            att.AutoScroll = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(att);
            att.Show();

            panels1.Visible = false;
            panels2.Visible = false;
            paneladd.Visible = false;
            panelt.Visible = false;
            panels3.Visible = false;
            panels4.Visible = true;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmLogin Obj = new frmLogin();
                Obj.Show();
                this.Hide();
            }
            else
            {
                this.Activate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.TopLevel = false;
            ds.AutoScroll = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(ds);
            ds.Show();

            panels1.Visible = true;
            panels2.Visible = false;
            paneladd.Visible = false;
            panels3.Visible = false;
            panels4.Visible = false;
            panelt.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegisterUser ds = new RegisterUser();
            ds.TopLevel = false;
            ds.AutoScroll = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(ds);
            ds.Show();

            panels1.Visible = false;
            paneladd.Visible = true;
            panels2.Visible = false;
            panels3.Visible = false;
            panels4.Visible = false;
            panelt.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddInstructor ds = new AddInstructor();
            ds.TopLevel = false;
            ds.AutoScroll = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(ds);
            ds.Show();

            panels1.Visible = false;
            panels2.Visible = false;
            paneladd.Visible = false;
            panels3.Visible = false;
            panels4.Visible = false;
            panelt.Visible = true;
        }
    }
}
