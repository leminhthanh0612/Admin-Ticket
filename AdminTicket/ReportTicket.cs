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
    public partial class frmReportTicket : Form
    {
        DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        public frmReportTicket()
        {
            InitializeComponent();
        }

        private void frmReportTicket_Load(object sender, EventArgs e)
        {
            TicketController ticketController = new TicketController();
            List<ReportTicket> reports = new List<ReportTicket>();
            reports = ticketController.reportTicketOrderTimes(StartDate, EndDate);
            foreach(ReportTicket report in reports)
            {
                ListViewItem lvitem = new ListViewItem(report.SeatId.ToString());
                lvitem.SubItems.Add(report.OrderTimes.ToString());
                lvReport.Items.Add(lvitem);
            }
        }
    }
}
