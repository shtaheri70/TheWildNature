using MediatR;
using TheWildNature.Application.Dtos.City;

namespace TheWildNature.Application.Features.City.Request.Queries
{
    public class GetProvinceListRequest:IRequest<List<ProvinceDto>>
    {

    }
}
