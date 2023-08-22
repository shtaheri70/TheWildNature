using MediatR;
using TheWildNature.Application.Dtos.Kitchen;

namespace TheWildNature.Application.Features.Kitchen.Request.Commands
{
    public class EditKitchenCommand:IRequest<Unit>
    {
        public KitchenDto  KitchenDto { get; set; }
        
    }
}
