using Sample.Interfaces.AccountManagement;
using Sample.Interfaces.DataAccess;
using Sample.Interfaces.Email;
using Sample.Interfaces.ErrorLogging;

namespace Sample.AccountManagement;

public class AccountManager : IAccountManager
{
    public AccountManager(
        IErrorLogger errorLogger,
        IDatabaseRepository databaseRepository,
        IEmailClient emailClient)
    {
    }
}
