﻿using System.Collections.Generic;

namespace CsharpConsole
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id):this()
        {
            this.Id = id;
        }

        public Customer(int id, string name):this(id)
        {
            this.Name = name;
        }

    }
}