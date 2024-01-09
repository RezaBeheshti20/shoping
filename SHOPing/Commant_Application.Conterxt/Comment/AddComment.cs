using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commant_Application.Conterxt.Comment
{
    public class AddComment
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mesasseg { get; set; }
        public string WebSoit  { get; set; }
        public long OwnerRecordId { get;  set; }
        public int Type { get;  set; }
        public long ParntId { get;  set; }
    }
}
