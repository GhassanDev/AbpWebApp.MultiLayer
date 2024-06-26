using System;
using System.Collections.Generic;
using System.Text;
using WebApp.MultiLayer.Localization;
using Volo.Abp.Application.Services;

namespace WebApp.MultiLayer;

/* Inherit your application services from this class.
 */
public abstract class MultiLayerAppService : ApplicationService
{
    protected MultiLayerAppService()
    {
        LocalizationResource = typeof(MultiLayerResource);
    }
}
