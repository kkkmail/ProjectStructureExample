using Sample.DataAccess;
using Sample.ErrorLogging;

namespace Sample.OrderTracking;

public class OrderTracker : IOrderTracker
{
    public OrderTracker(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
