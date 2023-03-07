using Sample.Interfaces.DataAccess;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.OrderTracking;

namespace Sample.OrderTracking;

public class OrderTracker : IOrderTracker
{
    public OrderTracker(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
