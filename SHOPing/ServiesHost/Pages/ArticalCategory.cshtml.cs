using _01_LampQuery.Conterctes.Artical;
using _01_LampQuery.Conterctes.ArticalCategoriy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiesHost.Pages
{
    public class ArticalCategoryModel : PageModel
    {
        public ArticalCategoriyQureModel GetArticalCategoriy;
        public List<ArticalCategoriyQureModel> GetArticalCategoriys;
        public List<ArticalQuryModel> LatesArticals;
        private readonly IArticalCategoryQure _articalCategoryQure;
        private readonly IArticalQurycs _articalQurycs;

        public ArticalCategoryModel(IArticalQurycs articalQurycs,IArticalCategoryQure articalCategoryQure)
        {
            _articalCategoryQure = articalCategoryQure;
            _articalQurycs = articalQurycs;
        }

        public void OnGet(string id)
        {
            GetArticalCategoriy=_articalCategoryQure.GetArticalCategoriy(id);
            GetArticalCategoriys = _articalCategoryQure.GetArticalCategoriys();
            LatesArticals=_articalQurycs.LatesArticals();   
        }
    }
}
