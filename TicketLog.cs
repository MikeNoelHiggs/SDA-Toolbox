using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHS_Toolbox
{
    internal static class TicketLog
    {

        public static List<Ticket> TicketList { get; set; } = new List<Ticket>(); 


        private static void ClearTickets()
        {
            TicketList.Clear();
        }

        private static void AddTicket(Ticket ticket)
        {
            TicketList.Add(ticket);
        }

        public static List<ListViewItem> PopulateListViewItemList()
        {
            List<ListViewItem> bl = new List<ListViewItem>();

            foreach(Ticket t in TicketList)
            {
                ListViewItem lvi = new ListViewItem(); 
                lvi.Text = t.UserName;
                lvi.SubItems.Add(t.TicketID);
                lvi.SubItems.Add(t.Description);

                bl.Add(lvi);
            }

            return bl;
        }
    }
}
