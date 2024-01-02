using _0_Frimwork.Application;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.ProductCategory
{
    public  class CreatProductCategory
    {
        [Required(ErrorMessage=ValidationMessege.IsRequired)]
        public string Name { get;   set; }
        public string Description { get;  set; }
        [Required(ErrorMessage=ValidationMessege.IsRequired)]
        [FileExtentionLimitation(new string[] {"jpeg","jpg","png"},ErrorMessage =ValidationMessege.InValidFileForm)]
        [MaxFileSize(3 * 1024,ErrorMessage =ValidationMessege.MaxFileSize)]
        public IFormFile Picture { get;  set; }
        public string PictureAlt { get;   set; }
        public string PictureTitle { get;    set; }
        public string PicturTitle { get;    set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Keywords { get;   set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string MetaDescription { get;   set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Slug { get;   set; }
    }
}
