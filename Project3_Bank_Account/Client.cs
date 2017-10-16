using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_Bank_Account
{
    class Client
    {
        protected string name;
        protected string addrss;
        protected string ssn;

        public string Name { get; set; }
        public string Address { get; set; }
        public string Ssn { get; set; }

        public Client()
        {

        }

        public Client(string name, string address, string ssn)
        {
            this.Name = name;
            this.Address = address;
            this.Ssn = ssn;
        }

        public virtual string ClientInfo()
        {
            return Name + "\n" + Address + "\n" + Ssn;
        }

    }
}
