using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Conterctes.Product
{
    public class ProductQureModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string PicturTitel { get; set; }
        public string PicturAlt { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public  string PriceWithDisCount { get; set; }
        public int DisCountRate { get; set; }
        public string Categoriy { get; set; }
        public string Slug { get; set; }
        public bool HasDiscount { get; set; }
        public string DiscountExpireDate { get; set; }
    }
}
