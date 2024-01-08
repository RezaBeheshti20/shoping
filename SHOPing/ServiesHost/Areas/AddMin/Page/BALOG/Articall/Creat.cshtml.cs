using Blog_Application_Cotercts.ArticaL;
using Blog_Application_Cotercts.ArticalCategorii;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiesHost.Areas.AddMin.Page.BALOG.Articall
{
    public class CreatModel : PageModel
    {
        public CreatArtical command;
        public SelectList ArticalCategoriys;
        private readonly IArticalApplication _articalApplication;
        private readonly IArticalCategoriyApplicationcs _articalCategoriyApplicationcs;

        public CreatModel(IArticalCategoriyApplicationcs articalCategoriyApplicationcs, IArticalApplication articalApplication)
        {
            _articalCategoriyApplicationcs = articalCategoriyApplicationcs;
            _articalApplication = articalApplication;
        }

        public void OnGet()
        {
            ArticalCategoriys=new SelectList(_articalCategoriyApplicationcs.GetArticalCategoriys(),"Id","Name");
        }
        public IActionResult onPost(CreatArtical command)
        {
            var rezlt=_articalApplication.Creat(command);
            return RedirectToPage("./Index");
        }
    }
}
