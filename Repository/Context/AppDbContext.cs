using CleanArchitecture.Core.Models;
using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Repositories.Context;

public sealed class AppDbContext: IdentityDbContext<AppUser>
{
    private readonly ICurrentUserService _currentUserService;
    public AppDbContext(DbContextOptions<AppDbContext> opt, ICurrentUserService currentUserService):base(opt)
    {
        _currentUserService = currentUserService;
    }

    public DbSet<Cow> Cows { get; set; }
}