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
    public partial class formNotification : Form
    {
        int time = 5;

        int _TicketNumber;

        public int TicketNumber
        {
            get { return _TicketNumber; }
            set { _TicketNumber = value; }
        }
        public formNotification()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            this.Opacity = (double)time / 5;
            if (time == 0)
            {
                this.Close();

            }
        }

        private void FormNotification_Load(object sender, EventArgs e)
        {
            lblStatusVe.Text = "Có (" + TicketNumber + ") vé được đặt thành công";
            timer1.Start();
        }
    }
}
