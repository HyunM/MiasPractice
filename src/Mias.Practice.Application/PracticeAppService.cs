using System;
using System.Collections.Generic;
using System.Text;
using Mias.Practice.Localization;
using Volo.Abp.Application.Services;

namespace Mias.Practice;

/* Inherit your application services from this class.
 */
public abstract class PracticeAppService : ApplicationService
{
    protected PracticeAppService()
    {
        LocalizationResource = typeof(PracticeResource);
    }
}
