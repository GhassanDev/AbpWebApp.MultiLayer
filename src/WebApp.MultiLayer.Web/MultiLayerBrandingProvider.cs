using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace WebApp.MultiLayer.Web;

[Dependency(ReplaceServices = true)]
public class MultiLayerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MultiLayer";
}
