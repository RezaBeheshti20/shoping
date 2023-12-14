using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace shop_Domin.ProductCategoryAgg
{
    public interface IProductCategoryRepostori
    {
        void Create(ProductCategory entity);
        ProductCategory Get(long id);
        List<ProductCategory> GetAll();
        bool Exists(Expression<Func<ProductCategory,bool>>expression);
        void SaveChanges();
        ProductCategory GetDetails();
    }
}
