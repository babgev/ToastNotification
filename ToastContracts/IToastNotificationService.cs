
namespace ToastContracts
{
    public interface IToastNotificationService
    {
        void CloseAllToastNotifications();
        void ShowFailedToastNotification(string content, string header = "FAILED", int duration = 86400000);
        void ShowSuccessToastNotification(string content, string header = "SUCCESS", int duration = 3000);
        void ShowWarningToastNotification(string content, string header = "WARNING", int duration = 86400000);
    }
}
