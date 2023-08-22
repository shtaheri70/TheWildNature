using FluentValidation;
using TheWildNature.Application.Dtos.Common.Validators;

namespace TheWildNature.Application.Dtos.Kitchen.BussinesType.Validators
{
    public class EditBussinessTypeDtoValidator:AbstractValidator<BussinessTypeDto>
    {
        public EditBussinessTypeDtoValidator()
        {
            Include(new IBussinessTypeDtoValidator());
            Include(new IBaseDtoValidator());
        }
    }
}
