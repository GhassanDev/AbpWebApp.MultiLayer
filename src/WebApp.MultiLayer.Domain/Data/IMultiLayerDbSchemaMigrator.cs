using System.Threading.Tasks;

namespace WebApp.MultiLayer.Data;

public interface IMultiLayerDbSchemaMigrator
{
    Task MigrateAsync();
}
