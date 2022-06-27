using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace AttendanceSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            CountStudent();
            CountTeachers();

            timer1.Start();
            label17.Text = DateTime.Now.ToLongDateString();
            label18.Text = DateTime.Now.ToLongTimeString();

            label5.Text = "as of " + DateTime.Now.ToLongDateString();
            label6.Text = "as of " + DateTime.Now.ToLongDateString();

        }
        MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe");

        private void CountStudent()
        {
            Con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select Count(*) from StudentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountTeachers()
        {
            Con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select Count(*) from TeacherTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label18.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            //label17.Text = DateTime.Now.ToLongDateString();
            //label18.Text = DateTime.Now.ToLongTimeString();
        }

        private void TLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
