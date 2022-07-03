using Microsoft.AspNetCore.Identity;

namespace Core.Models;

public class AppUser: IdentityUser
{
    public int Age { get; set; }   
}