using Sample.Interfaces.DataAccess;
using Sample.Interfaces.DataImport;
using Sample.Interfaces.ErrorLogging;

namespace Sample.DataImport;

public class DataImporter : IDataImporter
{
    public DataImporter(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
