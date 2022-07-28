using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollAdmin
{
    internal class Ticket
    {
        private int id;
        private int classification;
        private int amount;
        private DateTime timestamp;
        private int recieptNumber;
        private int session;

        public Ticket(int id, int classification, int amount, DateTime timestamp, int recieptNumber, int session)
        {
            this.id = id;
            this.classification = classification;
            this.amount = amount;
            this.timestamp = timestamp;
            this.recieptNumber = recieptNumber;
            this.session = session;
        }
    }
}
