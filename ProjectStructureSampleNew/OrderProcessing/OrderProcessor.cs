using Sample.Interfaces.AccountManagement;
using Sample.Interfaces.DataAccess;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.InventoryManagement;
using Sample.Interfaces.InvoiceGeneration;
using Sample.Interfaces.OrderProcessing;
using Sample.Interfaces.OrderTracking;
using Sample.Interfaces.PaymentProcessing;

namespace Sample.OrderProcessing;

public class OrderProcessor : IOrderProcessor
{
    public OrderProcessor(
        IErrorLogger errorLogger,
        IDatabaseRepository databaseRepository,
        IOrderTracker orderTracker,
        IInvoiceGenerator invoiceGenerator,
        IInventoryManager inventoryManager,
        IAccountManager accountManager,
        IPaymentProcessor paymentProcessor)
    {
    }
}
