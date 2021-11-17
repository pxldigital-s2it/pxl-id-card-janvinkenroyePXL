using System.ComponentModel.DataAnnotations;

namespace Presences.Domain
{
    public class LoginModel
    {
        [Required] [MinLength(3)]  public string UserName { get; set; }
        [Required] [MinLength(6)] public string Password { get; set; }
    }
}