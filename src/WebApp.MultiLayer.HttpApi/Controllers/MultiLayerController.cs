using WebApp.MultiLayer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WebApp.MultiLayer.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MultiLayerController : AbpControllerBase
{
    protected MultiLayerController()
    {
        LocalizationResource = typeof(MultiLayerResource);
    }
}
