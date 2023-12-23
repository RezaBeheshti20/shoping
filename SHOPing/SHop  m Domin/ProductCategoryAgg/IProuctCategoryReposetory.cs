using _0_Frimwork.Domin;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SHop__m_Domin.ProductCategoryAgg
{
    public interface IProuctCategoryReposetory:IRepository<long,ProductCategory>
    {
        List<ProductCategoryViewModel> GetProductCategorys();
        EditProductCatgory GetDetails(long id);
        List<ProductCategoryViewModel> SearCh(ProductCategorySareChModel SearChModel);


    }
}
