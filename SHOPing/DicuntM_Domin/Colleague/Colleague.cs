using _0_Frimwork.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicuntM_Domin.Colleague
{
    public class Colleague:EntityBase
    {
        public long ProductId { get;private set; }
        public int DisCountRate { get;private set; }
        public bool IsRemove { get; private set; }
        public int DisCuontRate { get; set; }
        public string CreationDate { get; set; }

        public Colleague(long productId, int disCountRate)
        {
            ProductId = productId;
            DisCountRate = disCountRate;
            IsRemove = false;
        }
        public void Edit(long productId, int disCountRate)
        {
            ProductId = productId;
            DisCountRate = disCountRate;
        }
        public void  Remove()
        {
            IsRemove=true;
        }
        public void Restore()
        {
            IsRemove=false;
        }

    }
}
