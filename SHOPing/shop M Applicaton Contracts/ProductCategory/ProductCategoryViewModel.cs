using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_M_Applicaton_Contracts.ProductCategory
{
    public class ProductCategoryViewModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }
        public string CreationDate { get; set; }
        public long ProductsConunt { get; set; }
    }
}
