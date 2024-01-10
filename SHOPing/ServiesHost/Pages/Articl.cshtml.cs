using _01_LampQuery.Conterctes.Artical;
using _01_LampQuery.Conterctes.ArticalCategoriy;
using Commant_Application.Conterxt.Comment;
using Commant_infarstucter_EFCore;
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
        private readonly ICommentApplication _commentApplication;
        public ArticlModel(IArticalQurycs articalQurycs,IArticalCategoryQure articalCategoryQure, ICommentApplication commentApplication)
        {
            _articalQurycs = articalQurycs;
            _articalCategoryQure = articalCategoryQure;
            _commentApplication = commentApplication;
        }

        public void OnGet(string id)
        {
            Artical = _articalQurycs.GetArticalDeitailes(id);
            LatesArticals = _articalQurycs.LatesArticals();
            ArticalCategoriys=_articalCategoryQure.GetArticalCategoriys();
            
        }
        public IActionResult OnPost(AddComment comment, string articalSlug)
        {
            comment.Type = CommatType.Product;
            var Qure = _commentApplication.Add(comment);
            return RedirectToPage("/Artical", new { Id =  articalSlug});
        }
    }
}
