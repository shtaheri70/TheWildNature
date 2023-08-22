using FluentValidation;

namespace TheWildNature.Application.Dtos.Kitchen.BussinesType.Validators
{
    public class CreateBussinessTypeDtoValidator : AbstractValidator<CreateBussinessTypeDto>
    {
        public CreateBussinessTypeDtoValidator()
        {
            Include(new IBussinessTypeDtoValidator());
        }
    }
}
