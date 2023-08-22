using Microsoft.AspNetCore.Http;
using TheWildNature.Application.Dtos.Common;

namespace TheWildNature.Application.Dtos.Kitchen.KitchenLicense
{
    public class EditKitchenLicenseDto : BaseDto, IKitchenLicenseDto
    {
        public IFormFile LicenseFile { get; set; }
        public string LicenseFileName { get; set; }
    }
}
