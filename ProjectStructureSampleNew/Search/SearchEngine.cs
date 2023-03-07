using Sample.Interfaces.DataAccess;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.Search;
using Sample.Interfaces.UserActivity;

namespace Sample.Search;

public class SearchEngine : ISearchEngine
{
    public SearchEngine(
        IErrorLogger errorLogger,
        IDatabaseRepository databaseRepository,
        IUserActivityTracker userActivityTracker)
    {
    }
}
