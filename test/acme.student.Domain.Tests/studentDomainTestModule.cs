using acme.student.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace acme.student;

[DependsOn(
    typeof(studentEntityFrameworkCoreTestModule)
    )]
public class studentDomainTestModule : AbpModule
{

}
