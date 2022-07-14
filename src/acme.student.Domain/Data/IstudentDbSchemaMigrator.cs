using System.Threading.Tasks;

namespace acme.student.Data;

public interface IstudentDbSchemaMigrator
{
    Task MigrateAsync();
}
