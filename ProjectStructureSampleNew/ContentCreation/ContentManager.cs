using Sample.Interfaces.ContentCreation;
using Sample.Interfaces.DataAccess;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.Search;
using Sample.Interfaces.SubscriptionManagement;

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
