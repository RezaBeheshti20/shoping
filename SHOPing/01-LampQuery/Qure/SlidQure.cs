using _01_LampQuery.Conterctes.Slid;
using Shop__M_infrasutacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Qure
{
    public class SlidQure : ISlidQure
    {
        private readonly ShopContext _ShopContext;
        public SlidQure(ShopContext context)
        {
            _ShopContext = context;
        }
        public List<SlidQureModel> GetSlids()
        {
            return _ShopContext.Slids.Where(x=>x.IsRemove==false).Select(x=>new SlidQureModel
            {
                Pictur=x.Pictur,
                PicturAlt=x.PicturAlt,
                PicturTitel=x.PicturTitel,
                Text=x.Text,
                Titel=x.Titel,
                BtnText=x.BtnText,
                Heding=x.Heding,
                Link=x.Link,

            }).ToList();
        }
    }
}
