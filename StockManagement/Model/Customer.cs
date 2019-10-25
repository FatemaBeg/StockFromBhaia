﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Model
{
    public class Customer
    {
        public int ID { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Contact { set; get; }
        public string Email { set; get; }
        public int LoyalityPoint { set; get; }

        public Customer() { }
        public Customer(string code, string name, string address, string contact, string email, int loyalityPoint)
        {
            this.Code = code;
            this.Name = name;
            this.Address = address;
            this.Contact = contact;
            this.Email = email;
            this.LoyalityPoint = loyalityPoint;
        }
    }
}
