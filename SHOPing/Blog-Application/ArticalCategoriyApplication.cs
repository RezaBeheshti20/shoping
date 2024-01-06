using _0_Frimwork.Application;
using Blog_Application_Cotercts.ArticalCategorii;
using Domin_Blog_M.ArticalCategoriyAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Application
{
    public class ArticalCategoriyApplication : IArticalCategoriyApplicationcs
    {
        private readonly IArticalCategoriyRepostori _articalCategoriyRepostori;
        private readonly IFileUploader _fileUploader;
        public ArticalCategoriyApplication(IArticalCategoriyRepostori articalCategoriyRepostori, IFileUploader fileUploader)
        {
            _articalCategoriyRepostori = articalCategoriyRepostori;
            _fileUploader = fileUploader;
        }

        public OpratinResult Creat(CreatArticalCategoriy command)
        {
           var option= new OpratinResult();
            if (_articalCategoriyRepostori.Exists(x => x.Name == command.Name))
                return option.Failed(ApplicationMessage.DuplicatedRecord);

            var slug=command.Slug;
            var ppicname = _fileUploader.Uplosd(command.Picture);

            var articaCategori = new ArticalCatagoriy(command.Name, ppicname, command.Description, command.ShowOrder
                , command.Slug, command.Keywords, command.MetaDiscripiton, command.CanonicalAddress);
            _articalCategoriyRepostori.Create(articaCategori);
            _articalCategoriyRepostori.SaveChanges();
            return option.Succedded();
        }

        public OpratinResult Edit(EditArticalCategoriy command)
        {
           var opration= new OpratinResult();
            var art = _articalCategoriyRepostori.Get(command.Id);
            if(art==null)
                return opration.Failed(ApplicationMessage.DuplicatedRecord);

            
            if (_articalCategoriyRepostori.Exists(x => x.Name == command.Name&&x.Id!=command.Id))
                return opration.Failed(ApplicationMessage.DuplicatedRecord);


            var ppicname = _fileUploader.Uplosd(command.Picture);
            art.Edit(command.Name, ppicname, command.Description, command.ShowOrder
                , command.Slug, command.Keywords, command.MetaDiscripiton, command.CanonicalAddress);

            _articalCategoriyRepostori.SaveChanges();
            return opration.Succedded();
        }

        public EditArticalCategoriy GetDitails(long id)
        {
            return _articalCategoriyRepostori.GetDitails(id);
        }

        public List<ArticalCategoriyViewModel> Search(ArticalCategoriySearchModel searchModel)
        {
           return _articalCategoriyRepostori.Search(searchModel);
        }
    }
}
