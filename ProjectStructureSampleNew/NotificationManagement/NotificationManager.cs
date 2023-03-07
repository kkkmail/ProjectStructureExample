using Sample.Interfaces.DataAccess;
using Sample.Interfaces.Email;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.NotificationManagement;

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
