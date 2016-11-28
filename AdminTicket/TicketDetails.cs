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
    public partial class TicketDetails : Form
    {
        int _CoachId;

        public int CoachID
        {
            get { return _CoachId; }
            set { _CoachId = value; }
        }

        bool _checkedNew = false;

        public bool CheckedNew
        {
            get { return _checkedNew; }
            set { _checkedNew = value; }
        }

        List<Ticket> _listNew;

        public List<Ticket> ListNew
        {
            get { return _listNew; }
            set { _listNew = value; }
        }

        public TicketDetails()
        {
            InitializeComponent();
        }

        private void TicketDetails_Load(object sender, EventArgs e)
        {
            lvTickets.Items.Clear();
            List<Ticket> tickets = new List<Ticket>();
            TicketController ticketController = new TicketController();
            if (CheckedNew)
            {
                tickets = ticketController.getNewTicketOrdred();
                ListNew = tickets;
            }
            else
            {
                tickets = ticketController.getTicketsByCoachId(CoachID);
            }
            
            FillDataToListView(tickets, lvTickets);

            if(CheckedNew)
            {
                ticketController.updateIsNewTicket();
            }
           
        }

        private void lvTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lvTickets.SelectedItems.Count > 0)
            {
                ListViewItem lvitem = this.lvTickets.SelectedItems[0];
                txtSeatNumber.Text = lvitem.SubItems[0].Text;
                cboStatus.Text = lvitem.SubItems[1].Text;
                lblMainName.Text = lvitem.SubItems[2].Text;
                lblMainPhone.Text = lvitem.SubItems[3].Text;
                llblPassengerId.Text = lvitem.SubItems[4].Text;
                lblCoachId.Text = lvitem.SubItems[5].Text;
            }
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            TicketController ticketController = new TicketController();
            if (ticketController.updateStatusTicket(Convert.ToInt32(llblPassengerId.Text), Convert.ToInt32(lblCoachId.Text), Convert.ToInt32(txtSeatNumber.Text), cboStatus.Text))
            {
                List<Ticket> tickets = new List<Ticket>();
                if (CheckedNew)
                {
                    tickets = ListNew;
                }
                else
                {
                    tickets = ticketController.getTicketsByCoachId(CoachID);
                }
                FillDataToListView(tickets, lvTickets);
                MessageBox.Show("Cập nhật trạng thái thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra khi cập nhật","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void FillDataToListView(List<Ticket> tickets, ListView lv)
        {

            lv.Items.Clear();
            TicketController ticketController = new TicketController();
            tooltipTicketSum.Text = "Tổng số vé: " + tickets.Count();
            foreach (Ticket ticket in tickets)
            {
                ListViewItem lvitem = new ListViewItem(ticket.SeatId.ToString());
                lvitem.SubItems.Add(ticketController.convertStatusFromEntityToModel(ticket.Status));
                lvitem.SubItems.Add(ticket.Passenger.FirstName + " " + ticket.Passenger.LastName);
                lvitem.SubItems.Add(ticket.Passenger.Phone.ToString());
                lvitem.SubItems.Add(ticket.PassengerId.ToString());
                lvitem.SubItems.Add(ticket.Coach.Id.ToString());
                if(ticket.isNew != null && ticket.isNew == true)
                {
                    lvitem.BackColor = Color.Green;
                }
                lv.Items.Add(lvitem);
            }
        }
    }
}
