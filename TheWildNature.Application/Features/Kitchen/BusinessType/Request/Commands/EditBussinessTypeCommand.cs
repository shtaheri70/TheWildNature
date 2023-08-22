using MediatR;
using TheWildNature.Application.Dtos.Kitchen.BussinesType;

namespace TheWildNature.Application.Features.Kitchen.BusinessType.Request.Commands
{
    public class EditBussinessTypeCommand:IRequest<Unit>
    {
        public BussinessTypeDto BussinessTypeDto { get; set; }
    }
}
