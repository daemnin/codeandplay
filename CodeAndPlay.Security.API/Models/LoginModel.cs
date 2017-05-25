using System.ComponentModel.DataAnnotations;

namespace CodeAndPlay.Security.API.Models
{
    public class LoginModel
    {
        [Required,
        Display(Name = "Username"),
        DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required,
        StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6),
        DataType(DataType.Password),
        Display(Name = "Password")]
        public string Password { get; set; }
    }
}