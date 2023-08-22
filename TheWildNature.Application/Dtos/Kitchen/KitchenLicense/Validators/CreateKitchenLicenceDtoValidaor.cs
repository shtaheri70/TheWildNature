using FluentValidation;

namespace TheWildNature.Application.Dtos.Kitchen.KitchenLicense.Validators
{
    public class CreateKitchenLicenceDtoValidaor: AbstractValidator<CreateKitchenLicenseDto>
    {
        public CreateKitchenLicenceDtoValidaor()
        {
            Include(new IKitchenLicenceDtoValidatorDto());  
        }
       
    }
}
