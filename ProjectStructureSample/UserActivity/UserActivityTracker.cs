using Sample.Authentication;
using Sample.DataAccess;
using Sample.ErrorLogging;

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
