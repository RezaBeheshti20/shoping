using _0_Frimwork.Infrasutacher;
using SHop__m_Domin.ProductCategoryAgg;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using System.Collections.Generic;
using System.Linq;
 

namespace Shop__M_infrasutacher.Repository
{
    public class ProductCategoryRepository : RepositoryBase<long, ProductCategory>, IProuctCategoryReposetory
    {
        private readonly ShopContext _Context;

        public ProductCategoryRepository(ShopContext  Context)  :base(Context) 
        {
            _Context =  Context;
        }
 
        public EditProductCatgory GetDetails(long id)
        {
          return _Context.ProductCategories.Select(x => new EditProductCatgory()
          {
            Id =x.Id,
            Name = x.Name,
            Description=x.Description,
            MetaDescription=x.MetaDescription,
            Picture=x.Picture,
            PictureAlt=x.PictureAlt,
            PictureTitle=x.PictureTitle,
            Slug=x.Slug,
            Keywords=x.Keywords,

          }).FirstOrDefault(x=>x.Id==id); 
        }
 

        public List<ProductCategoryViewModel> SearCh(ProductCategorySareChModel SearChModel)
        {
            var reza = _Context.ProductCategories.Select(x => new ProductCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CreationDate = x.CreationData.ToString(),
            });
            if(string.IsNullOrWhiteSpace(SearChModel .Name))
            reza=reza.Where(x=>x.Name.Contains(SearChModel.Name));

            return reza.OrderByDescending(x=>x.Id).ToList();    
        }
    }
}
