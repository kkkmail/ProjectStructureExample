using Sample.DataAccess;
using Sample.ErrorLogging;

namespace Sample.Email;

public class EmailClient : IEmailClient
{
    public EmailClient(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
