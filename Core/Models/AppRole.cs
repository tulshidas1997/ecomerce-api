using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Core.Models;

public class AppRole:IdentityRole
{
    public string Code { get; set; }
}