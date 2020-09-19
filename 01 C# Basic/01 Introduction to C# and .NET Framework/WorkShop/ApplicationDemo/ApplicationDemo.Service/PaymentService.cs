using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDemo.Service
{
    public class PaymentService
    {
        public double Calucalute(double amount)
        {
            // Logic ...
            Console.WriteLine("Calucate is starting ...");
            return amount - (amount * 0.1);
        }
    }
}
