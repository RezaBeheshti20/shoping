using _01_LampQuery.Conterctes.Product;
using Commant_Application.Conterxt.Comment;
using Commant_infarstucter_EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace ServiesHost.Pages
{
    public class ProductModel : PageModel
    {
        public ProductQureModel Product;
        private readonly ICommentApplication _commentApplication;
        private readonly IProductQure _productQure;

        public ProductModel(IProductQure productQure,ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
            _productQure = productQure;
        }

        public void OnGet(string id)
        {
            Product=_productQure.GetDitails(id);
        }
        public IActionResult OnPost(AddComment comment)
        {
            comment.Type = CommatType.Product;
            var Qure=_commentApplication.Add(comment);
            return RedirectToPage("/Product",new { Id = comment.ParntId });
        }
    }
}
