using Microsoft.AspNetCore.Http;

namespace sattec.Identity.Application.Common.Interfaces
{
    public interface IFileService
    {
        Guid Upload(IFormFile file);

    }
}
