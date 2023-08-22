using MediatR;
using TheWildNature.Application.Dtos.Kitchen.BussinesType;

namespace TheWildNature.Application.Features.Kitchen.BusinessType.Request.Commands
{
    public class CreateBussinessTypeCommand:IRequest<int>
    {
        public CreateBussinessTypeDto BussinessTypeDto { get; set; } = new CreateBussinessTypeDto();
    }
}
