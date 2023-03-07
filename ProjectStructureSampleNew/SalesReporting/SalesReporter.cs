using Sample.Interfaces.DataAccess;
using Sample.Interfaces.Email;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.InvoiceGeneration;
using Sample.Interfaces.SalesReporting;

namespace Sample.SalesReporting;

public class SalesReporter : ISalesReporter
{
    public SalesReporter(
        IErrorLogger errorLogger,
        IDatabaseRepository databaseRepository,
        IInvoiceGenerator invoiceGenerator,
        IEmailClient emailClient)
    {
    }
}
