using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Mias.Practice.Data;

/* This is used if database provider does't define
 * IPracticeDbSchemaMigrator implementation.
 */
public class NullPracticeDbSchemaMigrator : IPracticeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
