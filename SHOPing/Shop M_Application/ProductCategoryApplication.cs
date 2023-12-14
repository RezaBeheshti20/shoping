﻿using _0_Frimwork.Application;
using SHop__m_Domin.ProductCategoryAgg;
using Shop_M__Applicaion__Cotexet.ProductCategory;
using Shop_M__Applicaion__Cotexet.ProductCategoryy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M_Application
{
    public class ProductCategoryApplication : IProductCategoryApplicaton
    {
        private readonly IProuctCategoryReposetory _prouctCategoryReposetory;

        public ProductCategoryApplication(IProuctCategoryReposetory prouctCategoryReposetory)
        {
            _prouctCategoryReposetory = prouctCategoryReposetory;
        }

        public  OpratinResult Create(CreatProductCategory command)
        {
           var opration=new OpratinResult();
            if (_prouctCategoryReposetory.Exists(x=>x.Name==command.Name))
                return opration.Failed("تکراری لطفا مجدد تلاش کنید");

            var productCategory=new ProductCategory(command.Name,command.Picture,command.MetaDescription,command.Description
                ,command.PictureTitle,command.PictureAlt,command.Slug,command.Keywords);

            _prouctCategoryReposetory.Create(productCategory);
            _prouctCategoryReposetory.SaveChanges();
            return opration.Succedded();


        }

        public  OpratinResult Edit(EditProductCatgory command)
        {
           var opration= new OpratinResult();
            var productCategory=_prouctCategoryReposetory.Get(command.Id);

            if (productCategory != null)
                return opration.Failed("تکراری لطفا مجدد تلاش کنید");
            if (_prouctCategoryReposetory.Exists(x => x.Name == command.Name && x.Id != command.Id)) 
            return opration.Failed("تکراری لطفا مجدد تلاش کنید");

            productCategory.Edit(command.Name, command.Picture, command.MetaDescription, command.Description
                , command.PictureTitle, command.PictureAlt, command.Slug, command.Keywords);
            _prouctCategoryReposetory.SaveChanges();
            return opration.Succedded();



        }

        public EditProductCatgory GetDetails(long id)
        {
            return _prouctCategoryReposetory.GetDetails(id);
        }

        public List<ProductCategoryViewModel> SearCh(ProductCategorySareChModel SearChmodel)
        {
            return _prouctCategoryReposetory.SearCh(SearChmodel);
        }
    }
}
