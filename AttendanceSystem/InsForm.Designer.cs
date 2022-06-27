namespace AttendanceSystem
{
    partial class InsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsForm));
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TimeOutbtn = new System.Windows.Forms.Button();
            this.AttDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Timelb = new System.Windows.Forms.Label();
            this.STNameTb = new System.Windows.Forms.TextBox();
            this.StIdCb = new System.Windows.Forms.ComboBox();
            this.petsa = new System.Windows.Forms.Label();
            this.TimeInbtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panels2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panels1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Adlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDGV)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1078, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 36);
            this.label6.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel6.Location = new System.Drawing.Point(0, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1033, 10);
            this.panel6.TabIndex = 57;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(106)))), ((int)(((byte)(141)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1044, 92);
            this.panel5.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(231, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 38);
            this.label1.TabIndex = 58;
            this.label1.Text = "MAUI\'S TIME AND ATTENDANCE SYSTEM";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 92);
            this.panel3.TabIndex = 26;
            // 
            // TimeOutbtn
            // 
            this.TimeOutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeOutbtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeOutbtn.ForeColor = System.Drawing.Color.IndianRed;
            this.TimeOutbtn.Location = new System.Drawing.Point(407, 150);
            this.TimeOutbtn.Name = "TimeOutbtn";
            this.TimeOutbtn.Size = new System.Drawing.Size(391, 208);
            this.TimeOutbtn.TabIndex = 2;
            this.TimeOutbtn.Text = "TIME OUT";
            this.TimeOutbtn.UseVisualStyleBackColor = true;
            this.TimeOutbtn.Click += new System.EventHandler(this.TimeOutbtn_Click);
            // 
            // AttDatePicker
            // 
            this.AttDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.AttDatePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AttDatePicker.Enabled = false;
            this.AttDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AttDatePicker.Location = new System.Drawing.Point(513, 441);
            this.AttDatePicker.Name = "AttDatePicker";
            this.AttDatePicker.Size = new System.Drawing.Size(166, 29);
            this.AttDatePicker.TabIndex = 33;
            this.AttDatePicker.Visible = false;
            // 
            // Timelb
            // 
            this.Timelb.AutoSize = true;
            this.Timelb.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Timelb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Timelb.Location = new System.Drawing.Point(535, 54);
            this.Timelb.Name = "Timelb";
            this.Timelb.Size = new System.Drawing.Size(34, 25);
            this.Timelb.TabIndex = 0;
            this.Timelb.Text = "__";
            // 
            // STNameTb
            // 
            this.STNameTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.STNameTb.Enabled = false;
            this.STNameTb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.STNameTb.Location = new System.Drawing.Point(326, 441);
            this.STNameTb.Name = "STNameTb";
            this.STNameTb.Size = new System.Drawing.Size(164, 27);
            this.STNameTb.TabIndex = 28;
            // 
            // StIdCb
            // 
            this.StIdCb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StIdCb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StIdCb.FormattingEnabled = true;
            this.StIdCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StIdCb.Location = new System.Drawing.Point(133, 441);
            this.StIdCb.Name = "StIdCb";
            this.StIdCb.Size = new System.Drawing.Size(164, 29);
            this.StIdCb.TabIndex = 29;
            // 
            // petsa
            // 
            this.petsa.AutoSize = true;
            this.petsa.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.petsa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.petsa.Location = new System.Drawing.Point(94, 54);
            this.petsa.Name = "petsa";
            this.petsa.Size = new System.Drawing.Size(34, 25);
            this.petsa.TabIndex = 1;
            this.petsa.Text = "__";
            // 
            // TimeInbtn
            // 
            this.TimeInbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeInbtn.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeInbtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.TimeInbtn.Location = new System.Drawing.Point(4, 150);
            this.TimeInbtn.Name = "TimeInbtn";
            this.TimeInbtn.Size = new System.Drawing.Size(401, 208);
            this.TimeInbtn.TabIndex = 1;
            this.TimeInbtn.Text = "TIME IN";
            this.TimeInbtn.UseVisualStyleBackColor = true;
            this.TimeInbtn.Click += new System.EventHandler(this.TimeInbtn_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.CadetBlue;
            this.panel8.Location = new System.Drawing.Point(4, 123);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(794, 21);
            this.panel8.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TimeOut";
            this.Column6.HeaderText = "Time Out";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TimeIn";
            this.Column5.HeaderText = "Time In";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "AttDate";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "AttStName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "AttStId";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // AttendanceDGV
            // 
            this.AttendanceDGV.AllowUserToAddRows = false;
            this.AttendanceDGV.AllowUserToDeleteRows = false;
            this.AttendanceDGV.AllowUserToResizeColumns = false;
            this.AttendanceDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.AttendanceDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AttendanceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttendanceDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.AttendanceDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AttendanceDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AttendanceDGV.ColumnHeadersHeight = 30;
            this.AttendanceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AttendanceDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendanceDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.AttendanceDGV.EnableHeadersVisualStyles = false;
            this.AttendanceDGV.Location = new System.Drawing.Point(4, 362);
            this.AttendanceDGV.Name = "AttendanceDGV";
            this.AttendanceDGV.ReadOnly = true;
            this.AttendanceDGV.RowHeadersVisible = false;
            this.AttendanceDGV.RowTemplate.Height = 25;
            this.AttendanceDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendanceDGV.Size = new System.Drawing.Size(794, 167);
            this.AttendanceDGV.StandardTab = true;
            this.AttendanceDGV.TabIndex = 43;
            this.AttendanceDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceDGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(362, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 38);
            this.label2.TabIndex = 45;
            this.label2.Text = "Welcome";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.TimeOutbtn);
            this.panel7.Controls.Add(this.Timelb);
            this.panel7.Controls.Add(this.petsa);
            this.panel7.Controls.Add(this.TimeInbtn);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.AttendanceDGV);
            this.panel7.Controls.Add(this.STNameTb);
            this.panel7.Controls.Add(this.StIdCb);
            this.panel7.Controls.Add(this.AttDatePicker);
            this.panel7.Location = new System.Drawing.Point(130, 168);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(803, 536);
            this.panel7.TabIndex = 27;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panels2
            // 
            this.panels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(221)))), ((int)(((byte)(209)))));
            this.panels2.Location = new System.Drawing.Point(-3, 357);
            this.panels2.Name = "panels2";
            this.panels2.Size = new System.Drawing.Size(10, 55);
            this.panels2.TabIndex = 20;
            this.panels2.Visible = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(24, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 55);
            this.button1.TabIndex = 15;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.Controls.Add(this.panels2);
            this.panel4.Controls.Add(this.panels1);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 763);
            this.panel4.TabIndex = 16;
            // 
            // panels1
            // 
            this.panels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(221)))), ((int)(((byte)(209)))));
            this.panels1.Location = new System.Drawing.Point(-3, 280);
            this.panels1.Name = "panels1";
            this.panels1.Size = new System.Drawing.Size(10, 55);
            this.panels1.TabIndex = 19;
            this.panels1.Visible = false;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Location = new System.Drawing.Point(22, 690);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 61);
            this.button5.TabIndex = 18;
            this.button5.Text = "              Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(22, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 55);
            this.button4.TabIndex = 17;
            this.button4.Text = "          Dashboard";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Location = new System.Drawing.Point(0, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 240);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(12, 15);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(215, 202);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // Adlabel
            // 
            this.Adlabel.AutoSize = true;
            this.Adlabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Adlabel.ForeColor = System.Drawing.Color.SlateGray;
            this.Adlabel.Location = new System.Drawing.Point(522, 111);
            this.Adlabel.Name = "Adlabel";
            this.Adlabel.Size = new System.Drawing.Size(449, 38);
            this.Adlabel.TabIndex = 44;
            this.Adlabel.Text = "___________________________";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Adlabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(237, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 763);
            this.panel2.TabIndex = 17;
            // 
            // InsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 762);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsForm";
            this.Load += new System.EventHandler(this.InsForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDGV)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button TimeOutbtn;
        private System.Windows.Forms.DateTimePicker AttDatePicker;
        private System.Windows.Forms.Label Timelb;
        private System.Windows.Forms.TextBox STNameTb;
        private System.Windows.Forms.ComboBox StIdCb;
        private System.Windows.Forms.Label petsa;
        private System.Windows.Forms.Button TimeInbtn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView AttendanceDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panels2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panels1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label Adlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
    }
}