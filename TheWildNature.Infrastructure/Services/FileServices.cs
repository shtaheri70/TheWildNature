using Microsoft.AspNetCore.Http;
using TheWildNature.Application.Contracts.Infrastructure;
using TheWildNature.Application.Generator;

namespace TheWildNature.Infrastructure.Services
{
    public class FileServices : IFilesServise
    {
        public async Task<string> AddFileAsync(IFormFile fileData, string filePath)
        {
            string fileName = NameGenerator.GenerateUniqCode() + Path.GetExtension(fileData.FileName);
            string financialFilePath = Path.Combine(Directory.GetCurrentDirectory(),
              $"wwwroot/{filePath}", fileName);
            using (var stream = new FileStream(financialFilePath, FileMode.Create))
            {
                fileData.CopyTo(stream);
            }

            return fileName;
        }
    }
}
