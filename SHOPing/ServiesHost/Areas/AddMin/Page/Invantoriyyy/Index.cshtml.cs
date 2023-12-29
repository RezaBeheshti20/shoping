using Invantoriy.Application.Conterxt.Invantory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop_M__Applicaion__Cotexet.Product;
using System.Collections.Generic;

namespace ServiceHost.Areas.Administration.Pages.Invantoriyyy
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public InvantoriySearchModel SearchModel;
        public List<InvantoriyViewModel> invantoriyViewModels;
        public SelectList Products;

        private readonly IProductApplication _productApplication;
        private readonly IinvantoriyApplication _iinvantoriyApplication;

        public IndexModel(IProductApplication ProductApplication, IinvantoriyApplication iinvantoriyApplication)
        {
            _productApplication = ProductApplication;
            _iinvantoriyApplication = iinvantoriyApplication;
        }

        public void OnGet(InvantoriySearchModel searchModel)
        {
            Products = new SelectList(_productApplication.GetProducts(), "Id", "Name");
            invantoriyViewModels = _iinvantoriyApplication.Saerch(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new Creatinvantoriy
            {
                Products = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(Creatinvantoriy command)
        {
            var result = _iinvantoriyApplication.Creat(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var invantoriy = _iinvantoriyApplication.GetDetails(id);
            invantoriy.Products = _productApplication.GetProducts();
            return Partial("Edit", invantoriy);
        }

        public JsonResult OnPostEdit(EditInvantoriy command)
        {
            var result = _iinvantoriyApplication.Edit(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetIncrease(long id)
        {

            var command = new IncresaseInvantoriy()
            {

                InvantoryId = id
            };
            return Partial("Increase", command);


        }
        public JsonResult OnPostIncrease(IncresaseInvantoriy command)
        {
            var result = _iinvantoriyApplication.Increasase(command);
            return new JsonResult(result);
        }
        public IActionResult OnGetReduce(long id)
        {

            var command = new RedusInvantoriy()
            {

                InvantoriyId = id
            };
            return Partial("Increase", command);
        }

        public JsonResult OnPostReduce(RedusInvantoriy command)
        {
            var result = _iinvantoriyApplication.Reduce(command);
            return new JsonResult(result);
        }
        public IActionResult OnGtLog(long id)
        {
            var log=_iinvantoriyApplication.GetOperationLog(id);
            return Partial("OprationLog", log);
        }



    }
} 
