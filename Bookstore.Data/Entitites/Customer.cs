﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Data.Entitites
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public int CustomerCode { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public int CustomerPhone { get; set; }

        public  string CustomerEmail { get; set; }


    }
}
