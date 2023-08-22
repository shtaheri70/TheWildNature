using FluentValidation;
using TheWildNature.Application.Dtos.Files.Validator;

namespace TheWildNature.Application.Dtos.Kitchen.Validators
{
    public class IKitchenDtoValidator : AbstractValidator<IKitchenDto>
    {
        public IKitchenDtoValidator()
        {
            RuleFor(p => p.KitchenName)
        .NotEmpty().WithMessage("{PropertyName} is required")
        .NotNull()
        .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50");

            RuleFor(p => p.BusinessTypeId).NotNull()
          .WithMessage("{PropertyName} is required.");

            
        }
    }
}
