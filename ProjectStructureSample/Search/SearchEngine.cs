using Sample.DataAccess;
using Sample.ErrorLogging;
using Sample.UserActivity;

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
