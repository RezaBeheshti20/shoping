using _0_Frimwork.Application;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace ServiesHost
{
    public class FileUploader : IFileUploader
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUploader(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public string Uplosd(IFormFile file,string path)
        {
            if (file == null)
                return "";
             var  pathDi=$"{_webHostEnvironment.WebRootPath}/ProductPictuer/{path}//{file.FileName}";
            if (!Directory.Exists(pathDi)) 
                Directory.CreateDirectory(pathDi);



            var fileName =$"{DateTime.Now.ToFileName()} -{file.FileName}";

            var fileUpath = $"{pathDi}//{fileName}";

            using var output=System.IO.File.Create(path);

            file.CopyTo(output);

            return $"{path}/{fileName}";
                
        }

        public string Uplosd(IFormFile picture)
        {
            throw new System.NotImplementedException();
        }
    }
}
