using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Core.Types;

public class LoginPayload
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}