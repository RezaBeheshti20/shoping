using _0_Frimwork.Application;
using Shop_M__Applicaion__Cotexet.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.ProductPictur
{
    public class CreatProductPictur
    {
        [Range(1,10000,ErrorMessage =ValidationMessege.IsRequired)]
        public long ProductId { get;   set; }
        [Range(1, 10000, ErrorMessage = ValidationMessege.IsRequired)]
        public string Pictur { get;   set; }
        [Range(1, 10000, ErrorMessage = ValidationMessege.IsRequired)]
        public string PicturAlt { get;   set; }
        [Range(1, 10000, ErrorMessage = ValidationMessege.IsRequired)]
        public string PicturTitel { get;  set; }
        public  List<ProductViewModel> Products { get; set; }    
    }
}
