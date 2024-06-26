using WebApp.MultiLayer.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace WebApp.MultiLayer.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MultiLayerPageModel : AbpPageModel
{
    protected MultiLayerPageModel()
    {
        LocalizationResourceType = typeof(MultiLayerResource);
    }
}
