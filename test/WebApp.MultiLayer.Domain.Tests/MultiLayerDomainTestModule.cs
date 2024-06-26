using Volo.Abp.Modularity;

namespace WebApp.MultiLayer;

[DependsOn(
    typeof(MultiLayerDomainModule),
    typeof(MultiLayerTestBaseModule)
)]
public class MultiLayerDomainTestModule : AbpModule
{

}
