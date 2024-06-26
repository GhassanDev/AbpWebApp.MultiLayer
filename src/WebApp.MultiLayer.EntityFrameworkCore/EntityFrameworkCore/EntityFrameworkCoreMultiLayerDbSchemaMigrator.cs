using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApp.MultiLayer.Data;
using Volo.Abp.DependencyInjection;

namespace WebApp.MultiLayer.EntityFrameworkCore;

public class EntityFrameworkCoreMultiLayerDbSchemaMigrator
    : IMultiLayerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMultiLayerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the MultiLayerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MultiLayerDbContext>()
            .Database
            .MigrateAsync();
    }
}
