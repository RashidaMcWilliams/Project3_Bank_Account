using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Bank_Account
{
    class Client
    {
        private string name;
        private string address;
        private string ssn;

        public string Name { get; set; }
        public string Address { get; set; }
        public string Ssn { get; set; }

        public Client()
        {

        }

        public Client(string name, string address, string ssn)
        {
            this.name = name;
            this.address = address;
            this.ssn = ssn;
        }

        public virtual string ClientInfo()
        {
            return name + "\n" + address + "\n" + ssn;
        }

    }
}
