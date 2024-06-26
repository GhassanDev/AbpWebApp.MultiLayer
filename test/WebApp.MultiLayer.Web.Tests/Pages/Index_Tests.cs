using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace WebApp.MultiLayer.Pages;

public class Index_Tests : MultiLayerWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
