using MediatR;
using TheWildNature.Application.Dtos.Kitchen.FinancialInfo;

namespace TheWildNature.Application.Features.Kitchen.FinancialInfo.Request.Commands
{
    public class CreateKitchenFinancialInfoCommand:IRequest<Unit>
    {
        public CreateKitchenFinancialInfoDto KitchenFinancialInfoDto { get; set; }
        public int KitchenId { get; set; }
    }
}
