using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Frimwork.Application
{
    public  class OpratinResult
    {
        public bool IsSuccedded { get; set; }
        public string Message { get; set; }

        public OpratinResult() 
        {
         IsSuccedded = false;
        }
        public OpratinResult Succedded(string message="عملایت باموفقیت انجام شد") 
        {
          IsSuccedded = true;
            Message = message;
            return this;
        }
        public OpratinResult Failed(string message)
        {
            IsSuccedded=false;
            Message = message;
            return this;
        }
    }
    
}
