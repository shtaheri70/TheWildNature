using Microsoft.AspNetCore.Http;

namespace TheWildNature.Application.Contracts.Infrastructure
{
    public interface IFilesServise
    {
        Task<string> AddFileAsync(IFormFile fileData, string filePath);
    }
}
