using FluentValidation;
using TheWildNature.Application.Dtos.User.Validators;

namespace TheWildNature.Application.Dtos.Kitchen.Validators
{
    public class RegisterKitchenBasicInfoDtoValidator:AbstractValidator<CreateKitchenBaiscInfoDto>
    {
        public RegisterKitchenBasicInfoDtoValidator()
        {
            Include(new IKitchenDtoValidator());
            Include(new IUserDtoValidator());
            Include(new IUserFullNameDtoValidator());
            RuleFor(p => p.CityId).NotNull()
       .WithMessage("{PropertyName} is required.");
        }     
    }
}
