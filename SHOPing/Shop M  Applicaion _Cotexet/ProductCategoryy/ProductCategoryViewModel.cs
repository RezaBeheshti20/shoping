﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.ProductCategory
{
    public class ProductCategoryViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public string Picture { get; set; }
        public string CreationDate { get; set; }
        public string ProductsCount { get; set; }
    }
}
