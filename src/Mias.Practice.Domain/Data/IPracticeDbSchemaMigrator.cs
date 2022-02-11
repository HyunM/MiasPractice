using System.Threading.Tasks;

namespace Mias.Practice.Data;

public interface IPracticeDbSchemaMigrator
{
    Task MigrateAsync();
}
