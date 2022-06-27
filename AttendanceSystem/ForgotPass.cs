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
    public partial class ForgotPass : Form
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
        public ForgotPass()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }
        //MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe; convert zero datetime=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe; convert zero datetime=True");
           
            MySqlDataReader dr;
            MySqlCommand cmd = new MySqlCommand();
          
            if (txtPassword.Text == "" || txtCompassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            if (txtPassword.TextLength <= 10)
            {
                MessageBox.Show("Make a Strong Password", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtPassword.Text == txtCompassword.Text && txtPassword.Text.Length > 9)
            {
                 try
                 {
                    Con.Open();
                    cmd = new MySqlCommand("Update StudentTbl set StPassword= '" + SecureData.EncryptData(txtPassword.Text.Trim()) + "' where StUsername = '" + LoggedInUser.StUsername + "'", Con);
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Password Updated");
                    this.Hide();
                    frmLogin obj = new frmLogin();
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

        private void label6_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }
    }
}
