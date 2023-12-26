using _0_Frimwork.Domin;
using Invantoriy.Application.Conterxt.Invantory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin_invantorii.InvantoriyAgg
{
    public class Invantoriyy : EntityBase
    {

        public long ProductId { get;private set; }
        public double UnitParice { get;private set; }
        public bool InStock { get;private set; }
        public List<InvantoriyOpration> Oprations { get; private set;}
        public string CurrentCount { get; private set; }

        public Invantoriyy(long productId, double unitParice)
        {
            ProductId = productId;
            UnitParice = unitParice;
            InStock = false;
        }
        public void Edit(long productId, double unitParice)
        {
            ProductId = productId;
            UnitParice = unitParice; 
        }
        public long CalculateCurrentInvantoriy()
        {
            var Plus = Oprations.Where(x => x.Opration).Sum(x => x.Count);
            var minus = Oprations.Where(x => !x.Opration).Sum(x => x.Count);

            return Plus - minus;
        }

        public void Increase(long count,long oprationId,string description)
        {
           var currentCount = CalculateCurrentInvantoriy() + count;
            var option = new InvantoriyOpration(true, count, oprationId, currentCount, description, 0, Id);
            Oprations.Add(option);
            InStock =currentCount>0;
           
        }
        public void Reduce(long count, long oprationId, string description,long orderId)
        {
            var currentCount = CalculateCurrentInvantoriy() + count;
            var option = new InvantoriyOpration(false, count, oprationId, currentCount, description, orderId, Id);
            Oprations.Add(option);
            InStock = currentCount > 0;
        }

        public void Reduce(long count, long oprationid, string description, RedusInvantoriy command, int v)
        {
            throw new NotImplementedException();
        }
    }
  
    public class InvantoriyOpration
    {
        public long Id { get;private set; }
        public bool Opration { get;private set; }
        public long Count { get;private set; }
        public long OprationId { get;private set; }
        public DateTime OprationDate { get;private set; }
        public long CurrentCount { get;private set; }
        public string Description { get; private set; }
        public long OrderId { get;private set; }
        public long InvantoriyId { get;private set; }
        public Invantoriyy Invantoriy { get;private set; }

        public InvantoriyOpration(bool opration, long count, long oprationId, long currentCount, string description, long orderId, long invantoriyId)
        {
            Opration = opration;
            Count = count;
            OprationId = oprationId;
            CurrentCount = currentCount;
            Description = description;
            OrderId = orderId;
            InvantoriyId = invantoriyId;
         
        }
    }
}
