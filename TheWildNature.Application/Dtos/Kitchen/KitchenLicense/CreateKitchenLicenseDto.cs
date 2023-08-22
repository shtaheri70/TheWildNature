using Microsoft.AspNetCore.Http;

namespace TheWildNature.Application.Dtos.Kitchen.KitchenLicense
{
    public class CreateKitchenLicenseDto : IKitchenLicenseDto
    {
        public IFormFile LicenseFile { get; set; }
    }
}
