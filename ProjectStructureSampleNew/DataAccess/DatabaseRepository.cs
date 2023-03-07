using Sample.Interfaces.DataAccess;
using Sample.Interfaces.ErrorLogging;

namespace Sample.DataAccess;

public class DatabaseRepository : IDatabaseRepository
{
    public DatabaseRepository(IErrorLogger errorLogger)
    {
    }
}
