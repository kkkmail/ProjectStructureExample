using Sample.DataAccess;
using Sample.ErrorLogging;

namespace Sample.InventoryManagement;

public class InventoryManager : IInventoryManager
{
    public InventoryManager(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
