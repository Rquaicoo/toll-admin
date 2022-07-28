using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollAdmin
{
    internal class Station
    {
        private string id;
        private string name;
        private string location;
        private string address;
        private string phone;
        private int supervisor;

        public Station(string id, string name, string location, string address, string phone, int supervisor)
        {
            this.id = id;
            this.name = name;
            this.location = location;
            this.address = address;
            this.phone = phone;
            this.supervisor = supervisor;
        }
    }
}
