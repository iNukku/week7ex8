using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7ex8
{
    public enum title {Sir, Miss, Mrs };
    public class Publisher : Person
    {
        private title publisherTitle;

        public string getTitle()
        {
            return publisherTitle.ToString();
        }
        public Publisher(string first, string last, title thetitle)
        {
            this.firstName = first;
            this.lastName = last;
            this.publisherTitle = thetitle;
        }
    }
}
