using Core.Interfaces;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
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
        //services.AddScoped<ITestRepository, TestRepository>();


        //services.RegisterAssemblyPublicNonGenericClasses(AppDomain.CurrentDomain.GetAssemblies())
        //    .Where(c => c.Name.EndsWith("Repository"))
        //    .AsPublicImplementedInterfaces();

        //services.RegisterAssemblyPublicNonGenericClasses(AppDomain.CurrentDomain.GetAssemblies())
        //    .Where(c => c.Name.EndsWith("Service"))
        //    .AsPublicImplementedInterfaces();

        #endregion

        #region Others

        //services.AddDbContext<AppDbContext>(options =>
        //    options.UseSqlServer(
        //        Configuration.GetConnectionString("DefaultConnection"),
        //        b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        //services.AddTransient<ICurrentUserService, CurrentUserService>();
        //services.AddTransient<IHttpService, HttpService>();

        #endregion
    }
}