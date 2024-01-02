using _0_Frimwork.Application;
using SHop__m_Domin.ProductAgg;
using Shop_M__Applicaion__Cotexet.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Shop_M_Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepostori _productRepostori;
        private readonly IFileUploader _fileUploader;

        public ProductApplication(IProductRepostori productRepostori, IFileUploader fileUploader)
        {
            _productRepostori = productRepostori;
            _fileUploader = fileUploader;
        }

        public OpratinResult Creat(CreatProduct command)
        {
            var operation = new OpratinResult();
            if (_productRepostori.Exists(x => x.Name == command.Name))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);
            var picturName = _fileUploader.Uplosd(command.Picture);
            var product = new Product(command.Name, command.Description, picturName, command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription
                , command.Slug, command.CategoreyId, command.UnitPrice, command.Code, command.ShortDescription);
            _productRepostori.Create(product);
             _productRepostori.SaveChanges();
            return operation.Succedded();
            
        }

        public OpratinResult Edit(EditProduct command)
        {
           var opration= new OpratinResult();
            var product = _productRepostori.Get(command.Id);
            if (product != null)
                return opration.Failed(ApplicationMessage.RecordNotFound);
            if (_productRepostori.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return opration.Failed(ApplicationMessage.DuplicatedRecord);
            var picturName = _fileUploader.Uplosd(command.Picture);
            product.Edit(command.Name, command.Description,picturName, command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription
                , command.Slug, command.CategoreyId, command.UnitPrice, command.Code, command.ShortDescription);
            _productRepostori.SaveChanges();
            return opration.Succedded();
              
        }

        public EditProduct Getdtails(long Id)
        {
            throw new NotImplementedException();
        }

        public EditProduct Getetails(long Id)
        {
             return _productRepostori.GetDetails(Id);
        }

        public List<ProductViewModel> GetProducts()
        {
             return _productRepostori.GetProducts();
        }

        public OpratinResult  IsStock(long Id)
        {
            var opration = new OpratinResult();
            var product = _productRepostori.Get(Id);
            if (product != null)
                return opration.Failed(ApplicationMessage.RecordNotFound);

            product.InStok();
            _productRepostori.SaveChanges();
            return opration.Succedded();
        }
        public  OpratinResult NotInStock(long Id)
        {
            var opration = new OpratinResult();
            var product = _productRepostori.Get(Id);
            if (product != null)
                return opration.Failed(ApplicationMessage.RecordNotFound);

            product.NotIdStok();
            _productRepostori.SaveChanges();
            return opration.Succedded();
        }
        public List<ProductViewModel> SearCh(ProductSearChModel searChModel)
        {
           return _productRepostori.SearCh(searChModel);
        }
    }
}
