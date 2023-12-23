using _0_Frimwork.Domin;
using SHop__m_Domin.ProductAgg;
using Shop_M__Applicaion__Cotexet.Slid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHop__m_Domin.SlidAgg
{
    public interface ISlidRepostory: IRepository<long, Slid>
    {
        EditSlid GetDitals(long id);
        List<SlidViewModel> GetList();

    }
}
