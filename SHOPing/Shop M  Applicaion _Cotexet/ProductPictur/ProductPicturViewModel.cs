using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.ProductPictur
{
    public class ProductPicturViewModel
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public string Pictur { get; set; }
        public string CreationDate { get; set; }
        public long ProductId { get; set; }
        public bool IsRemove { get; set; }
    }
}
