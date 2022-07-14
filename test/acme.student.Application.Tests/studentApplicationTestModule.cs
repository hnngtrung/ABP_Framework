using Volo.Abp.Modularity;

namespace acme.student;

[DependsOn(
    typeof(studentApplicationModule),
    typeof(studentDomainTestModule)
    )]
public class studentApplicationTestModule : AbpModule
{

}
