using _0_Frimwork.Application;
using DicuntM_Domin.CustomerAgg;
using Discunt_Application_Coteract.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisCuntApplicaton
{
    public class CustomerApplication : ICustomerApplication
    {
        private readonly ICustomerRepostori _cuctomerRepostori;

        public CustomerApplication(ICustomerRepostori cuctomerRepostori)
        {
            this._cuctomerRepostori = cuctomerRepostori;
        }

        public OpratinResult Defin(DefinCostomer command)
        {
            var option =new OpratinResult();
            if (_cuctomerRepostori.Exists(x => x.ProductId == command.ProductId && x.DiscountRate == command.DiscontRate))
                return option.Failed(ApplicationMessage.DuplicatedRecord);


            var startDate=command.StartDate.ToGeorgianDateTime();
            var enDate=command.EndDate.ToGeorgianDateTime();
            var Customer=new Customer(command.ProductId,command.DiscontRate,startDate,enDate,command.Reason);
            _cuctomerRepostori.Create(Customer);
            _cuctomerRepostori.SaveChanges();
            return option.Succedded();
        }

        public OpratinResult Edit(EditCustomer command)
        {
           var opration=new OpratinResult();
            var customer = _cuctomerRepostori.Get(command.Id);

            if(customer == null)
                return opration.Failed(ApplicationMessage.RecordNotFound);

            if(_cuctomerRepostori.Exists(x => x.ProductId == command.ProductId && x.DiscountRate == command.DiscontRate&&x.Id==command.Id))
                opration.Failed(ApplicationMessage.DuplicatedRecord);

            var startDate = command.StartDate.ToGeorgianDateTime();
            var enDate = command.EndDate.ToGeorgianDateTime();
            customer.Edit(command.ProductId, command.DiscontRate, startDate, enDate, command.Reason);
            _cuctomerRepostori.SaveChanges();
           return opration.Succedded();
             
        }

        public EditCustomer GetDetails(long id)
        {
          return _cuctomerRepostori.GetDitals(id);
        }

        public List<CustomerViewModel> Search(CustomerSearchModel searchModel)
        {
          return _cuctomerRepostori.Search(searchModel); 
        }
    }
}
