using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XpLevelCalculator.Core.DataAccess;
using XpLevelCalculator.Core.DataAccess.Repositories;
using XpLevelCalculator.Core.Interfaces;
using XpLevelCalculator.Core.UseCases;

namespace XpLevelCalculator.Core.Extensions;

public static class DependencyInjectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDbContext(services, configuration);
        AddRepositories(services);
    }

    public static void AddAplication(this IServiceCollection services)
    {
        AddUseCases(services);
    }

    private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DbConnection");
        var serverVersion = ServerVersion.AutoDetect(connectionString);
        
        services.AddDbContext<XpCalculatorDbContext>(config => config.UseMySql(connectionString, serverVersion));
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRetrieveActivityAmountUseCase, RetrieveActivityAmountUseCase>();
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<ILevelReadOnlyRepository, LevelRepository>();
    }

}
