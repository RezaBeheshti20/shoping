using _0_Frimwork.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicuntM_Domin.CustomerAgg
{
    public class Customer:EntityBase
    {
        public long ProductId { get;private set; }
        public int DiscountRate { get;private set; }
        public DateTime StartDate { get;private set; }
        public DateTime EndDate { get;private set; }
        public string Reason { get;private set; }

        public Customer(long productId, int discountRate, DateTime startDate, DateTime endDate, string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
        }
        public void Edit(long productId, int discountRate, DateTime startDate, DateTime endDate, string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
        }
    }
}
