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

        public string Name { get; }
        public string Address { get; }
        public string Ssn { get; }

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
            return name + " " + address + " " + ssn;
        }

    }
}
