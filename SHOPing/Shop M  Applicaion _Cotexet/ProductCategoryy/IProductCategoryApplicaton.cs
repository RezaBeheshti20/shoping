
using _0_Frimwork.Application;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using System.Collections.Generic;

namespace Shop_M__Applicaion__Cotexet.ProductCategoryy
{
    public interface IProductCategoryApplicaton
    {
         OpratinResult Create(CreatProductCategory command);
        OpratinResult Edit(EditProductCatgory command);
        EditProductCatgory GetDetails(long id);
        List<ProductCategoryViewModel> GetProductCategories();
         List<ProductCategoryViewModel>SearCh(ProductCategorySareChModel SearChmodel);
    }
}
