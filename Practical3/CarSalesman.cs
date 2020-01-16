using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class CarSalesman : Salesman
    {
        public CarSalesman(String firstName, String lastName) : base(firstName,lastName)
        {

        }

        public override void sell()
        {
            Console.WriteLine("Hello. My name is " + firstName + " " + lastName + ". I recommend you to by this car.");
        }
    }
}
