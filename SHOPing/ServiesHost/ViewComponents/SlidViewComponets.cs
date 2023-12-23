using _01_LampQuery.Conterctes.Slid;
using Microsoft.AspNetCore.Mvc;

namespace ServiesHost.ViewComponents
{
    public class SlidViewComponets:ViewComponent
    {
        private readonly ISlidQure _slidQure;

        public SlidViewComponets(ISlidQure slidQure)
        {
            _slidQure = slidQure;
        }

        public IViewComponentResult Invoke()
        {
            var slids= _slidQure.GetSlids();
            return View(slids);
        }
    }
}
