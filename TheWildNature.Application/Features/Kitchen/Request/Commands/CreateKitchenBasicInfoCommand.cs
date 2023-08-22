using MediatR;
using TheWildNature.Application.Dtos.Kitchen;
using TheWildNature.Application.Response;

namespace TheWildNature.Application.Features.Kitchen.Request.Commands
{
    public class CreateKitchenBasicInfoCommand:IRequest<BaseCommandResponse>
    {
        public CreateKitchenBaiscInfoDto RegisterKitchenBaiscInfoDto { get; set; }
    }
}
