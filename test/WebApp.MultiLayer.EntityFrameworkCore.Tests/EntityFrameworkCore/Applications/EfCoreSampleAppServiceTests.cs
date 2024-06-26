using WebApp.MultiLayer.Samples;
using Xunit;

namespace WebApp.MultiLayer.EntityFrameworkCore.Applications;

[Collection(MultiLayerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MultiLayerEntityFrameworkCoreTestModule>
{

}
