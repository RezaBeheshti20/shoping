using _01_LampQuery.Conterctes.ProductCategoryQure;
using Microsoft.AspNetCore.Mvc;

namespace ServiesHost.ViewComponents
{
    public class FooterViewCompont:ViewComponent
    {
        

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
