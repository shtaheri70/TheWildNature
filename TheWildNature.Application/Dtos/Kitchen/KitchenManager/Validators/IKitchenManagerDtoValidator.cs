using FluentValidation;

namespace TheWildNature.Application.Dtos.Kitchen.KitchenManager.Validators
{
    public class IKitchenManagerDtoValidator : AbstractValidator<IKitchenManagerDto>
    {
        public IKitchenManagerDtoValidator()
        {
            RuleFor(p => p.Email)
             .EmailAddress().WithMessage("Invalid {PropertyName}")
             ;

            RuleFor(p => p.NationalNumber)
            .Length(10).WithMessage("Invalid {PropertyName}")
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .Must(x => int.TryParse(x, out var val) && val > 0).WithMessage("Invalid Number.");
        }
    }
}
