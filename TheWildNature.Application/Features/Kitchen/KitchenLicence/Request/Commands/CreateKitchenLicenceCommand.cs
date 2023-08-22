using MediatR;
using TheWildNature.Application.Dtos.Kitchen.KitchenLicense;

namespace TheWildNature.Application.Features.Kitchen.KitchenLicence.Request.Commands
{
    public class CreateKitchenLicenceCommand:IRequest<Unit>
    {
        public CreateKitchenLicenseDto CreateKitchenLicenseDto { get; set; }
        public int KitchenId { get; set; }
    }
}
