using Sample.DataAccess;
using Sample.ErrorLogging;
using Sample.InventoryManagement;

namespace Sample.InvoiceGeneration;

public class InvoiceGenerator : IInvoiceGenerator
{
    public InvoiceGenerator(
        IErrorLogger errorLogger,
        IDatabaseRepository databaseRepository,
        IInventoryManager inventoryManager)
    {
    }
}
