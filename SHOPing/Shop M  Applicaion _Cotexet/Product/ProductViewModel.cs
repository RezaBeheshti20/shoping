﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.Product
{
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
       public string Picture { get; set; }
        public string Code { get; set; }
        public string Category{ get; set; }
        public long CategoryId { get; set; }
        public string CreationDate { get; set; }
        public bool ISInStock { get; set; } 
    }
}
