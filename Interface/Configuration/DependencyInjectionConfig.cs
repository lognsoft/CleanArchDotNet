using Application.DTO;
using Application.UseCases;
using Domain.Repositoryes;
using Infrastructure.Database;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddSingleton<IClientRepository, dbClient>();
        services.AddSingleton<IBookRepository, dbBook>();
    }

    public static void AddManagers(this IServiceCollection services)
    {
        services.AddTransient<ClientManager>();
        services.AddTransient<BookManager>();
        services.AddTransient<LendbookManager>();
    }

    public static void AddAutomapperProfiles(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapperProfile));
        services.AddAutoMapper(typeof(AutoMapperDb));
    }

    public static ServiceProvider ConfigureServices()
    {
        var serviceCollection = new ServiceCollection();

        serviceCollection.AddRepositories();
        serviceCollection.AddManagers();
        serviceCollection.AddAutomapperProfiles();

        return serviceCollection.BuildServiceProvider();
    }
}