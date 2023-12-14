using _0_Frimwork.Application;
using shop_Domin.ProductCategoryAgg;
using Shop_M__Application.ProductCatgory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop__M___Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepostori _productCategoryRepostori;
        public ProductCategoryApplication(IProductCategoryRepostori productCategoryRepostori)
        {
            _productCategoryRepostori = productCategoryRepostori;
        }
        public OpratinResult Create(CreatProductCategory command)
        {
           var opration= new OpratinResult();
            if (_productCategoryRepostori.Exists(x => x.Name == command.Name)) 
            return opration.Failed("تکراری . لطفا محددتلاش فرمایید");



            var productCategory=new ProductCategory(command.Name,command.Picture,command.Description,command.MetaDescription
              , command.PictureTitle, command.PictureAlt, command.Description, command.Keywords, command.Slug);


            
            _productCategoryRepostori.Create(productCategory);
           _productCategoryRepostori.SaveChanges();
            return opration.Succedded();

        }

        public OpratinResult Edite(EditProductCatgory command)
        {
            var opration=new OpratinResult();
            var productCatgory = _productCategoryRepostori.Get(command.Id);
            if (productCatgory != null)
                return opration.Failed("تکراری . لطفا محددتلاش فرمایید");



            if (_productCategoryRepostori.Exists(X => X.Name == command.Name && X.Id != command.Id))
                return opration.Failed("تکراری . لطفا محددتلاش فرمایید");


            productCatgory.Edit(command.Name, command.Picture, command.Description, command.MetaDescription
               , command.PictureTitle, command.PictureAlt, command.Description, command.Keywords, command.Slug);



            _productCategoryRepostori.SaveChanges();
            return opration.Succedded();

        }

        public EditProductCatgory GetDetails(long id)
        {
            return _productCategoryRepostori.GetDetails(id); 
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            return _productCategoryRepostori.SearCh(searchModel);
        }
    }
}
