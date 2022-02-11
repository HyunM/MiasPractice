using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Mias.Practice.Blazor;

[Dependency(ReplaceServices = true)]
public class PracticeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Practice";
}
