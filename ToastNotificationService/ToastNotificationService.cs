using System.Windows;
using System.Windows.Media;

//locals

//3rd party
using GalaSoft.MvvmLight.Threading;
using ToastContracts;
using Telerik.Windows.Controls;

namespace ToastThis.ToastNotificationService
{
    public class ToastNotificationService : IToastNotificationService
    {
        private readonly RadDesktopAlertManager radDesktopAlertManager = new RadDesktopAlertManager(AlertScreenPosition.BottomRight);

        public void CloseAllToastNotifications()
        {
            radDesktopAlertManager.CloseAllAlerts();
        }

        public void ShowFailedToastNotification(string content, string header = "FAILED", int duration = 86400000)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                RadDesktopAlert alert = CreateRadDesktopAlert(content, header, duration);
                alert.Background = (SolidColorBrush)Application.Current.Resources["IconColorRed"];
                radDesktopAlertManager.ShowAlert(alert);
            });
        }

        public void ShowSuccessToastNotification(string content, string header = "SUCCESS", int duration = 3000)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                RadDesktopAlert alert = CreateRadDesktopAlert(content, header, duration);
                alert.Background = (SolidColorBrush)Application.Current.Resources["IconColorGreen"];
                radDesktopAlertManager.ShowAlert(alert);
            });
        }

        public void ShowWarningToastNotification(string content, string header = "WARNING", int duration = 86400000)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                RadDesktopAlert alert = CreateRadDesktopAlert(content, header, duration);
                alert.Background = (SolidColorBrush)Application.Current.Resources["IconColorYellow"];
                radDesktopAlertManager.ShowAlert(alert);
            });
        }

        private RadDesktopAlert CreateRadDesktopAlert(string content, string header, int duration)
        {
            RadDesktopAlert result = new RadDesktopAlert();
            result.Header = header;
            result.Content = content;
            result.ShowDuration = duration;
            return result;
        }
    }
}
