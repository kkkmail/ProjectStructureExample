using Sample.NotificationManagement;
using Sample.UserActivity;

namespace Sample.SubscriptionManagement;

public class SubscriptionManager : ISubscriptionManager
{
    public SubscriptionManager(INotificationManager notificationManager, IUserActivityTracker userActivityTracker)
    {
    }
}
