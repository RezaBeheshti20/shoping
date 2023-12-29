using _01_LampQuery.Conterctes.ProductCategoryQure;
using Microsoft.AspNetCore.Mvc;

namespace ServiesHost.ViewComponents
{
    public class MenuViewCompont:ViewComponent
    {
        private readonly IProductCategoryQure _productCategoryQure;

        public MenuViewCompont(IProductCategoryQure productCategoryQure)
        {
            _productCategoryQure = productCategoryQure;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
