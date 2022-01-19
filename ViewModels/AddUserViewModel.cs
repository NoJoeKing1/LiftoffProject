using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NationalParkRecommendation.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        /*[Required(ErrorMessage = "Password is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Password must be between 3 and 15 characters")]
        public string Password { get; set; }
        public string VerifyPassword { get; set; }*/
        public AddUserViewModel()
        {
        }
    }
}
