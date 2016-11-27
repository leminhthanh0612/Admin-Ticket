using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTicket.Controller
{
    public class TicketController
    {
        public TicketDataContext dc = new TicketDataContext();
        public TicketController() { }

        public  List<Ticket> getTicketsByCoachId(int CoachId)
        {
            List<Ticket> tickets = new List<Ticket>();
            tickets = dc.Tickets.Where(q => q.CoachId == CoachId).OrderBy(q => q.SeatId).ToList();
            return tickets;
        }

        public bool updateStatusTicket(int passengerId, int coachId, int seatID, string status)
        {
            Ticket ticket = dc.Tickets.Where(q => q.CoachId == coachId && q.PassengerId == passengerId && q.SeatId == seatID).FirstOrDefault();
            if(ticket != null)
            {
                if(status == "Hủy")
                {
                    dc.Tickets.DeleteOnSubmit(ticket);
                }
                else
                {
                    ticket.Status = convertStatusFromModelToEntity(status);
                }
                
                dc.SubmitChanges();
                return true;
            }
            return false;
        }

        public string convertStatusFromModelToEntity(String model)
        {
            switch(model)
            {
                case "Hủy":
                    return "Avaiable";
                case "Đang giao dịch":
                    return "Pendding";
                case "Đã bán":
                    return "Sold";
                default:
                    return "";

            }
        }

        public string convertStatusFromEntityToModel(String model)
        {
            switch (model)
            {
                case "Avaiable":
                    return "Hủy";
                case "Pendding":
                    return "Đang giao dịch";
                case "Sold":
                    return "Đã bán";
                default:
                    return "";

            }
        }

        public List<Coach> getListCoachByRangeDate(DateTime startDate, DateTime endDate)
        {
            List<Coach> coaches = new List<Coach>();
            if(startDate > endDate)
            {
                coaches = dc.Coaches.Where(q => q.StartDate >= startDate).ToList();
            }
            else if(endDate < startDate)
            {
                coaches = dc.Coaches.Where(q => q.StartDate <= startDate).ToList();
            }
            else
            {
                coaches = dc.Coaches.Where(q => q.StartDate >= startDate && q.StartDate <= endDate).ToList();
            }
           
            return coaches;
        }

        public int CountNewTicketOrdered()
        {
            return dc.Tickets.Where(q => q.isNew == true).Count();
        }

        public List<Ticket> getNewTicketOrdred()
        {
            List<Ticket> tickets = new List<Ticket>();
            tickets = dc.Tickets.Where(q => q.isNew == true).OrderBy(q => q.CoachId).ToList();
            return tickets;
        }

        public void updateIsNewTicket()
        {
            List<Ticket> tickets = getNewTicketOrdred();
            foreach (Ticket ticket in tickets)
            {
                ticket.isNew = false;
            }
            dc.SubmitChanges();
        }

        public List<ReportTicket> reportTicketOrderTimes(DateTime startDate, DateTime endDate)
        {
            List<ReportTicket> reportTickets = new List<ReportTicket>();
            var results = dc.Tickets.Where(q => q.CreationDate >= startDate.Date && q.CreationDate <= endDate.Date)
                                    .GroupBy(q => q.SeatId)
                                    .Select(q => new ReportTicket { SeatId = q.Key, OrderTimes = q.Count() })
                                    .OrderByDescending(q => q.OrderTimes).Take(10);

            foreach(var result in results)
            {
                ReportTicket rp = new ReportTicket();
                rp.SeatId = result.SeatId;
                rp.OrderTimes = result.OrderTimes;
                reportTickets.Add(rp);
            }                  

            return reportTickets;
        }
    }
}
