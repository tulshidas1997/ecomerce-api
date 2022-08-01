using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Core.Models;

public class AppUser: IdentityUser
{
    public int Age { get; set; }   
}