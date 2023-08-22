using FluentValidation;

namespace TheWildNature.Application.Dtos.User.Validators
{
    public class IUserFullNameDtoValidator : AbstractValidator<IUserFullNameDto>
    {
        public IUserFullNameDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50");

            RuleFor(p => p.Family)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50");
        }
    }
}
