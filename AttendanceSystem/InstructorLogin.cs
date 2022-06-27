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
    public partial class InstructorLogin : Form
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
        public InstructorLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmLogin ulog = new frmLogin();
            ulog.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit the Application?", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe; convert zero datetime=True");
            //MySqlDataReader dr;
            MySqlCommand cmd = new MySqlCommand();

            Con.Open();
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin")
            {
                this.Hide();
                MainMenu obj = new MainMenu();
                obj.ShowDialog();
            }
            if (txtUsername.Text != string.Empty || txtPassword.Text != string.Empty)
            {

                cmd = new MySqlCommand("select * from TeacherTbl where TUsername='" + txtUsername.Text + "' and TPassword='" + SecureData.EncryptData(txtPassword.Text.Trim()) + "'and Status ='" + "Enabled" + "'", Con);
                DataTable dtUser = new DataTable();
                MySqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    dtUser.Load(sdr);
                    DataRow userRow = dtUser.Rows[0];

                    LoggedInUser.Tname = userRow["Tname"].ToString();
                    LoggedInUser.TId = userRow["TId"].ToString();
                    LoggedInUser.TGen = userRow["TGen"].ToString();
                    LoggedInUser.TAdd = userRow["TAdd"].ToString();
                    LoggedInUser.TSub = userRow["TSub"].ToString();
                    LoggedInUser.TPhone = userRow["TPhone"].ToString();
                    LoggedInUser.TUsername = userRow["TUsername"].ToString();
                    LoggedInUser.TDOB = Convert.ToDateTime(userRow["TDOB"]);
                    //LoggedInUser.TPassword = userRow["TPassword"].ToString();
                    //LoggedInUser.TQuestion = userRow["TQuestion"].ToString();
                    //LoggedInUser.TQuestiontwo = userRow["TQuestiontwo"].ToString();
                    //LoggedInUser.TQuestionthree = userRow["TQuestionthree"].ToString();

                    this.Hide();

                    InsForm userf = new InsForm();
                    userf.ShowDialog();
                }

                else
                {
                    sdr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            InsSecurityQ insq = new InsSecurityQ();
            insq.Show();
            this.Hide();
        }
    }
}
