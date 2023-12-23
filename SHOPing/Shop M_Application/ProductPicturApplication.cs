using _0_Frimwork.Application;
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
        private readonly IProductPicturRpostory _productPicturRpostory;
        public ProductPicturApplication(IProductPicturRpostory productPicturRpostory) 
        {
            _productPicturRpostory = productPicturRpostory;
            
        }
        public OpratinResult Creat(CreatProductPictur command)
        {
            var Option=new OpratinResult();
            if(_productPicturRpostory.Exists(x=>x.Pictur==command.Pictur && x.ProductId==command.ProductId))
                return Option.Failed(ApplicationMessage.DuplicatedRecord);

            var productPictur = new ProductPictur(command.Pictur,command.ProductId,command.PicturAlt,command.PicturTitel);
            _productPicturRpostory.Create(productPictur);
            _productPicturRpostory.SaveChanges();
            return Option.Succedded();

        }

        public OpratinResult Edit(EditProductPictur command)
        {
            var option =new OpratinResult();
            var productpictur = _productPicturRpostory.Get(command.Id);
            if(productpictur != null)
                return option.Failed(ApplicationMessage .RecordNotFound);
            if(_productPicturRpostory.Exists(x => x.Pictur == command.Pictur && x.ProductId == command.ProductId&& x.Id!=command.Id))
                return option.Failed(ApplicationMessage.DuplicatedRecord);
            productpictur.Edit(command.ProductId,command.Pictur,command.PicturTitel,command.PicturAlt);
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
