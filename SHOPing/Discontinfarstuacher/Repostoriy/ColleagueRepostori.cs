using _0_Frimwork.Infrasutacher;
using DicuntM_Domin.Colleague;
using Discunt_Application_Coteract.Colleague;
using Microsoft.EntityFrameworkCore;
using SHop__m_Domin.ProductAgg;
using Shop__M_infrasutacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discontinfarstuacher.Repostoriy
{
    public class ColleagueRepostori : RepositoryBase<long, Colleague>, IColleagueRepostori
    {
        private readonly DisCountContext _Context;
        private readonly ShopContext _shopContext;
        public ColleagueRepostori(DisCountContext  Context , ShopContext shopContext) : base(Context)
        {
            _shopContext = shopContext;
            _Context = Context;
        }

        public string product { get; private set; }

        public EditColleague GetDetials(long Id)
        {
            return _Context.Colleagues.Select(x => new EditColleague
            {
                Id = x.Id,
                DesCountReat=x.DisCountRate,
                ProductId=x.ProductId


            }).FirstOrDefault(x=>x.Id==Id);
        }

        public List<ColleagueViewModel> Search(ColleagueSearchModel searchModel)
        {
            var products=_shopContext.Products.Select(x=>new {x.Id,x.Name}).ToList();
            var Qure = _Context.Colleagues.Select(x=>new ColleagueViewModel
            {
                Id=x.Id,
                CreationDate = x.CreationDate,
                DisCuontRate = x.DisCuontRate,
                ProductId = x.ProductId
            });

            if(searchModel.ProductId>0)
            Qure =Qure.Where(x=>x.ProductId==searchModel.ProductId);

            var discont=Qure.OrderByDescending(x=>x.Id).ToList();
            discont.ForEach(discont => discont.Product = products.FirstOrDefault(x => x.Id == discont.ProductId)?.Name);
            return discont ;
        }
    }
}
