using _0_Frimwork.Application;
using Commant_Application.Conterxt.Comment;
using Commant_Domin.CommentAgg;
using System.Collections.Generic;

namespace Commant_Application
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
            var Commant = new Commant(comment.Name, comment.Email,comment.WebSoit
                , comment.Mesasseg, comment.OwnerRecordId, comment.Type, comment.ParntId);
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
