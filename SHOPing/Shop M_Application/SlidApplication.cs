using _0_Frimwork.Application;
using SHop__m_Domin.SlidAgg;
using Shop_M__Applicaion__Cotexet.Slid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Shop_M_Application
{
    public class SlidApplication : ISlidApplication
    {
        private readonly ISlidRepostory _slidRepostory;

        public SlidApplication(ISlidRepostory slidRepostory)
        {
            _slidRepostory = slidRepostory;
        }

        public OpratinResult Creat(CreatSlid command)
        {
          var Option = new OpratinResult();
            var slid = new Slid(command.Pictur, command.PicturAlt,command.Link ,command.PicturTitel
                , command.Heding, command.Text, command.BtnText,command.Titel);

            _slidRepostory.Create(slid);
            _slidRepostory.SaveChanges();
            return Option.Succedded();

        }

        public OpratinResult Edit(EditSlid command)
        {
           var option=new OpratinResult();
            var slid = _slidRepostory.Get(command.Id);
            if (slid == null)
                return option.Failed(ApplicationMessage.RecordNotFound);
            slid.Edit(command.Pictur,command.Text,command.Titel,command.PicturTitel, command.Link, command.PicturAlt,command.BtnText);
            _slidRepostory.SaveChanges();
            return option.Succedded();  

        }

        public EditSlid GetDetails(long id)
        {
           return _slidRepostory.GetDitals(id);
        }

        public List<SlidViewModel> Getlist()
        {
           return _slidRepostory.GetList();
        }

        public OpratinResult Remove(long id)
        {
            var option = new OpratinResult();
            var slid = _slidRepostory.Get(id);
            if (slid == null)
                return option.Failed(ApplicationMessage.RecordNotFound);
            slid.Remove();
            _slidRepostory.SaveChanges();
            return option.Succedded();
        }

        public OpratinResult Restor(long id)
        {
            var option = new OpratinResult();
            var slid = _slidRepostory.Get(id);
            if (slid == null)
                return option.Failed(ApplicationMessage.RecordNotFound);
            slid.Restor();
            _slidRepostory.SaveChanges();
            return option.Succedded();
        }
    }
}
