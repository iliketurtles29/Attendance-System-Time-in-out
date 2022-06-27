using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelpertwo;

namespace AttendanceSystem
{
    public partial class Attendances : Form
    {
        public Attendances()
        {
            InitializeComponent();
            DisplayAttendance();
            //FillStudId();
        }

        //private void FillStudId()
        //{
        //    Con.Open();
        //    MySqlCommand cmd = new MySqlCommand("select StUsername from StudentTbl", Con);
        //    MySqlDataReader rdr;
        //    rdr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(rdr);
        //    StIdCb.ValueMember = "StUsername";
        //    StIdCb.DataSource = dt;
        //    Con.Close();
        //}
        //private void GetStudName()
        //{
        //    Con.Open();
        //    MySqlCommand Cmd = new MySqlCommand("select * from StudentTbl where StId=@SID", Con);
        //    Cmd.Parameters.AddWithValue("@SID", StIdCb.SelectedValue.ToString());
        //    DataTable dt = new DataTable();
        //    MySqlDataAdapter sda = new MySqlDataAdapter(Cmd);
        //    sda.Fill(dt);
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        STNameTb.Text = dr["StName"].ToString();
        //    }
        //    Con.Close();
        //}
        MySqlConnection Con = new MySqlConnection("server=localhost;uid=root; password=''; database=Mawe; convert zero datetime=True");
        private void DisplayAttendance()
        {
            Con.Open();
            string Query = "Select * from AttendanceTbl";
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, Con);
            MySqlCommandBuilder Builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendancesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        //private void Reset()
        //{
        //    STNameTb.Text = "";
        //    StIdCb.SelectedIndex = -1;
        //}

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //if (STNameTb.Text == "")
            //{
            //    MessageBox.Show("Missing Information", "Warning");
            //}
            //else if (MessageBox.Show("Are you sure?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            //{
            //    {
            //        try
            //        {
            //            Con.Open();
            //            MySqlCommand cmd = new MySqlCommand("insert into AttendanceTbl(AttStId,AttStName,AttDate,TimeIn) values (@StId,@StName,@AttDate,@TimeIn)", Con);
            //            cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
            //            cmd.Parameters.AddWithValue("@StName", STNameTb.Text);
            //            cmd.Parameters.AddWithValue("@AttDate", AttDatePicker.Value.Date);
            //            cmd.Parameters.AddWithValue("@TimeIn", Timelb.Text);
            //            cmd.ExecuteNonQuery();
            //            MessageBox.Show("Attendance Taken");
            //            Con.Close();
            //            DisplayAttendance();
            //            Reset();
            //        }
            //        catch (Exception Ex)
            //        {
            //            MessageBox.Show(Ex.Message);
            //        }

            //    }
            //}
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void StIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //GetStudName();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Reset();
            //AddBtn.Enabled = true;
        }
        //int Key = 0;
        private void AttendanceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //StIdCb.SelectedValue = AttendancesDGV.SelectedRows[0].Cells[1].Value.ToString();
            //STNameTb.Text = AttendancesDGV.SelectedRows[0].Cells[2].Value.ToString();
            ////AttDatePicker.Text = AttendanceDGV.SelectedRows[0].Cells[3].Value.ToString();
            ////AttStatusCb.SelectedItem = AttendanceDGV.SelectedRows[0].Cells[3].Value.ToString();
            //AddBtn.Enabled = false;
            //if (STNameTb.Text == "")
            //{
            //    Key = 0;
            //}
            //else
            //{
            //    Key = Convert.ToInt32(AttendancesDGV.SelectedRows[0].Cells[0].Value.ToString());
            //}
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //if (STNameTb.Text == "")
            //{
            //    MessageBox.Show("Missing Information");
            //}
            //else if (MessageBox.Show("Are you sure?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    try
            //    {
            //        Con.Open();
            //        MySqlCommand cmd = new MySqlCommand("update AttendanceTbl set AttStId=@StId,AttStName=@STName where AttNum=@ANum", Con);
            //        cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
            //        cmd.Parameters.AddWithValue("@STName", STNameTb.Text);
            //        cmd.Parameters.AddWithValue("@ANum", Key);
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Attendance Updated");
            //        Con.Close();
            //        DisplayAttendance();
            //        Reset();
            //    }
            //    catch (Exception Ex)
            //    {
            //        MessageBox.Show(Ex.Message);
            //    }

            //}
        }
        private void TimeOutBtn_Click(object sender, EventArgs e)
        {
            //if (Key == 0)
            //{
            //    MessageBox.Show("Select Student");
            //}
            ////else if (AttStatusCb.SelectedIndex == 2)
            ////{
            ////    MessageBox.Show("You're Absent for today, cannot time out");
            ////}
            //else if (MessageBox.Show("Are you sure?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    try
            //    {
            //        Con.Open();
            //        MySqlCommand cmd = new MySqlCommand("update AttendanceTbl set TimeOut=@Atttimeout where AttNum=@ANum", Con);
            //        cmd.Parameters.AddWithValue("@Atttimeout", Timelb.Text);
            //        cmd.Parameters.AddWithValue("@ANum", Key);
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Time Out Taken");
            //        Con.Close();
            //        DisplayAttendance();
            //        Reset();
            //    }
            //    catch (Exception Ex)
            //    {
            //        MessageBox.Show(Ex.Message);
            //    }

            //}
        }

        private void Attendances_Load(object sender, EventArgs e)
        {
            this.AttendancesDGV.Columns["AttNum"].Visible = false;
            timer1.Start();
            petsa.Text = DateTime.Now.ToLongDateString();
            Timelb.Text = DateTime.Now.ToLongTimeString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Timelb.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void txtSearch_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            MySqlConnection Con = new MySqlConnection("server = localhost; uid = root; password = ''; database = Mawe;");

            if (txtSearch.Text != "")
            {
                AttendancesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                MySqlDataAdapter ada = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string command = "SELECT * FROM AttendanceTbl WHERE AttStName like '%" + txtSearch.Text + "%' OR AttDate like '%" + txtSearch.Text + "%'";
                Con.Open();
                ada = new MySqlDataAdapter(command, Con);
                ada.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                AttendancesDGV.DataSource = dv;
                Con.Close();
            }

            else if (txtSearch.Text == "")
            {
                DisplayAttendance();
                this.AttendancesDGV.Refresh();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Attendance List"; //give your report name
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date.ToString("D"));
            printer.SubTitleColor = Color.LightSlateGray;
            printer.PageNumbers = true; // if you need page numbers you can keep this as true other wise false
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(AttendancesDGV);
        }
    }
}
