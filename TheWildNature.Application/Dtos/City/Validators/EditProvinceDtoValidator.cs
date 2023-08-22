using FluentValidation;
using TheWildNature.Application.Dtos.Common.Validators;

namespace TheWildNature.Application.Dtos.City.Validators
{
    public class EditProvinceDtoValidator : AbstractValidator<ProvinceDto>
    {
        public EditProvinceDtoValidator()
        {
            Include(new IBaseDtoValidator());
             Include(new IProvinceDtoValidator());
        }
    }
}
