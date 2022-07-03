using Core.Interfaces;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Repositories;
using Services;

namespace AspNet6SqlServerCleanArchitecture.Extensions;

public static class ServiceRegister
{
    public static void RegisterDependency(this IServiceCollection services)
    {
        #region Services

        //services.AddScoped(typeof(IBaseService<,>), typeof(BaseService<,>));
        //services.AddScoped<ITestService, TestService>();

        #endregion

        #region Repositories

        //services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        //services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
        //services.AddScoped<ITestRepository, TestRepository>();


        //services.RegisterAssemblyPublicNonGenericClasses(AppDomain.CurrentDomain.GetAssemblies())
        //    .Where(c => c.Name.EndsWith("Repository"))
        //    .AsPublicImplementedInterfaces();

        //services.RegisterAssemblyPublicNonGenericClasses(AppDomain.CurrentDomain.GetAssemblies())
        //    .Where(c => c.Name.EndsWith("Service"))
        //    .AsPublicImplementedInterfaces();

        #endregion

        #region Others

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        //services.AddTransient<ICurrentUserService, CurrentUserService>();
        //services.AddTransient<IHttpService, HttpService>();

        #endregion
    }
}