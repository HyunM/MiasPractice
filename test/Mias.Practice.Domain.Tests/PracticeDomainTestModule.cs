using Mias.Practice.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Mias.Practice;

[DependsOn(
    typeof(PracticeEntityFrameworkCoreTestModule)
    )]
public class PracticeDomainTestModule : AbpModule
{

}
