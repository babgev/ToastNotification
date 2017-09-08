using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using System.Windows;
using ToastContracts;
using ToastThis.ViewModel;

namespace ToastThis
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IToastNotificationService toastNotificationService = new ToastNotificationService.ToastNotificationService();
        private readonly ViewModelLocator viewModelLocator = new ViewModelLocator();
        public App()
        {
            InitializeComponent();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            DispatcherHelper.Initialize();

            RegisterToastNotficationService(toastNotificationService);
        }

        public void RegisterToastNotficationService(IToastNotificationService toastNotificationService)
        {
            MainViewModel mainViewModel = viewModelLocator.Main;
            mainViewModel.ToastNotificationService = toastNotificationService;
        }
    }
}
