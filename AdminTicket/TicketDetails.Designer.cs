namespace AdminTicket
{
    partial class TicketDetails
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
            this.lvTickets = new System.Windows.Forms.ListView();
            this.SeatNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpTicket = new System.Windows.Forms.GroupBox();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tooltipTicketSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.PassengerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PassengerPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PassengerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblName = new System.Windows.Forms.Label();
            this.lblMainName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMainPhone = new System.Windows.Forms.Label();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.CoachId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.llblPassengerId = new System.Windows.Forms.Label();
            this.lblCoachId = new System.Windows.Forms.Label();
            this.grpTicket.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTickets
            // 
            this.lvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SeatNumber,
            this.Status,
            this.PassengerName,
            this.PassengerPhone,
            this.PassengerId,
            this.CoachId});
            this.lvTickets.FullRowSelect = true;
            this.lvTickets.GridLines = true;
            this.lvTickets.Location = new System.Drawing.Point(0, 28);
            this.lvTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvTickets.Name = "lvTickets";
            this.lvTickets.Size = new System.Drawing.Size(508, 389);
            this.lvTickets.TabIndex = 0;
            this.lvTickets.UseCompatibleStateImageBehavior = false;
            this.lvTickets.View = System.Windows.Forms.View.Details;
            this.lvTickets.SelectedIndexChanged += new System.EventHandler(this.lvTickets_SelectedIndexChanged);
            // 
            // SeatNumber
            // 
            this.SeatNumber.Text = "Số ghế";
            this.SeatNumber.Width = 105;
            // 
            // Status
            // 
            this.Status.Text = "Trạng thái";
            this.Status.Width = 132;
            // 
            // grpTicket
            // 
            this.grpTicket.Controls.Add(this.lvTickets);
            this.grpTicket.Location = new System.Drawing.Point(18, 18);
            this.grpTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTicket.Name = "grpTicket";
            this.grpTicket.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpTicket.Size = new System.Drawing.Size(516, 425);
            this.grpTicket.TabIndex = 1;
            this.grpTicket.TabStop = false;
            this.grpTicket.Text = "Thông tin vé";
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Location = new System.Drawing.Point(542, 46);
            this.lblSeatNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(60, 19);
            this.lblSeatNumber.TabIndex = 2;
            this.lblSeatNumber.Text = "Số ghế:";
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Location = new System.Drawing.Point(642, 43);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.ReadOnly = true;
            this.txtSeatNumber.Size = new System.Drawing.Size(154, 27);
            this.txtSeatNumber.TabIndex = 3;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(542, 120);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(80, 19);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Hủy",
            "Đang giao dịch",
            "Đã bán"});
            this.cboStatus.Location = new System.Drawing.Point(642, 117);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(154, 27);
            this.cboStatus.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooltipTicketSum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(808, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tooltipTicketSum
            // 
            this.tooltipTicketSum.Name = "tooltipTicketSum";
            this.tooltipTicketSum.Size = new System.Drawing.Size(65, 17);
            this.tooltipTicketSum.Text = "Tổng số vé";
            // 
            // PassengerName
            // 
            this.PassengerName.Text = "Họ và Tên";
            this.PassengerName.Width = 103;
            // 
            // PassengerPhone
            // 
            this.PassengerPhone.Text = "Số điện thoại";
            this.PassengerPhone.Width = 153;
            // 
            // PassengerId
            // 
            this.PassengerId.Text = "ID hành khách";
            this.PassengerId.Width = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(542, 177);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Họ và Tên:";
            // 
            // lblMainName
            // 
            this.lblMainName.AutoSize = true;
            this.lblMainName.Location = new System.Drawing.Point(639, 177);
            this.lblMainName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainName.Name = "lblMainName";
            this.lblMainName.Size = new System.Drawing.Size(0, 19);
            this.lblMainName.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(542, 226);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(104, 19);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // lblMainPhone
            // 
            this.lblMainPhone.AutoSize = true;
            this.lblMainPhone.Location = new System.Drawing.Point(649, 226);
            this.lblMainPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainPhone.Name = "lblMainPhone";
            this.lblMainPhone.Size = new System.Drawing.Size(0, 19);
            this.lblMainPhone.TabIndex = 2;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(546, 290);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateStatus.TabIndex = 6;
            this.btnUpdateStatus.Text = "Cập nhật";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(668, 290);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(100, 35);
            this.btnCanel.TabIndex = 6;
            this.btnCanel.Text = "Đóng";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // CoachId
            // 
            this.CoachId.Text = "CoachId";
            this.CoachId.Width = 1;
            // 
            // llblPassengerId
            // 
            this.llblPassengerId.AutoSize = true;
            this.llblPassengerId.Location = new System.Drawing.Point(542, 396);
            this.llblPassengerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblPassengerId.Name = "llblPassengerId";
            this.llblPassengerId.Size = new System.Drawing.Size(93, 19);
            this.llblPassengerId.TabIndex = 2;
            this.llblPassengerId.Text = "passengerID";
            this.llblPassengerId.Visible = false;
            // 
            // lblCoachId
            // 
            this.lblCoachId.AutoSize = true;
            this.lblCoachId.Enabled = false;
            this.lblCoachId.Location = new System.Drawing.Point(649, 396);
            this.lblCoachId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoachId.Name = "lblCoachId";
            this.lblCoachId.Size = new System.Drawing.Size(69, 19);
            this.lblCoachId.TabIndex = 2;
            this.lblCoachId.Text = "CoachID";
            this.lblCoachId.Visible = false;
            // 
            // TicketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 461);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtSeatNumber);
            this.Controls.Add(this.lblMainName);
            this.Controls.Add(this.lblMainPhone);
            this.Controls.Add(this.lblCoachId);
            this.Controls.Add(this.llblPassengerId);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblSeatNumber);
            this.Controls.Add(this.grpTicket);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TicketDetails";
            this.ShowIcon = false;
            this.Text = "Chi Tiết Vé";
            this.Load += new System.EventHandler(this.TicketDetails_Load);
            this.grpTicket.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTickets;
        private System.Windows.Forms.ColumnHeader SeatNumber;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.GroupBox grpTicket;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tooltipTicketSum;
        private System.Windows.Forms.ColumnHeader PassengerName;
        private System.Windows.Forms.ColumnHeader PassengerPhone;
        private System.Windows.Forms.ColumnHeader PassengerId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMainName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMainPhone;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.ColumnHeader CoachId;
        private System.Windows.Forms.Label llblPassengerId;
        private System.Windows.Forms.Label lblCoachId;
    }
}