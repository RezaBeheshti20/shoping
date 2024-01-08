using _01_LampQuery.Conterctes.Artical;
using _01_LampQuery.Conterctes.ArticalCategoriy;
using blog_infarastucher_EFCore;
using Domin_Blog_M.ArticalAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LampQuery.Qure
{
    public class ArticalCategoryQury : IArticalCategoryQure
    {
        private readonly blogContext _blogContext;

        public ArticalCategoryQury(blogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public ArticalCategoriyQureModel GetArticalCategoriy(string slug)
        {
            var ArticallCategory= _blogContext.articalCatagoriys
                    .Select
                (x=>new ArticalCategoriyQureModel 
                {
                 Picture = x.Picture,
                 Description = x.Description,
                 ShowOrder = x.ShowOrder,
                 Keywords = x.Keywords,
                 Slug = x.Slug,
                 Name = x.Name,
                 Articals= MapArticals(x.Articals),
                }).FirstOrDefault(x=>x.Slug == slug);

              
            if(!string.IsNullOrWhiteSpace(ArticallCategory.Keywords))

               ArticallCategory.KeywordList=ArticallCategory.Keywords.Split(',').ToList();

            return ArticallCategory;
        }

        private static List<ArticalQuryModel> MapArticals(List<Artical> articals)
        {
            return articals.Select(x=>new ArticalQuryModel
            {
                Picture= x.Picture,             
                ShortDescription= x.ShortDescription,
                Slug= x.Slug,
               Titel=x.Titel,
               PictureAlt= x.PictureAlt,
               PictureTiTle= x.PictureTiTle,
               

            }).ToList();
        }

        public List<ArticalCategoriyQureModel> GetArticalCategoriys()
        {
           return _blogContext.articalCatagoriys.Include(x=>x.Articals).Select(x=>new ArticalCategoriyQureModel
           {
              Name = x.Name,
              Picture = x.Picture,
              Slug = x.Slug,
              ShowOrder = x.ShowOrder,
             
         }).ToList();
        }
    }
}
