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
using System.Runtime.InteropServices;

namespace AttendanceSystem
{
    public partial class InsForgotPass : Form
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
        public InsForgotPass()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }

        private void label6_Click(object sender, EventArgs e)
        {
            InstructorLogin obj = new InstructorLogin();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe; convert zero datetime=True");

            MySqlDataReader dr;
            MySqlCommand cmd = new MySqlCommand();

            if (txtPassword.TextLength <= 9)
            {
                MessageBox.Show("Make a Strong Password", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "" || txtCompassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else if (txtPassword.Text == txtCompassword.Text && txtPassword.Text.Length > 9)
            {
                try
                {
                    Con.Open();
                    cmd = new MySqlCommand("Update TeacherTbl set TPassword= '" + SecureData.EncryptData(txtPassword.Text.Trim()) + "' where TUsername = '" + LoggedInUser.TUsername + "'", Con);
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Password Updated");
                    this.Hide();
                    InstructorLogin obj = new InstructorLogin();
                    obj.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (txtPassword.Text != txtCompassword.Text)
            {
                MessageBox.Show("Password doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
