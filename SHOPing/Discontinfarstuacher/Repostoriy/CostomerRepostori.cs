using _0_Frimwork.Application;
using _0_Frimwork.Infrasutacher;
using DicuntM_Domin.CustomerAgg;
using Discunt_Application_Coteract.Customer;
using Microsoft.EntityFrameworkCore;
using Shop__M_infrasutacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Discontinfarstuacher.Repostoriy
{
    public class CostomerRepostori :RepositoryBase<long,Customer> , ICustomerRepostori
    {
        
        private readonly DisCountContext _Context;
        private readonly ShopContext _shopContext;

        public CostomerRepostori(DisCountContext  context,ShopContext shopContext) : base(context)
        {
            _shopContext = shopContext;
            _Context = context;
        }

        public EditCustomer GetDitals(long id)
        {
             return _Context.Customers.Select(x => new EditCustomer
             {
                 Id = x.Id,
                 ProductId = x.ProductId,
                 Reason = x.Reason,
                 StartDate=x.StartDate.ToString(),
                 EndDate=x.EndDate.ToString(), 
               DiscontRate=x.DiscountRate

             }).FirstOrDefault(x => x.Id == id);
        }

        public List<CustomerViewModel> Search(CustomerSearchModel searchModel)
        {
            var products = _shopContext.Products.Select(x => new {x.Id,x.Name}).ToList();
            var Qure = _Context.Customers.Select(x => new CustomerViewModel
            {
                Id=x.Id,
                ProductId = x.ProductId,
                StartDate = x.StartDate.ToFarsi(),
                EndDate=x.EndDate.ToFarsi(),
                StartDateGr=x.StartDate,
                EndDateGr=x.EndDate,
                Reason=x.Reason,
                DiscontRate = x.DiscountRate
                
            });

            if (searchModel.ProductId > 0)
                Qure = Qure.Where(x => x.ProductId == searchModel.ProductId);


            if (!string.IsNullOrWhiteSpace(searchModel.StartDate))
            {
                

                Qure = Qure.Where(x => x.StartDateGr> searchModel.StartDate.ToGeorgianDateTime());
            }

            if (!string.IsNullOrWhiteSpace(searchModel.EndDate))
            {
                 

                Qure = Qure.Where(x => x.EndDateGr >searchModel. EndDate.ToGeorgianDateTime());
            }
            var disconts = Qure.OrderByDescending(x => x.Id).ToList();

            disconts.ForEach(discunt=>discunt.Product=products.FirstOrDefault(x=>x.Id == discunt.ProductId)?.Name);

            return disconts;
        }

       
    }
}
