using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman salesman = new CarSalesman("Hem","Bhagat");
            salesman.sell();

            RetailSalesman retail = new RetailSalesman("Sneh", "Ghetia");
            retail.sell();
            Console.ReadKey();
        }
    }
}
