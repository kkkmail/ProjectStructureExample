using Sample.DataAccess;
using Sample.ErrorLogging;

namespace Sample.DataImport;

public class DataImporter : IDataImporter
{
    public DataImporter(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
