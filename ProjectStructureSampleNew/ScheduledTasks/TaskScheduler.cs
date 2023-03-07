using Sample.Interfaces.Authentication;
using Sample.Interfaces.ContentCreation;
using Sample.Interfaces.DataAccess;
using Sample.Interfaces.DataImport;
using Sample.Interfaces.Email;
using Sample.Interfaces.ErrorLogging;
using Sample.Interfaces.InventoryManagement;
using Sample.Interfaces.NotificationManagement;
using Sample.Interfaces.OrderProcessing;
using Sample.Interfaces.PaymentProcessing;
using Sample.Interfaces.RecommendationEngine;
using Sample.Interfaces.SalesReporting;
using Sample.Interfaces.ScheduledTasks;
using Sample.Interfaces.SubscriptionManagement;

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
        // The implementations of low level classes is NOT available here.
        // The line below will not compile without referencing the relevant projects.
        // var shouldNotBeAccessible = new AuthenticationManager(new ErrorLogger(), new DatabaseRepository(new ErrorLogger()));
    }
}
