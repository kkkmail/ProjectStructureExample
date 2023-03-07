using Sample.Interfaces.DataAccess;
using Sample.Interfaces.Email;
using Sample.Interfaces.ErrorLogging;

namespace Sample.Email;

public class EmailClient : IEmailClient
{
    public EmailClient(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
