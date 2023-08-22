using FluentValidation;

namespace TheWildNature.Application.Dtos.Kitchen.Validators
{
    public class KitchenDtoValidator:AbstractValidator<KitchenDto>
    {
        public KitchenDtoValidator()
        {
            Include(new IKitchenDtoValidator());
        }
    }
}
