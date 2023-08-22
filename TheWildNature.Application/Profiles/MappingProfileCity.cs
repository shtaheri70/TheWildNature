using AutoMapper;
using TheWildNature.Application.Dtos.City;
using TheWildNature.Application.Dtos.Kitchen;
using TheWildNature.Application.Dtos.User;
using TheWildNature.Domain.Entities.City;
using TheWildNature.Domain.Entities.Kitchen;
using TheWildNature.Domain.Entities.Users;

namespace TheWildNature.Application.Profiles
{
    public class MappingProfileCity : Profile
    {
        public MappingProfileCity()
        {
            #region City
            CreateMap<CityDto, City>().ReverseMap();
            CreateMap<CreateCityDto, City>().ReverseMap();
            #endregion

            #region Province
            CreateMap<ProvinceDto ,Province>().ReverseMap();
            CreateMap<CreateProvinceDto, Province>().ReverseMap();
            #endregion
        }
    }
}
