using Sample.DataAccess;
using Sample.ErrorLogging;
using Sample.PaymentGateway;

namespace Sample.PaymentProcessing;

public class PaymentProcessor : IPaymentProcessor
{
    public PaymentProcessor(
        IErrorLogger errorLogger,
        IDatabaseRepository databaseRepository,
        IPaymentGatewayProxy paymentGatewayProxy)
    {
    }
}
