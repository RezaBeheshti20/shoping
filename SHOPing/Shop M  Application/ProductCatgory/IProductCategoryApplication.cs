using _0_Frimwork.Application;
using shop_Domin.ProdutCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Application.ProductCatgory
{
    public interface IProductCategoryApplication
    {
        OpratinResult Create(CreatProductCategory command);
        OpratinResult Edite(EditProductCatgory command);
       EditProductCatgory GetDetails(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
}
