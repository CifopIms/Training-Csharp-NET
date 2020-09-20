using System;
using System.Collections.Generic;

namespace ConstructorLab
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(string name)
            //: this()
        {
            this.Name = name;
            Orders = new List<Order>();
        }

        public Customer(int id, string name)
            :this(name)
        {
            this.Id = id;
        }
    }
}
