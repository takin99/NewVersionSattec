using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using sattec.Identity.Application.Common.Interfaces;

namespace sattec.Identity.Infrastructure.Identity
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment env;

        public FileService(IWebHostEnvironment env)
        {
            this.env = env;
        }

        public Guid Upload(IFormFile file)
        {
            var uploadDirecotroy = "uploads/";
            var uploadPath = Path.Combine(env.WebRootPath, uploadDirecotroy);

            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(uploadPath, fileName);

            using (var strem = File.Create(filePath))
            {
                file.CopyTo(strem);
            }
            return new Guid(fileName);
        }
    }
}
