using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    abstract class Salesman
    {
        public String firstName;
        public String lastName;

        public Salesman(String firstName,String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        abstract public void sell(); 
    }
}
