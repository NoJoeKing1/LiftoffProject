using System.ComponentModel.DataAnnotations;

namespace ParkRec.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
