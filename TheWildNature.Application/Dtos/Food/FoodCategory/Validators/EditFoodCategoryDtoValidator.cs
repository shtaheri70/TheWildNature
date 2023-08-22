using FluentValidation;
using TheWildNature.Application.Dtos.Common.Validators;

namespace TheWildNature.Application.Dtos.Food.FoodCategory.Validators
{
    public class EditFoodCategoryDtoValidator: AbstractValidator<FoodCategoryDto>
    {
        public EditFoodCategoryDtoValidator()
        {
            Include(new ICategoryFoodDtoValidator());
            Include(new IBaseDtoValidator());
        }

    }
}
