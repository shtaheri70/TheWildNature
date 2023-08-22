using Microsoft.AspNetCore.Http;

namespace TheWildNature.Application.Dtos.Kitchen.KitchenLicense
{
    public interface IKitchenLicenseDto
    {
        public IFormFile LicenseFile { get; set; }
    }
}
