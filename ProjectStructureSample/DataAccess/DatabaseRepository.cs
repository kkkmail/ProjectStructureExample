using Sample.ErrorLogging;

namespace Sample.DataAccess;

public class DatabaseRepository : IDatabaseRepository
{
    public DatabaseRepository(IErrorLogger errorLogger)
    {
    }
}
