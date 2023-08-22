
using System.ComponentModel.DataAnnotations;

namespace TheWildNature.MVC.Models.Food
{
    public class CreateFoodCtageoryVM
    {
        [Required]
        [Display(Name ="عنوان دسته بندی")]
        public string FoodOfTypeCategoryTitle { get; set; }
        [Display(Name = "تصویر")]
        public string ImageName { get; set; }
    }
}
