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
    public partial class InsSecurityQ : Form
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
        public InsSecurityQ()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe; convert zero datetime=True");
            MySqlDataReader dr;
            MySqlCommand cmd = new MySqlCommand();

            Con.Open();
            if (txtUsername.Text != string.Empty || AnswerTb.Text != string.Empty || AnswerTb2.Text != string.Empty || Answertb3.Text != string.Empty || Answertb3.Text != string.Empty)
            {
                cmd = new MySqlCommand("select * from TeacherTbl where TUsername='" + txtUsername.Text + "' and TQuestion='" + SecureData.EncryptData(AnswerTb.Text.Trim()) + "'and TQuestiontwo='" + SecureData.EncryptData(AnswerTb2.Text.Trim()) + "'and TQuestionthree= '" + SecureData.EncryptData(Answertb3.Text.Trim()) + "'", Con);
                dr = cmd.ExecuteReader();
                LoggedInUser.TUsername = txtUsername.Text;
                DataTable dtUser = new DataTable();

                if (dr.HasRows)
                {
                    dr.Close();
                    dtUser.Load(dr);
                    this.Hide();

                    InsForgotPass obj = new InsForgotPass();
                    obj.Show();
                    this.Hide();
                }

                else if (txtUsername.Text == "" || AnswerTb.Text == "" || AnswerTb2.Text == "" || Answertb3.Text == "")
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Answers Incorrect ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                InstructorLogin obj = new InstructorLogin();
                obj.Show();
                this.Hide();
            }
        }
    }
}
