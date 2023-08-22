using MediatR;
using TheWildNature.Application.Dtos.Kitchen.KitchenManager;

namespace TheWildNature.Application.Features.Kitchen.KitchenManager.Request.Queries
{
    public class GetKitchenManagerRequest:IRequest<KitchenManagerDto>
    {
        public int UserId { get; set; }
    }
}
