using _01_LampQuery.Conterctes.ProductCategoryQure;
using Microsoft.AspNetCore.Mvc;

namespace ServiesHost.ViewComponents
{
    public class ProductCategoriyWithProductViewComponet:ViewComponent
    {
        private readonly IProductCategoryQure _productCategoryQure;

        public ProductCategoriyWithProductViewComponet(IProductCategoryQure productCategoryQure)
        {
            _productCategoryQure = productCategoryQure;
        }

        public IViewComponentResult Invok()
        {
            var categoriy = _productCategoryQure.GetProductCategoriysWithProducts();
            return View(categoriy);
        }
    }
}
