using AutoMapper;
using TheWildNature.Application.Dtos.Kitchen;
using TheWildNature.Application.Dtos.Kitchen.BussinesType;
using TheWildNature.Application.Dtos.Kitchen.FinancialInfo;
using TheWildNature.Application.Dtos.Kitchen.KitchenLicense;
using TheWildNature.Application.Dtos.Kitchen.KitchenManager;
using TheWildNature.Application.Dtos.Kitchen.KitchenPlaceDetails;
using TheWildNature.Application.Dtos.PlaceDetails;
using TheWildNature.Application.Dtos.User;
using TheWildNature.Domain.Entities.Kitchen;
using TheWildNature.Domain.Entities.PlaceDetails;
using TheWildNature.Domain.Entities.Users;

namespace TheWildNature.Application.Profiles
{
    public class MappingProfileKitchen:Profile
    {
        public MappingProfileKitchen()
        {

            CreateMap<User, CreateKitchenBaiscInfoDto>(MemberList.None).ReverseMap();
            CreateMap<KitchenManager, CreateKitchenBaiscInfoDto>(MemberList.None).IncludeMembers(k => k.User).ReverseMap();
            CreateMap<Kitchen, CreateKitchenBaiscInfoDto>(MemberList.None).IncludeMembers(s => s.KitchenManager ,K=> K.KitchenManager.User).ReverseMap();

            CreateMap<User, UpdateKitchenAndKitchenManagerInfoDto>(MemberList.None).ReverseMap();
            CreateMap<KitchenManager, UpdateKitchenAndKitchenManagerInfoDto>(MemberList.None).IncludeMembers(k => k.User).ReverseMap();
            CreateMap<Kitchen, UpdateKitchenAndKitchenManagerInfoDto>(MemberList.None)
                .IncludeMembers(s => s.KitchenManager, K => K.KitchenManager.User,b=> b.BusinessType ).ReverseMap();
            CreateMap<BusinessType, UpdateKitchenAndKitchenManagerInfoDto>(MemberList.None).ReverseMap();

            CreateMap<KitchenManagerDto,UpdateKitchenAndKitchenManagerInfoDto>(MemberList.None).ReverseMap();
            CreateMap<KitchenPlaceDetailsDto, UpdateKitchenAndKitchenManagerInfoDto>(MemberList.None)
                .ForMember(dest => dest.BusinessTypeTitle, opt => opt.MapFrom(src => src.PlaceType)).ReverseMap();
            CreateMap<PlaceDetails, KitchenPlaceDetailsDto>(MemberList.None).ReverseMap();

           CreateMap<KitchenFinancialInfo, CreateKitchenFinancialInfoDto>(MemberList.None).IncludeMembers(k => k.Kitchen).ReverseMap();

            CreateMap<KitchenManager, CreatePlaceDetailsKitchenInfoDto>(MemberList.None).ReverseMap();
            CreateMap<PlaceDetails, CreatePlaceDetailsKitchenInfoDto>(MemberList.None).ReverseMap();

            CreateMap<PlaceDetails, EditKitchenPlaceDetailsDto>(MemberList.None).ReverseMap();

            
            CreateMap<KitchenFinancialInfo, EditKitchenFinancialInfoDto>(MemberList.None).ReverseMap();

            CreateMap<Kitchen, KitchenDto>(MemberList.None).ReverseMap();

            CreateMap<KitchenManager, KitchenManagerDto>(MemberList.None).ReverseMap();
           

            CreateMap<Kitchen, CreateKitchenLicenseDto>(MemberList.None).ReverseMap();
            CreateMap<Kitchen, EditKitchenLicenseDto>(MemberList.None).ReverseMap();

            CreateMap<BusinessType, BussinessTypeDto>(MemberList.None).ReverseMap();


        }
    }
}
