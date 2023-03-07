using Sample.DataAccess;
using Sample.ErrorLogging;
using Sample.Search;
using Sample.SubscriptionManagement;

namespace Sample.ContentCreation;

public class ContentManager : IContentManager
{
    public ContentManager(
        IErrorLogger errorLogger,
        IDatabaseRepository databaseRepository,
        ISearchEngine searchEngine,
        ISubscriptionManager subscriptionManager)
    {
    }
}
