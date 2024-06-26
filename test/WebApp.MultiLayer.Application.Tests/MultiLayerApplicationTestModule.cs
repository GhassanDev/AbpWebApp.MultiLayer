using Volo.Abp.Modularity;

namespace WebApp.MultiLayer;

[DependsOn(
    typeof(MultiLayerApplicationModule),
    typeof(MultiLayerDomainTestModule)
)]
public class MultiLayerApplicationTestModule : AbpModule
{

}
