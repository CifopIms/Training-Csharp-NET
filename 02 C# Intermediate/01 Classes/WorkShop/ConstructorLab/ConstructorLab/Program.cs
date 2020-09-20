using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            var customer = new Customer("bob");
            //customer.Orders = new List<Order>();
            customer.Orders.Add(order);

            //var customer2 = new Customer("Alice") { Id = 0 };

            //var customer2_ = new Customer();
            //customer2_.Id = 0;
            //customer2_.Name = "Alice";
        }
    }
}
