using _0_Frimwork.Application;
using _0_Frimwork.Infrasutacher;
using Blog_Application_Cotercts.ArticaL;
using Domin_Blog_M.ArticalAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_infarastucher_EFCore.Repostoriy
{
    public class ArticalRepostoriy : RepositoryBase<long, Artical>, IArticalRepostoriy
    {
        private readonly blogContext _blogContext;

        public ArticalRepostoriy(blogContext blogContext):base(blogContext) 
        {
            _blogContext = blogContext;
        }

        public EditArtical GetDeitails(long id)
        {
           return _blogContext.Articals.Select(x => new EditArtical
            {
               Id = x.Id,
               ShortDescription = x.ShortDescription,
               Description = x.ShortDescription,
               Slug = x.Slug,
               CanonicalAddras = x.CanonicalAddras,
               CategoryId = x.CategoryId,
               PictureAlt = x.PictureAlt,
               PictureTiTle = x.PictureTiTle,
               PublisDate = x.PublisDate.ToFarsi(),
               Titel=x.Titel,
               MetaDescription=x.MetaDescription,
               

            }).FirstOrDefault(x=>x.Id==id);
        }

        public Artical GetWithCategory(long id)
        {
            return _blogContext.Articals.Include(x=>x.Catagoriy).FirstOrDefault(x=>x.Id==id);
        }

        public List<ArticalViewModel> Search(ArticalSearchModel searchModel)
        {
            var Qure = _blogContext.Articals.Select(x => new ArticalViewModel
            {
                Id = x.Id,
                Titel = x.Titel,
                Category = x.Catagoriy.Name,
                ShortDescription = x.ShortDescription,
                Picture = x.Picture,
                PublisDate=x.PublisDate.ToFarsi(),

            });
            if (!string.IsNullOrWhiteSpace(searchModel.TiTle)) 
            Qure = Qure.Where(x => x.Titel.Contains(searchModel.TiTle));
            return Qure.OrderByDescending(x => x.Id).ToList();
                
        }
    }
}
