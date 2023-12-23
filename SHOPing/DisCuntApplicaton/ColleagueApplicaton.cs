using _0_Frimwork.Application;
using DicuntM_Domin.Colleague;
using Discunt_Application_Coteract.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DisCuntApplicaton
{
    public class ColleagueApplicaton : IColleagueApplication
    {
        private readonly IColleagueRepostori _colleagueRepostori;

        public ColleagueApplicaton(IColleagueRepostori colleagueRepostori)
        {
            _colleagueRepostori = colleagueRepostori;
        }

        public OpratinResult Defin(DefinColleague command)
        {
            var opratinResult = new OpratinResult();
            if (_colleagueRepostori.Exists(x => x.ProductId == command.ProductId && x.DisCountRate == command.DesCountReat))
                return opratinResult.Failed(ApplicationMessage.DuplicatedRecord);

            var Colleague = new Colleague(command.ProductId,command.DesCountReat);
            _colleagueRepostori.Create(Colleague);
            _colleagueRepostori.SaveChanges();
            return opratinResult.Succedded();




        }

        public OpratinResult Edit(EditColleague command)
        {
            var opratinResult = new OpratinResult();
            var colleage = _colleagueRepostori.Get(command.Id);
            if (colleage != null)
                return opratinResult.Failed(ApplicationMessage.DuplicatedRecord);

            if (_colleagueRepostori.Exists(x => x.ProductId == command.ProductId && x.DisCountRate == command.DesCountReat&&x.Id!=command.Id))
                return opratinResult.Failed(ApplicationMessage.DuplicatedRecord);

            colleage.Edit(command.Id, command.DesCountReat);
            _colleagueRepostori.SaveChanges();
            return opratinResult.Succedded();
        }

        public EditColleague GetDetials(long Id)
        {
           return _colleagueRepostori.GetDetials(Id);
        }

        public OpratinResult Remove(long Id)
        {
            var opratinResult = new OpratinResult();
            var colleage = _colleagueRepostori.Get(Id);
            if (colleage != null)
                return opratinResult.Failed(ApplicationMessage.DuplicatedRecord);

            colleage.Remove();
            _colleagueRepostori.SaveChanges();
            return opratinResult.Succedded();
        }

        public OpratinResult Restore(long Id)
        {
            var opratinResult = new OpratinResult();
            var colleage = _colleagueRepostori.Get(Id);
            if (colleage != null)
                return opratinResult.Failed(ApplicationMessage.DuplicatedRecord);

            colleage.Restore();
            _colleagueRepostori.SaveChanges();
            return opratinResult.Succedded();
        }

        public List<ColleagueViewModel> Search(ColleagueSearchModel searchModel)
        {
         return _colleagueRepostori.Search(searchModel);
        }
    }
}
