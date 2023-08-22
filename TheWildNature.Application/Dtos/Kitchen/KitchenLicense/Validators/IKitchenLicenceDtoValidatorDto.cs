using FluentValidation;
using TheWildNature.Application.Dtos.Files.Validator;
using TheWildNature.Application.Dtos.Kitchen.FinancialInfo;

namespace TheWildNature.Application.Dtos.Kitchen.KitchenLicense.Validators
{
    public class IKitchenLicenceDtoValidatorDto : AbstractValidator<IKitchenLicenseDto>
    {
        public IKitchenLicenceDtoValidatorDto()
        {
            RuleFor(x => x.LicenseFile).SetValidator(new FileValidator())
       .NotNull().WithMessage("{PropertyName} is required");
        }
      
    }
}
