using Sample.Interfaces.Authentication;
using Sample.Interfaces.DataAccess;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.UserActivity;

namespace Sample.UserActivity;

public class UserActivityTracker : IUserActivityTracker
{
    public UserActivityTracker(
        IErrorLogger errorLogger,
        IDatabaseRepository databaseRepository,
        IAuthenticationManager authenticationManager)
    {
    }
}
