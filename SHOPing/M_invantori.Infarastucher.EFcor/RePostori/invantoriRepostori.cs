using _0_Frimwork.Application;
using _0_Frimwork.Domin;
using _0_Frimwork.Infrasutacher;
using Domin_invantorii.InvantoriyAgg;
using invantoriy.Domin.InvantoriyAgg;
using Invantoriy.Application.Conterxt.Invantory;
using Invantoriy.Application.Conterxt.Invantoryy;
using SHop__m_Domin.ProductAgg;
using Shop__M_infrasutacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_invantori.Infarastucher.EFcor.RePostori
{
    public class invantoriRepostori : RepositoryBase<long, Invantoriyy>, IinvantoriyRepostori
    {
     private readonly invantoriContext _invantoriContext;
        private readonly ShopContext _shopContext;
      

        public invantoriRepostori(invantoriContext invantoriContext,ShopContext shopContext):base(invantoriContext) 
        {
           shopContext = _shopContext;
            _invantoriContext = invantoriContext;
        }

        public Invantoriyy GetBy(long productId)
        {
            return _invantoriContext.Invantoriyys.FirstOrDefault(X => X.ProductId == productId);
        }

        

        public EditInvantoriy GetDetails(long id)
        {
          return _invantoriContext.Invantoriyys.Select(x=>new EditInvantoriy
          {
              Id = id,
              ProductId = x.ProductId,
              UnitPraice=x.UnitParice


          }).FirstOrDefault(x=>x.Id==id);
        }

        public List<InvantoriyOperationViewModel> GetOperationLog(long invantoriyId)
        {
              var invantori=_invantoriContext.Invantoriyys.FirstOrDefault(x=>x.Id==invantoriyId);
            return invantori.Oprations.Select(x=>new InvantoriyOperationViewModel {
             Id = x.Id,
             Count = x.Count,
             CurrentCount = x.CurrentCount,
             Description = x.Description,
             Opration=x.Opration,
             OprationDate=x.OprationDate.ToFarsi(),
             OprationId=x.OprationId,
             OrderId=x.OrderId, 
            
            
            
            
            }).ToList();
        }

        public List<InvantoriyViewModel> Saerch(InvantoriySearchModel searchModel)
        {
            var products = _shopContext.Products.Select(x => new {x.Id,x.Name}).ToList();

            var Qure = _invantoriContext.Invantoriyys.Select(x => new InvantoriyViewModel
            {
                Id = x.Id,
                ProductId = x.ProductId,
                UnitPrice = x.UnitParice,
                InStock = x.InStock,
                CurntCunt = x.CalculateCurrentInvantoriy(),
                CreationDate=x.CreationData.ToFarsi(),
            });
            if(searchModel.ProductId>0)
                Qure=Qure.Where(x=>x.ProductId==searchModel.ProductId);
            if (searchModel.InStock)
                Qure = Qure.Where(x => !x.InStock);
            var invantoriy=Qure.OrderByDescending(x=>x.Id).ToList();

            invantoriy.ForEach(item =>
            {
                item.Product = products.FirstOrDefault(x => x.Id == item.ProductId)?.Name;
               
            });
            return invantoriy;
        }

    }
}
