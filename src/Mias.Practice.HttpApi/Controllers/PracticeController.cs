using Mias.Practice.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Mias.Practice.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PracticeController : AbpControllerBase
{
    protected PracticeController()
    {
        LocalizationResource = typeof(PracticeResource);
    }
}
