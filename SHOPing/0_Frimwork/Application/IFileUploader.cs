using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Frimwork.Application
{
    public interface IFileUploader
    {
        string Uplosd(IFormFile file,string path);
        string Uplosd(IFormFile picture);
    }
}
