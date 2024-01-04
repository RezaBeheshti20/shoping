using _0_Frimwork.Domin;
using SHop__m_Domin.ProductAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHop__m_Domin.CommentAgg
{
    public class Commant:EntityBase
    {
        public string Name { get;private set; }
        public string Email { get;private set; }
        public string Mesasseg { get;private set; }
        public bool IsConfirmad { get;private set; }
        public bool IsCancel { get;private set; }
        public long ProductId { get;private set; }
        public Product Product { get;private set; }
        public Commant(string name,string email,string message,long productId)
        {
            Name = name;
            Email = email;
            Mesasseg = message;
            ProductId = productId;
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
