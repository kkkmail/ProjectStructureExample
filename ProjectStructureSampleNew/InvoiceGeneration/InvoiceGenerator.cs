using Sample.Interfaces.DataAccess;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.InventoryManagement;
using Sample.Interfaces.InvoiceGeneration;

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
