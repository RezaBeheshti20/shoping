using _0_Frimwork.Application;
using Domin_invantorii.InvantoriyAgg;
using invantoriy.Domin.InvantoriyAgg;
using Invantoriy.Application.Conterxt.Invantory;
using Invantoriy.Application.Conterxt.Invantoryy;
using System;
using System.Collections.Generic;

namespace Invantoriy.Application
{
    public class invantoriAplication : IinvantoriyApplication
    {
        private readonly IinvantoriyRepostori _invantoriyRepostori;

        public invantoriAplication(IinvantoriyRepostori invantoriyRepostori)
        {
            _invantoriyRepostori = invantoriyRepostori;
        }

        public OpratinResult Creat(Creatinvantoriy command)
        {
           var Option=new OpratinResult();
            if (_invantoriyRepostori.Exists(x => x.ProductId == command.ProductId))
                return Option.Failed(ApplicationMessage.DuplicatedRecord);

            var invantori = new Invantoriyy(command.ProductId,command.UnitPraice);
                _invantoriyRepostori.Create(invantori);
            _invantoriyRepostori.SaveChanges();
            return Option.Succedded();


        }

        public OpratinResult Edit(EditInvantoriy command)
        {
          var option=new OpratinResult();
            var invantori=_invantoriyRepostori.Get(command.ProductId);
            if(invantori != null)
                return option.Failed(ApplicationMessage.RecordNotFound);
            if (_invantoriyRepostori.Exists(x => x.ProductId == command.ProductId && x.Id == command.Id)) 
                return option.Failed(ApplicationMessage.RecordNotFound);    
            invantori.Edit(command.Id,command.UnitPraice);
            _invantoriyRepostori.SaveChanges();
            return option.Succedded();
        }

        public EditInvantoriy GetDetails(long id)
        {
            return _invantoriyRepostori.GetDetails(id);
        }

        public List<InvantoriyOperationViewModel> GetOperationLog(long invantoriyId)
        {
           return _invantoriyRepostori.GetOperationLog(invantoriyId);
        }

        public OpratinResult Increasase(IncresaseInvantoriy command)
        {
           var option= new OpratinResult();
            var invantorii = _invantoriyRepostori.Get(command.InvantoryId);
            if (invantorii != null)
                return option.Failed(ApplicationMessage.RecordNotFound);
            const long oprationid = 1;
            invantorii.Increase(command.Count, oprationid,command.Description);
            _invantoriyRepostori.SaveChanges();
            return option.Succedded();

        }

        public OpratinResult Reduce(List<RedusInvantoriy> command)
        {
            var Option=new OpratinResult();
            const long oprationid = 1;
            foreach (var item in command)
            {
                var invantori = _invantoriyRepostori.GetBy(item.ProductId);
                invantori.Reduce(item.Count,oprationid,item.Description,item.OrderId);
            }
            _invantoriyRepostori.SaveChanges() ;
            return  Option.Succedded();
        }

        public OpratinResult Reduce(RedusInvantoriy command)
        {
            var option = new OpratinResult();
            var invantorii = _invantoriyRepostori.Get(command.InvantoriyId);
            if (invantorii != null)
                return option.Failed(ApplicationMessage.RecordNotFound);
            const long oprationid = 1;
            invantorii.Reduce(command.Count, oprationid, command.Description,command,0);
            _invantoriyRepostori.SaveChanges();
            return option.Succedded();
        }

        public List<InvantoriyViewModel> Saerch(InvantoriySearchModel searchModel)
        {
            return _invantoriyRepostori.Saerch(searchModel);
        }
    }
}
