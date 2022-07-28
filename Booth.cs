using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollAdmin
{
    internal class Booth {

        private string id;
        private string name;
        private string type;

        public Booth (string id, string name, string type)
        {
            this.id = id;
            this.name = name;
            this.type = type;

        }
    }
}
