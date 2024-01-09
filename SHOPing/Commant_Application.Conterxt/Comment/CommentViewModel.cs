using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commant_Application.Conterxt.Comment
{
    public class CommentViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Mesasseg { get; set; }
        public long OwnerRecordId { get; set; }
        public string OwnerName { get; set; }
        public  int Type { get; set; }
        public bool IsConfirmad { get;   set; }
        public bool IsCancel { get;   set; }
        public string CommantDate { get; set; }
    }
}
