namespace AdminTicket
{
    partial class MainForm
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
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.lvCoach = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDateRange = new System.Windows.Forms.Label();
            this.lblCoachId = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerUpdateTicket = new System.Windows.Forms.Timer(this.components);
            this.btnSeeNewTicket = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThongTin.Location = new System.Drawing.Point(572, 262);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(164, 37);
            this.btnXemThongTin.TabIndex = 0;
            this.btnXemThongTin.Text = "Xem thông tin";
            this.btnXemThongTin.UseVisualStyleBackColor = true;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // lvCoach
            // 
            this.lvCoach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvCoach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCoach.FullRowSelect = true;
            this.lvCoach.GridLines = true;
            this.lvCoach.Location = new System.Drawing.Point(11, 19);
            this.lvCoach.Name = "lvCoach";
            this.lvCoach.Size = new System.Drawing.Size(521, 267);
            this.lvCoach.TabIndex = 1;
            this.lvCoach.UseCompatibleStateImageBehavior = false;
            this.lvCoach.View = System.Windows.Forms.View.Details;
            this.lvCoach.SelectedIndexChanged += new System.EventHandler(this.lvCoach_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvCoach);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tuyến đường";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày khởi hành";
            this.columnHeader3.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giờ khởi hành";
            this.columnHeader4.Width = 153;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CoachID";
            this.columnHeader5.Width = 0;
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRange.ForeColor = System.Drawing.Color.Tomato;
            this.lblDateRange.Location = new System.Drawing.Point(12, 318);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(0, 15);
            this.lblDateRange.TabIndex = 3;
            // 
            // lblCoachId
            // 
            this.lblCoachId.AutoSize = true;
            this.lblCoachId.Location = new System.Drawing.Point(42, 374);
            this.lblCoachId.Name = "lblCoachId";
            this.lblCoachId.Size = new System.Drawing.Size(35, 13);
            this.lblCoachId.TabIndex = 4;
            this.lblCoachId.Text = "label1";
            this.lblCoachId.Visible = false;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpStartDate.Location = new System.Drawing.Point(650, 38);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(99, 26);
            this.dtpStartDate.TabIndex = 5;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpEndDate.Location = new System.Drawing.Point(650, 92);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(99, 26);
            this.dtpEndDate.TabIndex = 5;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày";
            // 
            // TimerUpdateTicket
            // 
            this.TimerUpdateTicket.Interval = 10000;
            this.TimerUpdateTicket.Tick += new System.EventHandler(this.TimerUpdateTicket_Tick);
            // 
            // btnSeeNewTicket
            // 
            this.btnSeeNewTicket.BackColor = System.Drawing.Color.Turquoise;
            this.btnSeeNewTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeNewTicket.Location = new System.Drawing.Point(429, 318);
            this.btnSeeNewTicket.Name = "btnSeeNewTicket";
            this.btnSeeNewTicket.Size = new System.Drawing.Size(336, 37);
            this.btnSeeNewTicket.TabIndex = 0;
            this.btnSeeNewTicket.UseVisualStyleBackColor = false;
            this.btnSeeNewTicket.Visible = false;
            this.btnSeeNewTicket.Click += new System.EventHandler(this.btnSeeNewTicket_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(572, 141);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(164, 71);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Xem thống kê vé đặt nhiều nhất";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblCoachId);
            this.Controls.Add(this.lblDateRange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSeeNewTicket);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnXemThongTin);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Quản lý thông tin vé";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.ListView lvCoach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.Label lblCoachId;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TimerUpdateTicket;
        private System.Windows.Forms.Button btnSeeNewTicket;
        private System.Windows.Forms.Button btnReport;
    }
}

