using AutoMapper;
using TheWildNature.MVC.Models.Kitchen;
using TheWildNature.MVC.Services.Base;

namespace TheWildNature.MVC.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            #region Food
            //CreateMap<CreateFoodCatageoryDto, CreateFoodCtageoryVM>().ReverseMap();
            CreateMap<CreateKitchenBaiscInfoDto, CreateKitchenBaiscInfoVM>().ReverseMap();
            #endregion
        }
    }
}
