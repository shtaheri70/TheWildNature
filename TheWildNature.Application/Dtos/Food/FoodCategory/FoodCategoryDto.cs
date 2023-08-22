using TheWildNature.Application.Dtos.Common;

namespace TheWildNature.Application.Dtos.Food.FoodCategory
{
    public class FoodCategoryDto:BaseDto,IFoodCategoryDto
    {
        public string FoodOfTypeCategoryTitle { get; set; }
        public string ImageName { get; set; }
    }
}
