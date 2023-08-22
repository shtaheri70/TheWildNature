using FluentValidation;

namespace TheWildNature.Application.Dtos.Kitchen.FinancialInfo.Validators
{
    public class CreateKitchenFinancialInfoDtoValidator : AbstractValidator<CreateKitchenFinancialInfoDto>
    {
        public CreateKitchenFinancialInfoDtoValidator()
        {
            Include(new IKitchenFinancialInfoDtoValidator());
        }

    }
}
