using _0_Frimwork.Application;
using _0_Frimwork.Infrasutacher;
using Microsoft.EntityFrameworkCore;
using SHop__m_Domin.CommentAgg;
using Shop_M__Applicaion__Cotexet.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop__M_infrasutacher.Repository
{
    public class CommantRepostoriy : RepositoryBase<long, Commant>, ICommentRepostoriy
    {
        private readonly ShopContext _shopContext;

        public CommantRepostoriy(ShopContext shopContext):base(shopContext) 
        {
            _shopContext = shopContext;
        }

        public List<CommentViewModel> Search(CommentSearchModel searchModel)
        {
            var Qury = _shopContext.Commants.Include(x=>x.Products).Select(c => new CommentViewModel
            {
               Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                ProductId = c.ProductId,
                IsCancel = c.IsCancel,
                IsConfirmad= c.IsConfirmad,
                ProductName=c.Products.Name,
                CommantDate=c.CreationData.ToFarsi()
            });
            if (string.IsNullOrWhiteSpace(searchModel.Name)) 
               Qury=Qury.Where(x=>x.Name.Contains(searchModel.Name));
            if (string.IsNullOrWhiteSpace(searchModel.Email))
                Qury = Qury.Where(x => x.Name.Contains(searchModel.Email));
            return Qury.OrderByDescending(x=>x. Id).ToList();
        }
    }
}
