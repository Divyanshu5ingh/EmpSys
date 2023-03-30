using System.Threading.Tasks;

namespace Acme.EmpSys.Data;

public interface IEmpSysDbSchemaMigrator
{
    Task MigrateAsync();
}
