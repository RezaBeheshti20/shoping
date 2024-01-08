using _0_Frimwork.Application;
using _01_LampQuery.Conterctes.Artical;
using blog_infarastucher_EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Qure
{
    public class ArticalQure : IArticalQurycs
    {
        private readonly blogContext _Context;

        public ArticalQure(blogContext context)
        {
            _Context = context;
        }

        public ArticalQuryModel GetArticalDeitailes(string slug)
        {
            var artical= _Context.Articals.Include(x => x.Catagoriy).Where(x => x.PublisDate <= DateTime.Now).Select(x => new ArticalQuryModel
            {
                Titel = x.Titel,
                ShortDescription = x.ShortDescription,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTiTle = x.PictureTiTle,
                CanonicalAddras = x.CanonicalAddras,
                CategoryId = x.CategoryId,
                CategoryName = x.Catagoriy.Name,
                Description = x.Description,
                MetaDescription = x.MetaDescription,
                Kewords = x.Kewords,
                Slug = x.Slug,
                CategorytSlug = x.Catagoriy.Slug,
                PublisDate = x.PublisDate.ToFarsi(),

            }).FirstOrDefault(x=>x.Slug==x.Slug);

            if(!string.IsNullOrWhiteSpace(artical.Kewords)) 

            artical.Keywordlist=artical.Kewords.Split(',').ToList();

            return artical;
        }
        

        public List<ArticalQuryModel> LatesArticals()
        {
            return _Context.Articals.Include(x=>x.Catagoriy).Where(x=>x.PublisDate<=DateTime.Now).Select(x => new ArticalQuryModel
            {
                Titel = x.Titel,
                ShortDescription = x.ShortDescription,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTiTle = x.PictureTiTle,
                Slug = x.Slug,

            }).ToList();
        }
    }
}
