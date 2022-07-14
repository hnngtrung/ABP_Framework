using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace acme.student.Data;

/* This is used if database provider does't define
 * IstudentDbSchemaMigrator implementation.
 */
public class NullstudentDbSchemaMigrator : IstudentDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
