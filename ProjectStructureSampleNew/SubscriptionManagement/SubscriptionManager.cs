using Sample.Interfaces.NotificationManagement;
using Sample.Interfaces.SubscriptionManagement;
using Sample.Interfaces.UserActivity;

namespace Sample.SubscriptionManagement;

public class SubscriptionManager : ISubscriptionManager
{
    public SubscriptionManager(INotificationManager notificationManager, IUserActivityTracker userActivityTracker)
    {
    }
}
