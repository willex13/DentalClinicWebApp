using System.ComponentModel.DataAnnotations;

namespace DentalClinic.WebUI.Server.Components.ViewModel
{
    public class LoginAccountForm
    {
        [Required(ErrorMessage = "Username é obrigatório")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password é obrigatório")]
        public string Password { get; set; } = string.Empty;
    }
}
