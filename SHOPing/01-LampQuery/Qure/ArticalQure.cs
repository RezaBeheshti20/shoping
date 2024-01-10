using _0_Frimwork.Application;
using _01_LampQuery.Conterctes.Artical;
using _01_LampQuery.Conterctes.Comment;
using blog_infarastucher_EFCore;
using Commant_infarstucter_EFCore;
using Microsoft.EntityFrameworkCore;
using SHop__m_Domin.ProductAgg;
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
        private readonly CoomentContext _coomentContext;

        public ArticalQure(blogContext context, CoomentContext coomentContext)
        {
            _Context = context;
            _coomentContext = coomentContext;
        }

        public ArticalQuryModel GetArticalDeitailes(string slug)
        {
            var artical= _Context.Articals.Include(x => x.Catagoriy).Where(x => x.PublisDate <= DateTime.Now).Select(x => new ArticalQuryModel
            {
                Id = x.Id,
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


            artical.Commants=_coomentContext.Commants.Where(x => x.Type == CommatType.Product)
              .Where(x => x.OwnerRecordId == artical.Id)
              .Where(x => !x.IsCancel)
              .Where(x => x.IsConfirmad)
              .Select(x => new CommantQureModel
              {
                  Name = x.Name,
                  Massege = x.Mesasseg,
                  Id = x.Id,
                  PrantId=x.ParntId,
                  ParantName=x.Parnt.Name,
                  CreationDate=x.CreationData.ToFarsi()

              }).OrderByDescending(x => x.Id).ToList();

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
