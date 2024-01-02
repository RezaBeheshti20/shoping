using _0_Frimwork.Application;
using Microsoft.AspNetCore.Http;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.Product
{
    public class CreatProduct
    {
        [Required(ErrorMessage =ValidationMessege.IsRequired)]
        public string Name { get;  set; }
        public string Description { get;   set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Code { get;   set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public double UnitPrice { get;   set; }
        public IFormFile Picture { get;   set; }
        public string PictureAlt { get;   set; }
        public string PictureTitle { get;   set; }
        public string PicturTitle { get;   set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Keywords { get;   set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string MetaDescription { get;   set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string ShortDescription { get;   set; }
        [Range(1,100000,ErrorMessage = ValidationMessege.IsRequired)]
        public long CategoreyId { get;  set; }
        public bool IsInStok { get;  set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Slug { get;   set; }
        public List<ProductCategoryViewModel>Categorys { get; set; }
    }
}
