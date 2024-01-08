using _01_LampQuery.Conterctes.Artical;
using _01_LampQuery.Conterctes.ArticalCategoriy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiesHost.Pages
{
    public class ArticlModel : PageModel
    {
        public ArticalQuryModel Artical;
        private readonly IArticalQurycs _articalQurycs;
        public List<ArticalQuryModel> LatesArticals;
        private readonly IArticalCategoryQure _articalCategoryQure;
        public List<ArticalCategoriyQureModel> ArticalCategoriys;
        public ArticlModel(IArticalQurycs articalQurycs,IArticalCategoryQure articalCategoryQure)
        {
            _articalQurycs = articalQurycs;
            _articalCategoryQure = articalCategoryQure;
        }

        public void OnGet(string id)
        {
            Artical = _articalQurycs.GetArticalDeitailes(id);
            LatesArticals = _articalQurycs.LatesArticals();
            ArticalCategoriys=_articalCategoryQure.GetArticalCategoriys();
            
        }
    }
}
