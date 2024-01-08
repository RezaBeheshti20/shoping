using _0_Frimwork.Infrasutacher;
using Blog_Application_Cotercts.ArticalCategorii;
using Domin_Blog_M.ArticalCategoriyAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_infarastucher_EFCore.Repostoriy
{
    public class ArticalCatagoryRepostori : RepositoryBase<long, ArticalCatagoriy>, IArticalCategoriyRepostori
    {
        private readonly blogContext _blogContext;

        public ArticalCatagoryRepostori(blogContext blogContext):base(blogContext) 
        {
            _blogContext = blogContext;
        }

        public List<ArticalCategoriyViewModel> GetArticalCategoriys()
        {
            return _blogContext.articalCatagoriys.Select(x=>new ArticalCategoriyViewModel 
            {
             Name= x.Name,
             Id= x.Id,
            }).ToList();
        }

        public EditArticalCategoriy GetDitails(long id)
        {
            return _blogContext.articalCatagoriys.Select(x=>new EditArticalCategoriy
            {
                Id = x.Id,
             CanonicalAddress =x.CanonicalAddress,
             Name = x .Name,
             ShowOrder = x .ShowOrder,
             Slug = x .Slug,    
             MetaDiscripiton = x .MetaDiscripiton,
             Description = x .Description,
             Keywords = x .Keywords,

            
            }).FirstOrDefault(x => x.Id == id);
        }

        public string GetSlugBay(long id)
        {
            return _blogContext.Articals.Select(x => new {
                x.Id,
                x.Slug
            }).FirstOrDefault(x => x.Id == id).Slug;
        }

        public List<ArticalCategoriyViewModel> Search(ArticalCategoriySearchModel searchModel)
        {
           var Qury=_blogContext.articalCatagoriys.Include(x=>x.Articals).Select(x => new ArticalCategoriyViewModel 
           {
              Id=x. Id,
            Description=x.Description,
            Name=x.Name,
            Picture=x.Picture,
            ShowOrder=x.ShowOrder,
                    
           });
            if(!string.IsNullOrWhiteSpace(searchModel.Name))
               Qury=Qury.Where(x=>x.Name.Contains(searchModel.Name));
            return Qury .OrderByDescending(x => x.ShowOrder).ToList();
        }
    }
}
