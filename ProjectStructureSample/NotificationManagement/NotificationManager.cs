using Sample.DataAccess;
using Sample.Email;
using Sample.ErrorLogging;

namespace Sample.NotificationManagement;

public class NotificationManager : INotificationManager
{
    public NotificationManager(
        IErrorLogger errorLogger,
        IDatabaseRepository databaseRepository,
        IEmailClient emailClient)
    {
    }
}
