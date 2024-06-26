using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace WebApp.MultiLayer.Data;

/* This is used if database provider does't define
 * IMultiLayerDbSchemaMigrator implementation.
 */
public class NullMultiLayerDbSchemaMigrator : IMultiLayerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
