using System.Reflection;
using AutoMapper;
using Core.Interfaces.Common;

namespace AspNet6SqlServerCleanArchitecture.MappingProfile;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        var assembly = AppDomain.CurrentDomain.GetAssemblies().Where(c => c.FullName.StartsWith(nameof(AspNet6SqlServerCleanArchitecture))).ToArray();
        ApplyMappingsFromAssembly(assembly);
    }

    private void ApplyMappingsFromAssembly(Assembly[] assemblies)
    {
        var types = new List<Type>();
        foreach (var assembly in assemblies)
        {
            types.AddRange(
                assembly.GetExportedTypes()
                    .Where(t => t.GetInterfaces().Any(i =>
                        i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                    .ToList());
        }

        foreach (var type in types)
        {
            var instance = Activator.CreateInstance(type);

            var methodInfo = type.GetMethod( "Mapping")
                             ?? type.GetInterface("IMapFrom`1")?.GetMethod("Mapping");

            methodInfo?.Invoke(instance, new object[] { this });

        }
    }
}