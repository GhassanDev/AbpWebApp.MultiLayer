using WebApp.MultiLayer.Samples;
using Xunit;

namespace WebApp.MultiLayer.EntityFrameworkCore.Domains;

[Collection(MultiLayerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MultiLayerEntityFrameworkCoreTestModule>
{

}
