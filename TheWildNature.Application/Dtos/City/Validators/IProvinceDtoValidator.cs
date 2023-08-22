using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWildNature.Application.Dtos.City.Validators
{
    public class IProvinceDtoValidator:AbstractValidator<IProvinceDto>
    {
        public IProvinceDtoValidator()
        {
            RuleFor(p => p.Name)
          .NotEmpty().WithMessage("{PropertyName} is required")
          .NotNull()
          .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50");
        }
    }
}
