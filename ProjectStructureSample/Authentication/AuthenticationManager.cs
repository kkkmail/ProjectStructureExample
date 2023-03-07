using Sample.DataAccess;
using Sample.ErrorLogging;

namespace Sample.Authentication;

public class AuthenticationManager : IAuthenticationManager
{
    public AuthenticationManager(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
