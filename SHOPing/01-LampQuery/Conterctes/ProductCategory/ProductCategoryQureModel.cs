using _01_LampQuery.Conterctes.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Conterctes.ProductCategoryQure
{
    public class ProductCategoryQureModel
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public string Pictur { get; set; }
        public string PicturAlt { get; set; }
        public string PicturTitel { get; set; }
        public string MetaDescription { get; set; }
        public string Desciption { get; set; }
        public string Keywords { get; set; }
        public string Slug { get; set; }
        public List<ProductQureModel> Products { get; set; }
    }
}
