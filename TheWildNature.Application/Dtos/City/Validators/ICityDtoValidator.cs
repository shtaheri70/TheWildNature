using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWildNature.Application.Dtos.City.Validators
{
    public class ICityDtoValidator : AbstractValidator<ICityDto>
    {
        public ICityDtoValidator()
        {
            RuleFor(p => p.CityName)
             .NotEmpty().WithMessage("{PropertyName} is required")
             .NotNull()
             .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50");
        }
    }
}
