using _01_LampQuery.Conterctes.ProductCategoryQure;
using _01_LampQuery.Qure;
using Microsoft.AspNetCore.Mvc;

namespace ServiesHost.ViewComponents
{
    public class ProductCategoryViewComponets:ViewComponent
    {
        private readonly IProductCategoryQure _productCategoryQure;

        public ProductCategoryViewComponets(IProductCategoryQure productCategoryQure)
        {
            _productCategoryQure = productCategoryQure;
        }

        public IViewComponentResult Invok()
        {
            var productCategorys=_productCategoryQure.GetProductCategories();
            return View(productCategorys);
        }
    }
}
