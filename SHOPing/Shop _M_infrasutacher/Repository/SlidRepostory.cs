using _0_Frimwork.Application;
using _0_Frimwork.Domin;
using _0_Frimwork.Infrasutacher;
using Microsoft.EntityFrameworkCore;
using SHop__m_Domin.SlidAgg;
using Shop_M__Applicaion__Cotexet.Slid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop__M_infrasutacher.Repository
{
    public class SlidRepostory : RepositoryBase<long, Slid>, ISlidRepostory
    {
        private readonly ShopContext _context;

        public SlidRepostory(ShopContext context):base(context) 
        {
            _context = context;
        }

        public EditSlid GetDitals(long id)
        {
           return _context.Slids.Select(s => new EditSlid
           {
               Id =s.Id,
               
               PicturAlt=s.PicturAlt,
               PicturTitel=s.PicturTitel,
               BtnText=s.BtnText,
               Text=s.Text,
               Link=s.Link,
               Heding=s.Heding,

           }).FirstOrDefault(s => s.Id == id);
        }

        public List<SlidViewModel> GetList()
        {
            return _context.Slids.Select(x=>new SlidViewModel {
                Id = x.Id,
               Heding = x.Heding,
               Pictur=x.Pictur,
               Titel=x.Titel,
               IsRemove=x.IsRemove,
               CreationDate=x.CreationData.ToFarsi(),
            }).OrderByDescending(x=>x.Id).ToList();
        }
    }
}
