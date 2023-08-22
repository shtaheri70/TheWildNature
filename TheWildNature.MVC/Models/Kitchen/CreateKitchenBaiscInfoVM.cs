using System.ComponentModel.DataAnnotations;

namespace TheWildNature.MVC.Models.Kitchen
{
    public class CreateKitchenBaiscInfoVM
    {
        [Required]
        [Display(Name = "نام آشپزخانه")]
        public string KitchenName { get; set; }
        [Required]
        [Display(Name = "نام مدیر آشپزخانه")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "نام خانوادگی مدیر آشپزخانه")]
        public string Family { get; set; }
        [Required]
        [Display(Name = "موبایل")]
        public string Mobile { get; set; }
        [Required]
        public int CityId { get; set; }
        [Required]
        public int BusinessTypeId { get; set; }






    }
}
