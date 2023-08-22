using FluentValidation;

namespace TheWildNature.Application.Dtos.Kitchen.BussinesType.Validators
{
    public class IBussinessTypeDtoValidator : AbstractValidator<IBussinessTypeDto>
    {
        public IBussinessTypeDtoValidator()
        {
            RuleFor(p => p.BusinessTypeTitle)
             .NotEmpty().WithMessage("{PropertyName} is required")
             .NotNull()
             .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50");
        }
    }
}
