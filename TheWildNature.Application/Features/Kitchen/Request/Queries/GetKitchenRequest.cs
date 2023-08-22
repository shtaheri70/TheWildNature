using MediatR;
using TheWildNature.Application.Dtos.Kitchen;

namespace TheWildNature.Application.Features.Kitchen.Request.Queries
{
    public class GetKitchenRequest:IRequest<KitchenDto>
    {
        public int KitchenId { get; set; }
    }
}
