using Xunit;

namespace WebApp.MultiLayer.EntityFrameworkCore;

[CollectionDefinition(MultiLayerTestConsts.CollectionDefinitionName)]
public class MultiLayerEntityFrameworkCoreCollection : ICollectionFixture<MultiLayerEntityFrameworkCoreFixture>
{

}
