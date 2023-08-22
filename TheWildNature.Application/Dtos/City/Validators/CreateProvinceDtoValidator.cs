using FluentValidation;

namespace TheWildNature.Application.Dtos.City.Validators
{
    public class CreateProvinceDtoValidator:AbstractValidator<CreateProvinceDto>
    {
        public CreateProvinceDtoValidator()
        {
                Include(new IProvinceDtoValidator());
        }
    }
}
