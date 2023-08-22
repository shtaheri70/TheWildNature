using FluentValidation;
using TheWildNature.Application.Dtos.Files.Validator;

namespace TheWildNature.Application.Dtos.Kitchen.FinancialInfo.Validators
{
    public class IKitchenFinancialInfoDtoValidator:AbstractValidator<IKitchenFinancialInfoDto>
    {
        public IKitchenFinancialInfoDtoValidator()
        {
            RuleFor(p => p.AccountNumber)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull();

            RuleFor(p => p.CardNumber)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();

            RuleFor(p => p.ShabaNumber)
             .NotEmpty().WithMessage("{PropertyName} is required")
             .NotNull()
             .Must(x=> x.Length == 24).WithMessage("{PropertyName} must be 24 character")
             .Must(x => int.TryParse(x, out var val) && val > 0).WithMessage("Invalid shaba Number."); ;

            RuleFor(p => p.BankName)
             .NotEmpty().WithMessage("{PropertyName} is required")
             .NotNull();

            RuleFor(x => x.CardFile).SetValidator(new FileValidator())
             .NotNull().WithMessage("{PropertyName} is required") ;

            RuleFor(x => x.BusinessLicenseFile).SetValidator(new FileValidator())
                .NotNull().WithMessage("{PropertyName} is required");
        }
    }
}
