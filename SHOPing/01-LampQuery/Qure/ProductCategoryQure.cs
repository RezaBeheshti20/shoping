using _01_LampQuery.Conterctes.ProductCategoryQure;
using Shop__M_infrasutacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Qure
{
    public class ProductCategoryQure : IProductCategoryQure
    {
        private readonly ShopContext _shopContext;

        public ProductCategoryQure(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public List<ProductCategoryQureModel> GetProductCategories()
        {
         return _shopContext.ProductCategories.Select(c => new ProductCategoryQureModel 
         { 
         
          Name = c.Name,
          Pictur=c.Picture,
          PicturAlt=c.PictureAlt,
          PicturTitel=c.PicturTitle,
          Slug=c.Slug,
         
         
         }).ToList();
        }
    }
}
