using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.PaymentGateway;

namespace Sample.PaymentGateway;

public class PaymentGatewayProxy : IPaymentGatewayProxy
{
    public PaymentGatewayProxy(IErrorLogger errorLogger)
    {
    }
}
