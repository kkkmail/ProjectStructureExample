using Sample.DataAccess;
using Sample.Email;
using Sample.ErrorLogging;
using Sample.InvoiceGeneration;

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
