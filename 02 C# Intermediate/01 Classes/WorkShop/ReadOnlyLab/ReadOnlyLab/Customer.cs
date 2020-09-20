using System.Collections.Generic;

namespace ReadOnlyLab
{
    public class Customer
    {
        public readonly List<Order> Orders = new List<Order>();

        public Customer()
        {
            Orders = new List<Order>();
        }

        public void SubcribeToReduction()
        {
            //....
            Orders = null;
        }
    }
}
