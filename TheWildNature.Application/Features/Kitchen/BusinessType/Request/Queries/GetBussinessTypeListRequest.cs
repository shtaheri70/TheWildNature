using MediatR;
using TheWildNature.Application.Dtos.Kitchen.BussinesType;

namespace TheWildNature.Application.Features.Kitchen.BusinessType.Request.Queries
{
    public class GetBussinessTypeListRequest:IRequest<List<BussinessTypeDto>>
    {

    }
}
