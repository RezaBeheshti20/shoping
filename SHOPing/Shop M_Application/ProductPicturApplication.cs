using _0_Frimwork.Application;
using SHop__m_Domin.ProductAgg;
using SHop__m_Domin.ProductPicturAgg;
using Shop_M__Applicaion__Cotexet.ProductPictur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Shop_M_Application
{
    public class ProductPicturApplication : IProductPicturApplication
    { 
        private readonly IFileUploader _fileUploader;
        private readonly IProductRepostori _productpostory;
        private readonly IProductPicturRpostory _productPicturRpostory;
        public ProductPicturApplication(IProductPicturRpostory productPicturRpostory,IProductRepostori productRepostori,IFileUploader fileUploader)
        {
            _productPicturRpostory = productPicturRpostory;
             _productpostory = productRepostori;
            _fileUploader = fileUploader;
        }
        public OpratinResult Creat(CreatProductPictur command)
        {
            var Option=new OpratinResult();
            //if(_productPicturRpostory.Exists(x=>x.Pictur==command.Pictur && x.ProductId==command.ProductId))
            //    return Option.Failed(ApplicationMessage.DuplicatedRecord);
            var productpictur = _productpostory.GetProductWihtCategory(command.ProductId);
            var pictur = _fileUploader.Uplosd(command.Pictur);

            var productPictur = new ProductPictur(pictur,command.ProductId,command.PicturAlt,command.PicturTitel);
            _productPicturRpostory.Create(productPictur);
            _productPicturRpostory.SaveChanges();
            return Option.Succedded();

        }

        public OpratinResult Edit(EditProductPictur command)
        {
            var option =new OpratinResult();
            var productpictur = _productPicturRpostory.GetProductAndCategoriy(command.Id);
            if(productpictur != null)
                return option.Failed(ApplicationMessage .RecordNotFound);

            var product  = _productpostory.GetProductWihtCategory(command.ProductId);
            var pictur = _fileUploader.Uplosd(command.Pictur);


            productpictur.Edit(command.ProductId, pictur,command.PicturTitel,command.PicturAlt);
            _productPicturRpostory.SaveChanges();
            return option.Succedded();  
        }

        public EditProductPictur GetDetails(long Id)
        {
            return _productPicturRpostory.GetDetails(Id);
        }

        public OpratinResult Remove(long Id)
        {
            var option = new OpratinResult();
            var productpictur = _productPicturRpostory.Get (Id);
            if (productpictur != null)
                return option.Failed(ApplicationMessage.RecordNotFound);
            
            productpictur.Remove();
            _productPicturRpostory.SaveChanges();
            return option.Succedded();
        }
        public OpratinResult Restor(long Id)
        {
            var option = new OpratinResult();
            var productpictur = _productPicturRpostory.Get(Id);
            if (productpictur != null)
                return option.Failed(ApplicationMessage.RecordNotFound);
            ;
            productpictur.Restor();
            _productPicturRpostory.SaveChanges();
            return option.Succedded();
        }

        public List<ProductPicturViewModel> SearCh(ProductPicturSearChModel searChModel)
        {
            return _productPicturRpostory.SearCh(searChModel);
        }
    }
}
