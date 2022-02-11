using Volo.Abp.Modularity;

namespace Mias.Practice;

[DependsOn(
    typeof(PracticeApplicationModule),
    typeof(PracticeDomainTestModule)
    )]
public class PracticeApplicationTestModule : AbpModule
{

}
