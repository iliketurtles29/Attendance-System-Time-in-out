using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;

namespace AttendanceSystem
{
    public partial class Instructors : Form
    {
        public Instructors()
        {
            InitializeComponent();
            DisplayTeachers();
        }
        MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe");
        private void DisplayTeachers()
        {
            Con.Open();
            string Query = "Select * from TeacherTbl";
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, Con);
            MySqlCommandBuilder Builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TeachersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            TnameTb.Text = "";
            SubCb.SelectedIndex = 0;
            TGenCb.SelectedIndex = 0;
            TPhoneTb.Text = "";
            TAddTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into TeacherTbl(Tname,TGen,TPhone,TSub,TAdd,TDOB) values (@Tname,@TGen,@TPhone,@TSub,@TAdd,@TDOB )", Con);
                    cmd.Parameters.AddWithValue("@Tname", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", SubCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Instructor Added Successful");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Key = 0;
        private void TeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TnameTb.Text = TeachersDGV.SelectedRows[0].Cells[1].Value.ToString();
            TGenCb.SelectedItem = TeachersDGV.SelectedRows[0].Cells[2].Value.ToString();
            TPhoneTb.Text = TeachersDGV.SelectedRows[0].Cells[3].Value.ToString();
            SubCb.SelectedItem = TeachersDGV.SelectedRows[0].Cells[4].Value.ToString();
            TAddTb.Text = TeachersDGV.SelectedRows[0].Cells[5].Value.ToString();
            TDOB.Text = TeachersDGV.SelectedRows[0].Cells[6].Value.ToString();
            AddBtn.Enabled = false;

            if (TnameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TeachersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Teacher");
            }
            else
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from teacherTbl where TId= @TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Instructor Deleted");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("Update TeacherTbl set TName=@Tname,TGen=@TGen,TPhone=@TPhone,TSub=@TSub,TAdd=@TAdd,TDOB=@TDOB where TId=@TeachID", Con);
                    cmd.Parameters.AddWithValue("@Tname", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", SubCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@TeachId", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Instructor Updated");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TnameTb.Clear();
            TAddTb.Clear();
            AddBtn.Enabled = true;
        }

        private void Instructors_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label17.Text = DateTime.Now.ToLongDateString();
            label18.Text = DateTime.Now.ToLongTimeString();

            this.TeachersDGV.Columns["TUsername"].Visible = false;
            this.TeachersDGV.Columns["TPassword"].Visible = false;
            this.TeachersDGV.Columns["TQuestion"].Visible = false;
            this.TeachersDGV.Columns["TQuestiontwo"].Visible = false;
            this.TeachersDGV.Columns["TQuestionthree"].Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label18.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            MySqlConnection Con = new MySqlConnection("server = localhost; uid = root; password = ''; database = Mawe;");

            if (txtSearch.Text != "")
            {
                TeachersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                MySqlDataAdapter ada = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string command = "SELECT * FROM TeacherTbl WHERE Tname like '%" + txtSearch.Text + "%';";
                Con.Open();
                ada = new MySqlDataAdapter(command, Con);
                ada.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                TeachersDGV.DataSource = dv;
                Con.Close();
            }

            else if (txtSearch.Text == "")
            {
                DisplayTeachers();
                this.TeachersDGV.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Instructor List"; //give your report name
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date.ToString("D"));
            printer.SubTitleColor = Color.LightSlateGray;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true; // if you need page numbers you can keep this as true other wise false
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(TeachersDGV);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Instructor");
            }
            else if (MessageBox.Show("Are you sure you want to Enable this Account?", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("update TeacherTbl set Status = 'Enabled' where TId= @StKey", Con);
                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Enabled");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Instructor");
            }
            else if (MessageBox.Show("Are you sure you want to Disable this Account?", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("update TeacherTbl set Status = 'Disabled' where TId= @StKey", Con);
                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Disabled");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void TeachersDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in TeachersDGV.Rows)
            {
                string is_Approved = Convert.ToString(r.Cells[12].Value);

                if (is_Approved == "Disabled")
                {
                    r.DefaultCellStyle.BackColor = Color.IndianRed;
                    r.DefaultCellStyle.ForeColor = Color.White;
                    r.DefaultCellStyle.SelectionForeColor = Color.Black;
                    r.DefaultCellStyle.SelectionBackColor = Color.Pink;
                }
            }
        }
    }
}
