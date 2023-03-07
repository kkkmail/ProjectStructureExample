using Sample.ErrorLogging;

namespace Sample.PaymentGateway;

public class PaymentGatewayProxy : IPaymentGatewayProxy
{
    public PaymentGatewayProxy(IErrorLogger errorLogger)
    {
    }
}
