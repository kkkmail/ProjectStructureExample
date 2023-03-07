using Sample.Interfaces.Authentication;
using Sample.Interfaces.DataAccess;
using Sample.Interfaces.ErrorLogging;

namespace Sample.Authentication;

public class AuthenticationManager : IAuthenticationManager
{
    public AuthenticationManager(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
