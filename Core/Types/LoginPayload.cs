using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Core.Types;

public class LoginPayload
{
    [Required]
    public string EmailOrPhone { get; set; }
    [Required]
    public string Password { get; set; }
}