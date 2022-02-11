using Mias.Practice.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Mias.Practice.Blazor;

public abstract class PracticeComponentBase : AbpComponentBase
{
    protected PracticeComponentBase()
    {
        LocalizationResource = typeof(PracticeResource);
    }
}
