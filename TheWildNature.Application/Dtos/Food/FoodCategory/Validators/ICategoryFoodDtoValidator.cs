using FluentValidation;

namespace TheWildNature.Application.Dtos.Food.FoodCategory.Validators
{
    public class ICategoryFoodDtoValidator : AbstractValidator<IFoodCategoryDto>
    {
        public ICategoryFoodDtoValidator()
        {
            RuleFor(p => p.FoodOfTypeCategoryTitle)
                  .NotEmpty().WithMessage("{PropertyName} is required")
                  .NotNull()
                  .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50");

            RuleFor(p => p.ImageName)
                   .NotEmpty().WithMessage("{PropertyName} is required")
                   .NotNull();
        }
    }
}
