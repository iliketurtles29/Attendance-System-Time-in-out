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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
            timer1.Start();
            petsa.Text = DateTime.Now.ToLongDateString();
            Timelb.Text = DateTime.Now.ToLongTimeString();
        }

        private void GetStudName()
        {
            StNameTb.Text = LoggedInUser.StName;
            StGenCb.SelectedItem = LoggedInUser.StGen;
            DOBPicker.Text = LoggedInUser.StDOB.ToString();
            ClassCB.SelectedItem = LoggedInUser.StClass.ToString();
            AddressTb.Text = LoggedInUser.StAdd.ToString();
            txtUsername.Text = LoggedInUser.StUsername.ToString();
            //txtPassword.Text = LoggedInUser.StPassword.ToString();
            //AnswerTb.Text = LoggedInUser.StQuestion.ToString();
            //AnswerTb2.Text = LoggedInUser.StQuestiontwo.ToString();
            //AnswerTb3.Text = LoggedInUser.StQuestionthree.ToString();
        }

        MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe");

        private void UserProfile_Load(object sender, EventArgs e)
        {
            GetStudName();
            petsa.Text = DateTime.Now.ToLongDateString();
            Timelb.Text = DateTime.Now.ToShortTimeString();
        }
        public void Reset()
        {
            this.txtUsername.Refresh();
            this.AddressTb.Refresh();
            this.DOBPicker.Refresh();
            this.ClassCB.Refresh();
        }
        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.TextLength <= 10)
            {
                MessageBox.Show("Make a Strong Password", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "" || txtComPass.Text == "")
            {
                MessageBox.Show("Input Password", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtComPass.Text)
            {
                MessageBox.Show("Pasword do not Match", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AnswerTb.Text == "" && AnswerTb2.Text == "" && AnswerTb3.Text == "")
            {
                MessageBox.Show("Security Question required, Old or New", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPass.Text && AnswerTb.Text != "" && AnswerTb2.Text != "" && AnswerTb3.Text != "")
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("update StudentTbl set StName=@SName,StGen=@SGen,StDOB=@SDob,StClass=@SClass,StAdd=@SAdd,StUsername=@SUser,StPassword=@SPass,StQuestion=@SQues,StQuestiontwo=@SQuesp,StQuestionthree=@SQuest where StId=@SID", Con);
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
                    cmd.Parameters.AddWithValue("@SID", LoggedInUser.StId);
                    cmd.ExecuteNonQuery();
                    Reset();
                    MessageBox.Show("Profile Updated");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timelb.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
