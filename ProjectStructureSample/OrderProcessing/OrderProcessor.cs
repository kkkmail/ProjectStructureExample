using Sample.AccountManagement;
using Sample.DataAccess;
using Sample.ErrorLogging;
using Sample.InventoryManagement;
using Sample.InvoiceGeneration;
using Sample.OrderTracking;
using Sample.PaymentProcessing;

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
