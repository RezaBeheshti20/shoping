
using _01_LampQuery.Conterctes.Artical;
using _01_LampQuery.Conterctes.Product;
using Microsoft.AspNetCore.Mvc;

namespace ServiesHost.ViewComponents
{
    public class LatesArticalViewComponent:ViewComponent
    {
        private readonly IArticalQurycs _articalQurycs;

        public LatesArticalViewComponent(IArticalQurycs articalQurycs)
        {
            _articalQurycs = articalQurycs;
        }

        public IViewComponentResult Invok()
        {
            var artical = _articalQurycs.LatesArticals();
            return View( artical);
        }
    }
}
