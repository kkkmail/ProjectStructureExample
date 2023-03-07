using Sample.Interfaces.DataAccess;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.InventoryManagement;

namespace Sample.InventoryManagement;

public class InventoryManager : IInventoryManager
{
    public InventoryManager(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
