using Volo.Abp.Modularity;

namespace WebApp.MultiLayer;

public abstract class MultiLayerApplicationTestBase<TStartupModule> : MultiLayerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
