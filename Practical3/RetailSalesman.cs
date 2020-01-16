using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class RetailSalesman : ISalesman
    {
        private String firstName;
        private String lastName;
        public RetailSalesman(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public String fullName
        {
            get { return firstName + " " + lastName;  }
        }
        public void sell()
        {
            Console.WriteLine("Hello. My name is " + fullName + ". I recommend you to by this retail item.");
        }
    }
}
