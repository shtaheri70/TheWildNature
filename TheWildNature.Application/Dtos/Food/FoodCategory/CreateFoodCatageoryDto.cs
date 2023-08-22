namespace TheWildNature.Application.Dtos.Food.FoodCategory
{
    public class CreateFoodCatageoryDto : IFoodCategoryDto
    {
        public string FoodOfTypeCategoryTitle { get; set; }
        public string ImageName { get; set ; }
    }
}
