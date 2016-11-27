using AdminTicket.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminTicket
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            TicketDataContext dc = new TicketDataContext();
            List<Ticket> tickets = dc.Tickets.ToList();
            InitializeComponent();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            TicketDetails form = new TicketDetails();

            form.CoachID = Convert.ToInt32(lblCoachId.Text);
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            DateTime thisWeekStart = currentDate.AddDays(-(int)currentDate.DayOfWeek);
            DateTime thisWeekEnd = thisWeekStart.AddDays(7).AddSeconds(-1);
            lblDateRange.Text = "Thông tin chuyến xe: từ ngày " + thisWeekStart.ToString("dd/MM/yyyy") + " đến ngày " + thisWeekEnd.ToString("dd/MM/yyyy");
            TicketController ticketController = new TicketController();
            List<Coach> coaches = ticketController.getListCoachByRangeDate(thisWeekStart, thisWeekEnd);
            coaches.Sort(delegate (Coach c1, Coach c2)
            { return (c1.StartDate.CompareTo(c2.StartDate)); }
            );
            LoadDataToListView(coaches, lvCoach);
            TimerUpdateTicket.Start();
        }

        public void LoadDataToListView(List<Coach> coachs, ListView lv)
        {
            lv.Items.Clear();
            foreach (Coach coach in coachs)
            {
                ListViewItem lvitem = new ListViewItem(coach.Name);
                lvitem.SubItems.Add(coach.Router);
                lvitem.SubItems.Add(coach.StartDate.ToString("dd/MM/yyyy"));
                lvitem.SubItems.Add(coach.StartHour);
                lvitem.SubItems.Add(coach.Id.ToString());
                lv.Items.Add(lvitem);
            }
        }

        private void lvCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lvCoach.SelectedItems.Count > 0)
            {
                ListViewItem lvitem = this.lvCoach.SelectedItems[0];
                lblCoachId.Text = lvitem.SubItems[4].Text;

            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            TicketController ticketController = new TicketController();
            List<Coach> coaches = ticketController.getListCoachByRangeDate(dtpStartDate.Value, dtpEndDate.Value);
            coaches.Sort(delegate (Coach c1, Coach c2)
            { return (c1.StartDate.CompareTo(c2.StartDate)); }
            );
            LoadDataToListView(coaches, lvCoach);
            lblDateRange.Text = "Thông tin chuyến xe: từ ngày " + dtpStartDate.Value.ToString("dd/MM/yyyy") + " đến ngày " + dtpEndDate.Value.ToString("dd/MM/yyyy");
        }

        private void TimerUpdateTicket_Tick(object sender, EventArgs e)
        {
            TicketController ticketController = new TicketController();
            int countTicket = ticketController.CountNewTicketOrdered();
            if(countTicket > 0)
            {
                formNotification frm = new formNotification();
                frm.TicketNumber = countTicket;
                frm.Show();
                btnSeeNewTicket.Text = "Xem thông tin (" + countTicket + ") vé vừa được đặt";
                btnSeeNewTicket.Visible = true;
            }else
            {
                btnSeeNewTicket.Visible = false;
            }
        }

        private void btnSeeNewTicket_Click(object sender, EventArgs e)
        {
            TicketDetails form = new TicketDetails();
            form.CheckedNew = true;
            form.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReportTicket frm = new frmReportTicket();
            frm.StartDate = dtpStartDate.Value;
            frm.EndDate = dtpEndDate.Value;
            frm.Show();
        }
    }
}
