using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_M__Applicaion__Cotexet.Comment
{
    public class CommentViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mesasseg { get; set; }
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public bool IsConfirmad { get;   set; }
        public bool IsCancel { get;   set; }
        public string CommantDate { get; set; }
    }
}
