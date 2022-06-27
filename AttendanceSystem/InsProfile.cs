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
    public partial class InsProfile : Form
    {
        public InsProfile()
        {
            InitializeComponent();
            GetInsName();
            timer1.Start();
            petsa.Text = DateTime.Now.ToLongDateString();
            Timelb.Text = DateTime.Now.ToLongTimeString();
        }
        private void GetInsName()
        {
            StNameTb.Text = LoggedInUser.Tname;
            StGenCb.SelectedItem = LoggedInUser.TGen;
            DOBPicker.Text = LoggedInUser.TDOB.ToString();
            ClassCB.SelectedItem = LoggedInUser.TSub.ToString();
            AddressTb.Text = LoggedInUser.TAdd.ToString();
            txtUsername.Text = LoggedInUser.TUsername.ToString();
            TPhoneTb.Text = LoggedInUser.TPhone.ToString();
            //txtPassword.Text = LoggedInUser.StPassword.ToString();
            //AnswerTb.Text = LoggedInUser.StQuestion.ToString();
            //AnswerTb2.Text = LoggedInUser.StQuestiontwo.ToString();
            //AnswerTb3.Text = LoggedInUser.StQuestionthree.ToString();
        }
        MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe");

        private void InsProfile_Load(object sender, EventArgs e)
        {
            GetInsName();
            petsa.Text = DateTime.Now.ToLongDateString();
            Timelb.Text = DateTime.Now.ToShortTimeString();
        }
        public void Reset()
        {
            GetInsName();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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
            else if(TPhoneTb.Text == "")
            {
                MessageBox.Show("Phone number Required", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MySqlCommand cmd = new MySqlCommand("update TeacherTbl set Tname=@TName,TGen=@TGeen,TPhone=@TPphone,TDOB=@TDob,TSub=@TSub,TAdd=@TAddd,TUsername=@TUser,TPassword=@TPass,TQuestion=@TQues,TQuestiontwo=@TQuesp,TQuestionthree=@TQuest where TId=@TID", Con);
                    cmd.Parameters.AddWithValue("@TName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@TGeen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPphone", TPhoneTb.ToString());
                    cmd.Parameters.AddWithValue("@TDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@TSub", ClassCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAddd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@TUser", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@TPass", SecureData.EncryptData(txtPassword.Text.Trim()));
                    cmd.Parameters.AddWithValue("@TQues", SecureData.EncryptData(AnswerTb.Text.Trim()));
                    cmd.Parameters.AddWithValue("@TQuesp", SecureData.EncryptData(AnswerTb2.Text.Trim()));
                    cmd.Parameters.AddWithValue("@TQuest", SecureData.EncryptData(AnswerTb3.Text.Trim()));
                    cmd.Parameters.AddWithValue("TID", LoggedInUser.TId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profile Updated");
                    Reset();
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
