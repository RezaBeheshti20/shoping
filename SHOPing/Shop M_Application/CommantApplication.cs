using _0_Frimwork.Application;
using SHop__m_Domin.CommentAgg;
using Shop_M__Applicaion__Cotexet.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M_Application
{
    public class CommantApplication : ICommentApplication
    {
        private readonly ICommentRepostoriy _commentRepostoriy;

        public CommantApplication(ICommentRepostoriy commentRepostoriy)
        {
            _commentRepostoriy = commentRepostoriy;
        }

        public OpratinResult Add(AddComment comment)
        {
            var opration=new OpratinResult();
            var Commant = new Commant(comment.Name, comment.Email, comment.Mesasseg, comment.ProductId);
            _commentRepostoriy.Create(Commant);
            _commentRepostoriy.SaveChanges();
            return opration.Succedded();
        }

        public OpratinResult Cancel(long id)
        {
            var opration = new OpratinResult();
            var Commant = _commentRepostoriy.Get(id);
                if (Commant == null)
                return opration.Failed(ApplicationMessage.RecordNotFound);

                Commant.Cancelad();

            _commentRepostoriy.SaveChanges();
            return opration.Succedded();
        }

        public OpratinResult Confirm(long id)
        {
            var opration = new OpratinResult();
            var Commant = _commentRepostoriy.Get(id);
            if (Commant == null)
                return opration.Failed(ApplicationMessage.RecordNotFound);

            Commant.Confirmad();

            _commentRepostoriy.SaveChanges();
            return opration.Succedded();
        }

        public List<CommentViewModel> Search(CommentSearchModel searchModel)
        {
            return _commentRepostoriy.Search(searchModel);
        }
    }
}
