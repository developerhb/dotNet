using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class CarSalesman : ISalesman
    {
        private String firstName;
        private String lastName;
        public CarSalesman(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public String fullName
        {
            get { return firstName + " " + lastName; }
        }
        public void sell()
        {
            Console.WriteLine("hello. my name is " + fullName + ". i recommend you to by this car.");
        }
    }
}
