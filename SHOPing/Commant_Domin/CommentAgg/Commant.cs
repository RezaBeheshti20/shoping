using _0_Frimwork.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commant_Domin.CommentAgg
{
    public class Commant:EntityBase
    {
        public string Name { get;private set; }
        public string Email { get;private set; }
        public string Mesasseg { get;private set; }
        public string WebSoit { get;private set; }
        public bool IsConfirmad { get;private set; }
        public bool IsCancel { get;private set; }
        public long OwnerRecordId { get;private set; }
        public int Type { get;private set; }
        public long ParntId { get;private set; }
        public Commant Parnt { get;private set; }
        public List<Commant> Childran { get;private set; }
     
        public Commant(string name, string email, string webSoit, string mesasseg, long ownerRecordId, int type, long parntId)
        {
            Name = name;
            Email = email;
            WebSoit = webSoit;
            Mesasseg = mesasseg;
            OwnerRecordId = ownerRecordId;
            Type = type;
            ParntId = parntId;
        }

        public void Confirmad()
        { 
            IsConfirmad = true;
        }
        public void Cancelad()
        {
            IsCancel = true;
        }
    }
    
}
