using FluentValidation;
using System.Text.RegularExpressions;

namespace TheWildNature.Application.Dtos.User.Validators
{
    public class IUserDtoValidator : AbstractValidator<IUserDto>
    {
        public IUserDtoValidator()
        {
            RuleFor(p => p.Mobile)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull()
              .Length(11).WithMessage("{PropertyName} must 11 character")
              .Matches(new Regex(@"09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}"))
              .WithMessage("PhoneNumber not valid");
        }
    }
}
