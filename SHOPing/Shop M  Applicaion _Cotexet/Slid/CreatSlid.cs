using _0_Frimwork.Application;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.Slid
{
    public  class CreatSlid
    {
        public IFormFile Pictur { get; set; }
        [Required(ErrorMessage =ValidationMessege.IsRequired)]
        public string PicturAlt { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string PicturTitel { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Heding { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Titel { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Text { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string BtnText { get; set; }
        [Required(ErrorMessage = ValidationMessege.IsRequired)]
        public string Link { get; set; }
    }
}
