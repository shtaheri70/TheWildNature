using MediatR;
using TheWildNature.Application.Dtos.Kitchen;

namespace TheWildNature.Application.Features.Kitchen.Request.Commands
{
    public class UpdateKitchenAndManagerInfoCommand:IRequest<Unit>
    {
        public UpdateKitchenAndKitchenManagerInfoDto KitchenDto { get; set; }
    }
}
