using Sample.Authentication;
using Sample.ContentCreation;
using Sample.DataAccess;
using Sample.DataImport;
using Sample.Email;
using Sample.ErrorLogging;
using Sample.InventoryManagement;
using Sample.NotificationManagement;
using Sample.OrderProcessing;
using Sample.PaymentProcessing;
using Sample.RecommendationEngine;
using Sample.SalesReporting;
using Sample.SubscriptionManagement;

namespace Sample.ScheduledTasks;

public class TaskScheduler : ITaskScheduler
{
    public TaskScheduler(
        ISalesReporter salesReporter,
        IRecommender recommender,
        IContentManager contentManager,
        IDataImporter dataImporter,
        ISubscriptionManager subscriptionManager,
        IInventoryManager inventoryManager,
        INotificationManager notificationManager,
        IOrderProcessor orderProcessor,
        IPaymentProcessor paymentProcessor,
        IEmailClient emailClient,
        IErrorLogger errorLogger)
    {
        // Even though low level projects are not referenced by ScheduledTasks project,
        // the implementations of these low level classes is available here.
        var shouldNotBeAccessible = new AuthenticationManager(new ErrorLogger(), new DatabaseRepository(new ErrorLogger()));
    }
}
