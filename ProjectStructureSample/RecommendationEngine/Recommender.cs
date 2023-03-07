using Sample.DataAccess;
using Sample.ErrorLogging;

namespace Sample.RecommendationEngine;

public class Recommender : IRecommender
{
    public Recommender(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
