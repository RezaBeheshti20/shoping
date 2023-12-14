using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Frimwork.Domin
{
    public class EntityBase
    {
        public long Id { get; set; }


        public DateTime CreationData { get; set; }

        public EntityBase() 
        {
         CreationData = DateTime.Now;
        }
    }
}
