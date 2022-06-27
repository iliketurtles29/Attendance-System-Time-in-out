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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
            timer1.Start();
            label17.Text = DateTime.Now.ToLongDateString();
            label18.Text = DateTime.Now.ToLongTimeString();
        }
        MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe; convert zero datetime=True");
        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            StNameTb.Text = "";
            AddressTb.Text = "";
            StGenCb.SelectedIndex = -1;
            ClassCB.SelectedIndex = -1;
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPass.Text = "";
            AnswerTb.Text = "";
            AnswerTb2.Text = "";
            AnswerTb3.Text = "";

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCB.SelectedIndex == -1 || txtUsername.Text == "" || txtPassword.Text == "" || txtComPass.Text == ""|| AnswerTb.Text == "" || AnswerTb2.Text == "" || AnswerTb3.Text == "")
            {
                MessageBox.Show("Missing Information", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.TextLength <= 10)
            {
                MessageBox.Show("Make a strong Password", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtComPass.Text)
            {
                MessageBox.Show("Pasword do not Match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPassword.Text == txtComPass.Text && AnswerTb.Text!= "" && AnswerTb2.Text != "" && AnswerTb3.Text != "")
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into StudentTbl(StName,StGen,StDOB,StClass,StAdd,StUsername,StPassword,StQuestion,StQuestiontwo,StQuestionthree,Status) values (@SName,@SGen,@SDob,@SClass,@SAdd,@SUser,@SPass,@SQues,@SQuesp,@SQuest,@Stat)", Con);
                    cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@SUser", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@SPass", SecureData.EncryptData(txtPassword.Text.Trim()));
                    cmd.Parameters.AddWithValue("@SQues", SecureData.EncryptData(AnswerTb.Text.Trim()));
                    cmd.Parameters.AddWithValue("@SQuesp", SecureData.EncryptData(AnswerTb2.Text.Trim()));
                    cmd.Parameters.AddWithValue("@SQuest", SecureData.EncryptData(AnswerTb3.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Stat", StatusCb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trainee Added Successful");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label18.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
