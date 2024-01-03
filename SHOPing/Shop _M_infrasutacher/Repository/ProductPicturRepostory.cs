using _0_Frimwork.Infrasutacher;
using Microsoft.EntityFrameworkCore;
using SHop__m_Domin.ProductPicturAgg;
using Shop_M__Applicaion__Cotexet.ProductPictur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop__M_infrasutacher.RepositoryBase
{
    public class ProductPicturRepostory : RepositoryBase<long, ProductPictur>, IProductPicturRpostory
    {
     private readonly ShopContext _Context;
        public ProductPicturRepostory(ShopContext context):base(context)
        {
            _Context = context;
            
        }
 
        public EditProductPictur GetDetails(long id)
        {
             return _Context.ProductPicturs.Select(p => new EditProductPictur
             {
              
                PicturAlt=p.PicturAlt,
                PicturTitel=p.PicturTitel,
                ProductId=p.ProductId


             }).FirstOrDefault(x=>x.Id==id);
        }

        public ProductPictur GetProductAndCategoriy(long id)
        {
             return _Context.ProductPicturs.Include(x=>x.Product).ThenInclude(x=>x.Category).FirstOrDefault(x=>x.Id==id);
        }

        public List<ProductPicturViewModel> SearCh(ProductPicturSearChModel searChModel)
        {
             var REZA= _Context.ProductPicturs.Include(x=>x.Product).Select(x => new ProductPicturViewModel
            {
                Product=x.Product.Name,
                Id=x.Id,
                Pictur = x.Pictur,
                ProductId=x.ProductId,
                CreationDate =x.CreationData.ToString(),
                IsRemove=x.IsRemove,
              
            });

            if (searChModel.ProductId != 0)
                REZA = REZA.Where(x => x.ProductId == searChModel.ProductId);
            return REZA.OrderByDescending(x => x.Id).ToList();

        }
    }
}
