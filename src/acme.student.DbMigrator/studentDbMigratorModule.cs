using acme.student.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace acme.student.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(studentEntityFrameworkCoreModule),
    typeof(studentApplicationContractsModule)
    )]
public class studentDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
