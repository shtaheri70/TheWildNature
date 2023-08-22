using MediatR;
using TheWildNature.Application.Dtos.Kitchen.BussinesType;

namespace TheWildNature.Application.Features.Kitchen.BusinessType.Request.Queries
{
    public class GetBussinessTypeDetailsRequset:IRequest<BussinessTypeDto>
    {
        public int Id { get; set; }
    }
}
