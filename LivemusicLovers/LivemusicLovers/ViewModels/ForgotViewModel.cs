using System.ComponentModel.DataAnnotations;

namespace LivemusicLovers.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
