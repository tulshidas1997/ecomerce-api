using CleanArchitecture.Core.Models;
using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Repositories.Context;

public sealed class AppDbContext: IdentityDbContext<AppUser,AppRole,string>
{
    private readonly ICurrentUserService _currentUserService;
    public AppDbContext(DbContextOptions<AppDbContext> opt, ICurrentUserService currentUserService):base(opt)
    {
        _currentUserService = currentUserService;
    }

    public DbSet<Cow> Cows { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<AppUser>().ToTable("Users");
        modelBuilder.Entity<AppRole>().ToTable("Roles");
    }
}