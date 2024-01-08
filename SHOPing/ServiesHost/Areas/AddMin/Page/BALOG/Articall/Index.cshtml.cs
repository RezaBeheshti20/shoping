using Blog_Application;
using Blog_Application_Cotercts.ArticaL;
using Blog_Application_Cotercts.ArticalCategorii;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using Shop_M__Applicaion__Cotexet.ProductCategoryy;
using System.Collections.Generic;

namespace ServiesHost.Areas.AddMin.Page.BLOG.Articall
{
    public class IndexModel : PageModel
    {
        public ArticalSearchModel SareChModel;
        public List<ArticalViewModel> Articals;
        public SelectList ArticalCategoris;
        private readonly IArticalApplication _articalApplication;
        private readonly IArticalCategoriyApplicationcs _articalCategoriyApplicationcs;
        public IndexModel(IArticalApplication articalApplication,IArticalCategoriyApplicationcs articalCategoriyApplicationcs)
        {
            _articalCategoriyApplicationcs = articalCategoriyApplicationcs;
           _articalApplication = articalApplication;
        }


        
        public void OnGet(ArticalSearchModel sareChModel)
        {
            ArticalCategoris=new SelectList(_articalCategoriyApplicationcs.GetArticalCategoriys(),"Id","Name");
            Articals = _articalApplication.Search(sareChModel);
        }
      
    }
}
