using System.ComponentModel.DataAnnotations;

namespace TheWildNature.Application.Models.Identity
{
    public class RegisteratinRequest
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string Mobile { get; set; }
    }
}
