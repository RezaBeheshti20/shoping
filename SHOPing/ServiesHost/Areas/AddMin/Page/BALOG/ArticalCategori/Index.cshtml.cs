using Blog_Application_Cotercts.ArticalCategorii;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using Shop_M__Applicaion__Cotexet.ProductCategoryy;
using System.Collections.Generic;

namespace ServiesHost.Areas.AddMin.Page.BLOG.ArticalCategori
{
    public class IndexModel : PageModel
    {
        public ArticalCategoriySearchModel SareChModel;
        public List<ArticalCategoriyViewModel> ArticalCategoriys;
        private readonly IArticalCategoriyApplicationcs _articalCategoriyApplicationcs;
        public IndexModel(IArticalCategoriyApplicationcs articalCategoriyApplicationcs)
        {
           _articalCategoriyApplicationcs = articalCategoriyApplicationcs;
        }


        
        public void OnGet(ArticalCategoriySearchModel sareChModel)
        {

            ArticalCategoriys = _articalCategoriyApplicationcs.Search(sareChModel);
        }
        public IActionResult OnGetCreate()
        {
            return Partial("./Creat", new CreatArticalCategoriy());
        }
        public  JsonResult OnPostCreat(CreatArticalCategoriy command)
        {
            var result=_articalCategoriyApplicationcs.Creat(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetEdit(long Id)
        {
            var productCategory=_articalCategoriyApplicationcs.GetDitails(Id);
            return Partial("Edit", productCategory);

        }
        public JsonResult OnPostEdit(EditArticalCategoriy command)
        {
           
            var REZA=_articalCategoriyApplicationcs.Edit(command);
            return new JsonResult(REZA);
        }

    }
}
