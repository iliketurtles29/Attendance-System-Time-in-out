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
    public partial class AddInstructor : Form
    {
        public AddInstructor()
        {
            InitializeComponent();
            timer1.Start();
            Petsa.Text = DateTime.Now.ToLongDateString();
            TimeLb.Text = DateTime.Now.ToLongTimeString();

        }
        MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe; convert zero datetime=True");
        private void Reset()
        {
            TNameTb.Text = "";
            AddressTb.Text = "";
            TGenCb.SelectedIndex = -1;
            ClassCB.SelectedIndex = -1;
            TPhoneTb.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPass.Text = "";
            AnswerTb.Text = "";
            AnswerTb2.Text = "";
            AnswerTb3.Text = "";

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || AddressTb.Text == "" || TGenCb.SelectedIndex == -1 || ClassCB.SelectedIndex == -1 || txtUsername.Text == "" || txtPassword.Text == "" || txtComPass.Text == "" || AnswerTb.Text == "" || AnswerTb2.Text == "" || AnswerTb3.Text == "" || TPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(TPhoneTb.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only on Phone");
                TPhoneTb.Text = TPhoneTb.Text.Remove(TPhoneTb.Text.Length - 1);
            }
            else if (txtPassword.TextLength <= 10)
            {
                MessageBox.Show("Make a strong Password", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtComPass.Text)
            {
                MessageBox.Show("Pasword do not Match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPassword.Text == txtComPass.Text && AnswerTb.Text != "" && AnswerTb2.Text != "" && AnswerTb3.Text != "")
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into TeacherTbl(Tname,TGen,TPhone,TSub,TAdd,TDOB,TUsername,TPassword,TQuestion,TQuestiontwo,TQuestionthree,Status) values (@Tname,@TGen,@TPhone,@TSub,@TAdd,@TDOB,@TIUser,@TIPass,@TIQues,@TIQuesp,@TIQuest,@Status )", Con);
                    cmd.Parameters.AddWithValue("@Tname", TNameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", ClassCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@TDOB", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@TIUser", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@TIPass", SecureData.EncryptData(txtPassword.Text.Trim()));
                    cmd.Parameters.AddWithValue("@TIQues", SecureData.EncryptData(AnswerTb.Text.Trim()));
                    cmd.Parameters.AddWithValue("@TIQuesp", SecureData.EncryptData(AnswerTb2.Text.Trim()));
                    cmd.Parameters.AddWithValue("@TIQuest", SecureData.EncryptData(AnswerTb3.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Status", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Instructor Added Successful");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void StNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClassCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLb.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void TPhoneTb_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
