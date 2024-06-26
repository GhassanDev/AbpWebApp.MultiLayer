using WebApp.MultiLayer.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace WebApp.MultiLayer.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MultiLayerEntityFrameworkCoreModule),
    typeof(MultiLayerApplicationContractsModule)
    )]
public class MultiLayerDbMigratorModule : AbpModule
{
}
