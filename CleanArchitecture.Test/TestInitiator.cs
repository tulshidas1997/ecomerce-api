using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Test;

[SetUpFixture]
public class TestInitiator
{
    public static ServiceProvider _serviceProvider;
    [OneTimeSetUp]
    public void Initiate()
    {
        var services = new ServiceCollection();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


        _serviceProvider = services.BuildServiceProvider();

    }
}