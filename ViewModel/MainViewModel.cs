using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using ToastContracts;
using ToastThis.Resources;

namespace ToastThis.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public IToastNotificationService ToastNotificationService { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            OnErrorClicked = new RelayCommand(OnErrorClickedHandler);
            OnWarningClicked = new RelayCommand(OnWarningClickedHandler);
            OnSuccessClicked = new RelayCommand(OnSuccessClickedHandler);
        }

        public RelayCommand OnErrorClicked { get; private set; }
        public RelayCommand OnWarningClicked { get; private set; }
        public RelayCommand OnSuccessClicked { get; private set; }
        
        private void OnErrorClickedHandler()
        {           
            SimpleIoc.Default.GetInstance<MainViewModel>().ToastNotificationService.ShowFailedToastNotification(ToastNotificationMessageStrings.SaveFailed);
        }

        private void OnWarningClickedHandler()
        {
            SimpleIoc.Default.GetInstance<MainViewModel>().ToastNotificationService.ShowWarningToastNotification(ToastNotificationMessageStrings.SaveWarning);
        }

        private void OnSuccessClickedHandler()
        {
            SimpleIoc.Default.GetInstance<MainViewModel>().ToastNotificationService.ShowSuccessToastNotification(ToastNotificationMessageStrings.SaveSuccess);
        }
    }
}