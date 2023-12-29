
using _01_LampQuery.Conterctes.Product;
using Microsoft.AspNetCore.Mvc;

namespace ServiesHost.ViewComponents
{
    public class LatesArrivalsViewComponent:ViewComponent
    {
        private readonly IProductQure _productQure;
        public LatesArrivalsViewComponent(IProductQure productQure)
        {
            _productQure = productQure;
        }
        public IViewComponentResult Invok()
        {
            var product=_productQure.GetLatesArrivals();
            return View(product);
        }
    }
}
