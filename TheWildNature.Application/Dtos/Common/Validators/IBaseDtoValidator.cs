using FluentValidation;

namespace TheWildNature.Application.Dtos.Common.Validators
{
    public class IBaseDtoValidator:AbstractValidator<BaseDto>
    {
        public IBaseDtoValidator()
        {
            RuleFor(p => p.Id).NotNull()
          .WithMessage("{PropertyName} is required.");
        }
    }
}
