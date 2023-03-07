using Sample.Interfaces.DataAccess;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.PaymentGateway;
using Sample.Interfaces.PaymentProcessing;

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
