using Blog_Application_Cotercts.ArticaL;
using Blog_Application_Cotercts.ArticalCategorii;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiesHost.Areas.AddMin.Page.BALOG.Articall
{
    public class EditModel : PageModel
    {
        public EditArtical Command;
        public SelectList ArticleCategories;

        private readonly IArticalApplication _articleApplication;
        private readonly IArticalCategoriyApplicationcs _articleCategoryApplication;

        public EditModel(IArticalApplication articleApplication, IArticalCategoriyApplicationcs articleCategoryApplication)
        {
            _articleApplication = articleApplication;
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(long id)
        {
            Command = _articleApplication.GetDeitails(id);
            ArticleCategories = new SelectList(_articleCategoryApplication.GetArticalCategoriys(), "Id", "Name");
        }

        public IActionResult OnPost(EditArtical command)
        {
            var result = _articleApplication.Edit(command);
            return RedirectToPage("./Index");
        }
    }
}
