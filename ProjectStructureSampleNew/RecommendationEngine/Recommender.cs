using Sample.Interfaces.DataAccess;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.RecommendationEngine;

namespace Sample.RecommendationEngine;

public class Recommender : IRecommender
{
    public Recommender(IErrorLogger errorLogger, IDatabaseRepository databaseRepository)
    {
    }
}
