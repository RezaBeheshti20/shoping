using _0_Frimwork.Domin;
using Discunt_Application_Coteract.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicuntM_Domin.Colleague
{
    public interface IColleagueRepostori:IRepository<long,Colleague>
    {
        EditColleague GetDetials(long Id);
        List<ColleagueViewModel> Search(ColleagueSearchModel searchModel);
    }
}
