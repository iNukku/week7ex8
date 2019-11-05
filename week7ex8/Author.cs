using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7ex8
{
    public class Author : Person
    {
        private string email;
        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Author(string first, string last, string mail, string adress)
        {
            this.firstName = first;
            this.lastName = last;
            this.email = mail;
            this.adress = adress;
        }

    }
}
