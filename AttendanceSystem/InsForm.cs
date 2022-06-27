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
    public partial class InsForm : Form
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
        public InsForm()
        {
            InitializeComponent();
            FillStudId();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
            timer1.Start();
            petsa.Text = DateTime.Now.ToLongDateString();
            Timelb.Text = DateTime.Now.ToLongTimeString();


        }
        private void FillStudId()
        {
            StIdCb.Text = LoggedInUser.TId;
        }
        private void GetStudName()
        {
            STNameTb.Text = LoggedInUser.Tname;
        }
        MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe; convert zero datetime=True");
        private void DisplayAttendance()
        {
            MySqlDataAdapter ada = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            DataView dv = new DataView();
        

            string command = "SELECT * FROM AttendanceTbl WHERE AttStName like '%" + STNameTb.Text + "%';";
            Con.Open();
            ada = new MySqlDataAdapter(command, Con);
            ada.Fill(ds);
            dv = new DataView(ds.Tables[0]);
            dv.Sort = "AttNum DESC";
            AttendanceDGV.DataSource = dv;
            Con.Close();
            AttendanceDGV.Columns["AttNum"].Visible = false;

            //foreach (DataGridViewRow row in AttendanceDGV.SelectedRows)
            //{
            //    string status = row.Cells[3].Value.ToString();
            //    if (status != null)
            //    {
            //        TimeInbtn.Enabled = false;
            //    }
            //    else
            //    {
            //        TimeInbtn.Enabled = true;
            //        TimeOutbtn.Enabled = true;
            //    }

            //}
        }
        private void TimeInbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                {
                    TimeInbtn.Enabled = false;
                    try
                    {
                        Con.Open();
                        MySqlCommand cmd = new MySqlCommand("insert into AttendanceTbl(AttStId,AttStName,AttDate,TimeIn) values (@StId,@StName,@AttDate,@TimeIn)", Con);
                        cmd.Parameters.AddWithValue("@StId", StIdCb.Text);
                        cmd.Parameters.AddWithValue("@StName", STNameTb.Text);
                        cmd.Parameters.AddWithValue("@AttDate", AttDatePicker.Value.Date);
                        cmd.Parameters.AddWithValue("@TimeIn", Timelb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Time In Recorded");
                        Con.Close();
                        DisplayAttendance();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }

                }
            }
        }
        private void TimeOutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TimeOutbtn.Enabled = false;
                try
                {
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("update AttendanceTbl set TimeOut=@Atttimeout where AttNum=@ANum", Con);
                    cmd.Parameters.AddWithValue("@Atttimeout", Timelb.Text);
                    cmd.Parameters.AddWithValue("@ANum", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Time Out Recorded");
                    Con.Close();
                    DisplayAttendance();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void AttendanceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StIdCb.SelectedValue = AttendanceDGV.SelectedRows[0].Cells[1].Value.ToString();
            STNameTb.Text = AttendanceDGV.SelectedRows[0].Cells[2].Value.ToString();
            //AttDatePicker.Text = AttendanceDGV.SelectedRows[0].Cells[3].Value.ToString();
            //AttStatusCb.SelectedItem = AttendanceDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (STNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AttendanceDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void InsForm_Load(object sender, EventArgs e)
        {
            Adlabel.Text = LoggedInUser.Tname+"!";
            //AttendanceDGV.CurrentCell.Selected = false;
            GetStudName();
            DisplayAttendance();
            timer1.Start();
            panels1.Visible = true;
            panels2.Visible = false;

            petsa.Text = DateTime.Now.ToLongDateString();
            Timelb.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsProfile stu = new InsProfile();
            stu.TopLevel = false;
            stu.AutoScroll = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(stu);
            stu.Show();

            panels1.Visible = false;
            panels2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
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

        private void button4_Click(object sender, EventArgs e)
        {
            InsForm obj = new InsForm();
            obj.Show();
            this.Hide();
            panels1.Visible = true;
            panels2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timelb.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
