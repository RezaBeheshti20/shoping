using _0_Frimwork.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHop__m_Domin.SlidAgg
{
    public class Slid : EntityBase
    {
        public string Pictur { get;private set; }
        public string PicturAlt { get;private set; }
        public string PicturTitel { get;private set; }
        public string Heding { get;private set; }
        public string Titel { get;private set; }
        public string Text { get;private set; }
        public string BtnText { get;private set; }
        public string Link { get;private set; }
        public bool IsRemove { get;private set; }

        public Slid(string pictur, string picturAlt, string picturTitel, string heding, string titel,string link,string text, string btnText)
        {
            Pictur = pictur;
            PicturAlt = picturAlt;
            PicturTitel = picturTitel;
            Heding = heding;
            Titel = titel;
            Text = text;
            BtnText = btnText;
            Link = link;
            IsRemove = false;
        }
        public void Edit(string pictur, string picturAlt, string link, string picturTitel, string heding, string titel, string text, string btnText)
        {
            if(!string.IsNullOrWhiteSpace(pictur))
            Pictur = pictur;
            PicturAlt = picturAlt;
            PicturTitel = picturTitel;
            Heding = heding;
            Titel = titel;
            Text = text;
            Link = link;
            BtnText = btnText;

        }
        public void Remove()
        {
            IsRemove = true;
        }
        public void Restor()
        {
            IsRemove = false;
        }

        public void Edit(string pictur, string text, string titel, string picturTitel, string picturAlt, string btnText)
        {
            throw new NotImplementedException();
        }

        public void Edit(string pictur, string text, string titel, string picturTitel, string link, string picturAlt, string btnText)
        {
            throw new NotImplementedException();
        }
    }
}
