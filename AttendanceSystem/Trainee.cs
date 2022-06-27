using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;

namespace AttendanceSystem
{
    public partial class Trainee : Form
    {
        public Trainee()
        {
            InitializeComponent();
            DisplayStudent();
            timer1.Start();
            label17.Text = DateTime.Now.ToLongDateString();
            label18.Text = DateTime.Now.ToLongTimeString();
        }
        MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe");
        private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from StudentTbl";
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, Con);
            MySqlCommandBuilder Builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //RegisterUser obj = new RegisterUser();
            //obj.Show();
            if (StNameTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into StudentTbl(StName,StGen,StDOB,StClass,StAdd) values (@SName,@SGen,@SDob,@SClass,@SAdd )", Con);
                    cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trainee Added Successful");
                    Con.Close();
                    DisplayStudent();
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
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmLogin Obj = new frmLogin();
                Obj.Show();
                this.Hide();
            }
            else
            {
                this.Activate();
            }
        }
        private void Reset()
        {
            Key = 0;
            StNameTb.Text = "";
            AddressTb.Text = "";
            StGenCb.SelectedIndex = 0;
            ClassCb.SelectedIndex = 0;

        }
        int Key = 0;
        private void StudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StNameTb.Text = StudentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            StGenCb.SelectedItem = StudentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            DOBPicker.Text = StudentsDGV.SelectedRows[0].Cells[3].Value.ToString();
            ClassCb.SelectedItem = StudentsDGV.SelectedRows[0].Cells[4].Value.ToString();
            AddressTb.Text = StudentsDGV.SelectedRows[0].Cells[5].Value.ToString();
            //SaveBtn.Enabled= false;
            
           
            if (StNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StudentsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Trainee");
            }
            else if (MessageBox.Show("Are you sure you want to Disable this Account?", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("update studentTbl set Status = 'Disabled' where StId= @StKey", Con);
                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Disabled");
                    Con.Close();
                    DisplayStudent();
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
            if (StNameTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("update studentTbl set StName=@Sname,StGen=@SGen,StDOB=@SDob,StClass=@SClass,StAdd=@SAdd where StId=@SID",Con);
                    cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@SID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trainee Updated");
                    Con.Close();
                    DisplayStudent();
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
            StNameTb.Clear();
            AddressTb.Clear();
            SaveBtn.Enabled = true;

        }
        private void Students_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label17.Text = DateTime.Now.ToLongDateString();
            label18.Text = DateTime.Now.ToLongTimeString();
            //this.StudentsDGV.Columns["StAdd"].Visible = false;
            this.StudentsDGV.Columns["StUsername"].Visible = false;
            this.StudentsDGV.Columns["StPassword"].Visible = false;
            this.StudentsDGV.Columns["StQuestion"].Visible = false;
            this.StudentsDGV.Columns["StQuestiontwo"].Visible = false;
            this.StudentsDGV.Columns["StQuestionthree"].Visible = false;
            //this.StudentsDGV.Columns["StUsertype"].Visible = false;
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
                StudentsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                MySqlDataAdapter ada = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string command = "SELECT * FROM StudentTbl WHERE StName like '" + txtSearch.Text + "%' OR Status like '" + txtSearch.Text + "%' OR StGen like '" + txtSearch.Text + "%'";
                Con.Open();
                ada = new MySqlDataAdapter(command, Con);
                ada.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                StudentsDGV.DataSource = dv;
                Con.Close();
            }

            else if (txtSearch.Text == "")
            {
                DisplayStudent();
                this.StudentsDGV.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Trainee List"; //give your report name
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date.ToString("D"));
            printer.SubTitleColor = Color.LightSlateGray;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true; // if you need page numbers you can keep this as true other wise false
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(StudentsDGV);


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.StudentsDGV.Width, this.StudentsDGV.Height);
            StudentsDGV.DrawToBitmap(objBmp, new Rectangle(0, 0, this.StudentsDGV.Width, this.StudentsDGV.Height));

            e.Graphics.DrawImage(objBmp, 0, 210);
            e.Graphics.DrawString(label19.Text, new Font("Verdana", 37, FontStyle.Bold), Brushes.SlateGray, new Point(260, 30));
            e.Graphics.DrawString(label17.Text, new Font("Verdana", 17, FontStyle.Regular), Brushes.SlateGray, new Point(305, 90));
            e.Graphics.DrawString(label18.Text, new Font("Verdana", 17, FontStyle.Regular), Brushes.SlateGray, new Point(373, 120));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Trainee");
            }
            else if (MessageBox.Show("Are you sure you want to Enable this Account?", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("update studentTbl set Status = 'Enabled' where StId= @StKey", Con);
                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Enabled");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void StudentsDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow r in StudentsDGV.Rows)
            {
                string is_Approved = Convert.ToString(r.Cells[11].Value);

                if(is_Approved == "Disabled")
                {
                    r.DefaultCellStyle.BackColor = Color.IndianRed;
                    r.DefaultCellStyle.ForeColor = Color.White;
                    r.DefaultCellStyle.SelectionForeColor = Color.Black;
                    r.DefaultCellStyle.SelectionBackColor = Color.Pink;
                }
                //else if(is_Approved == "Active")
                //{
                //    r.DefaultCellStyle.BackColor = Color.Lavender;
                //    r.DefaultCellStyle.ForeColor = Color.Black;
                //    r.DataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.LightSlateGray;
                //    r.DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
                //}
            }
        }
    }
}
