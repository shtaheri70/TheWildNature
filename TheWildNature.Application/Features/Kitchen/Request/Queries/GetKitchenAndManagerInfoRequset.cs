using MediatR;
using TheWildNature.Application.Dtos.Kitchen;

namespace TheWildNature.Application.Features.Kitchen.Request.Queries
{
    public class GetKitchenAndManagerInfoRequset:IRequest<UpdateKitchenAndKitchenManagerInfoDto>
    {
        public int UserId { get; set; }
    }
}
