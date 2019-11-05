using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7ex8
{
    public abstract class Person
    {
        protected String firstName;
        protected String lastName;

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

    }
}
