using Mias.Practice.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Mias.Practice.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PracticeEntityFrameworkCoreModule),
    typeof(PracticeApplicationContractsModule)
    )]
public class PracticeDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
