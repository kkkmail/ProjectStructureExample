using Sample.DataAccess;
using Sample.Email;
using Sample.ErrorLogging;

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
