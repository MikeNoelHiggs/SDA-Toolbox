using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHS_Toolbox
{
    internal class Ticket
    {
        public string  UserName { get; set; }
        public string  TicketID { get; set; }
        public string  Description { get; set; }


        public Ticket(string userName, string ticketID, string description)
        {
            UserName = userName;
            TicketID = ticketID;
            Description = description;
        }

    }
}
