using _0_Frimwork.Application;
using _0_Frimwork.Infrasutacher;
using Commant_Application.Conterxt.Comment;
using Commant_Domin.CommentAgg; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Commant_infarstucter_EFCore.Repository
{
    public class CommantRepostoriy : RepositoryBase<long, Commant>, ICommentRepostoriy
    {
        private readonly CoomentContext _coomentContext;

        public CommantRepostoriy(CoomentContext coomentContext):base(coomentContext)
        {
            _coomentContext = coomentContext;
        }

        public List<CommentViewModel> Search(CommentSearchModel searchModel)
        {
            var Qury = _coomentContext.Commants .Select(c => new CommentViewModel
            {
               Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Website=c.WebSoit,
                OwnerRecordId=c.OwnerRecordId,
                Type=c.Type,
                IsCancel = c.IsCancel,
                IsConfirmad= c.IsConfirmad,
             
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
