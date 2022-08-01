using Core.Interfaces;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Context;
using Services;

namespace AspNet6SqlServerCleanArchitecture.Extensions;

public static class ServiceRegister
{
    public static void RegisterDependency(this IServiceCollection services)
    {

        #region Services

        services.AddScoped<ICowService,CowService>();

        #endregion

        #region Repositories

        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
        services.AddScoped<ICowRepository,CowRepository>();

        #endregion

        #region Others

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();

        #endregion
    }

    public static async Task ExecuteScopedActions(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        await ExecuteMigration(scope);

    }
    public static async Task ExecuteMigration(IServiceScope scope)
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        await dbContext.Database.MigrateAsync();
    }
}