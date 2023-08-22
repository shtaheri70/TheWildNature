using FluentValidation;
using TheWildNature.Application.Dtos.Kitchen.BussinesType;
using TheWildNature.Application.Dtos.Kitchen.BussinesType.Validators;

namespace TheWildNature.Application.Dtos.Food.FoodCategory.Validators
{
    public class CreateCtageoryFoodDtoValidator: AbstractValidator<CreateFoodCatageoryDto>
    {
        public CreateCtageoryFoodDtoValidator( )
        {
            Include(new ICategoryFoodDtoValidator());
        }
    }
}
