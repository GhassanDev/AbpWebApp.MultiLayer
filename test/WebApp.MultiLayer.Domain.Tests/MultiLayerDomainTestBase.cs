using Volo.Abp.Modularity;

namespace WebApp.MultiLayer;

/* Inherit from this class for your domain layer tests. */
public abstract class MultiLayerDomainTestBase<TStartupModule> : MultiLayerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
