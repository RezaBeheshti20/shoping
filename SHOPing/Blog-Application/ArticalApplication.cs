using _0_Frimwork.Application;
using Blog_Application_Cotercts.ArticaL;
using Domin_Blog_M.ArticalAgg;
using Domin_Blog_M.ArticalCategoriyAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Application
{
    public class ArticalApplication : IArticalApplication
    {
        private readonly IArticalRepostoriy _articalRepostoriy;
        private readonly IFileUploader _fileUploader;
        private readonly IArticalCategoriyRepostori _articalCategoriyRepostori;

        public ArticalApplication(IArticalRepostoriy articalRepostoriy, IFileUploader fileUploader,IArticalCategoriyRepostori articalCategoriyRepostori)
        {
            _articalRepostoriy = articalRepostoriy;
            _articalCategoriyRepostori = articalCategoriyRepostori;
            _fileUploader = fileUploader;
        }

        public OpratinResult Creat(CreatArtical command)
        {
           var Oration= new OpratinResult();
            if (_articalRepostoriy.Exists(c => c.Titel == command.Titel))
                return Oration.Failed(ApplicationMessage.DuplicatedRecord);

            var catSlug = _articalCategoriyRepostori.GetSlugBay(command.CategoryId);
            var slug = command.Slug;
            var filNamee = _fileUploader.Uplosd(command.Picture, slug);
            var pablicDat=command.PublisDate.ToGeorgianDateTime();
            var arttical=new Artical(command.Titel,command.ShortDescription,command.Description,pablicDat,filNamee,command.PictureAlt,command.PictureTiTle
                ,command.Slug,command.Kewords,command.MetaDescription,command.CanonicalAddras,command.CategoryId);
            _articalRepostoriy.Create(arttical);
            _articalRepostoriy.SaveChanges();
            return Oration.Succedded();
        }

        public OpratinResult Edit(EditArtical command)
        {
            var opration = new OpratinResult();
            var artic=_articalRepostoriy.GetWithCategory(command.CategoryId);
            if(artic==null)
                return opration.Failed(ApplicationMessage.DuplicatedRecord);


            if (_articalRepostoriy.Exists(c => c.Titel == command.Titel &&c.Id!=command.Id))
                return  opration.Failed(ApplicationMessage.DuplicatedRecord);

            var slug = command.Slug;
            var path=$"{artic.Catagoriy.Slug}/{slug}";
            var pablicDat = command.PublisDate.ToGeorgianDateTime();
            var filNamee = _fileUploader.Uplosd(command.Picture);


            artic.Edit(command.Titel, command.ShortDescription, pablicDat, filNamee, command.PictureAlt, command.PictureTiTle
                , slug, command.Kewords, command.MetaDescription
                , command.CanonicalAddras,command.Description,command.CategoryId);
            _articalRepostoriy.SaveChanges();
            return opration.Succedded();


        }

        public EditArtical GetDeitails(long id)
        {
            return _articalRepostoriy.GetDeitails(id);
        }

        public List<ArticalViewModel> Search(ArticalSearchModel searchModel)
        {
          return _articalRepostoriy.Search(searchModel);
        }
    }
}
