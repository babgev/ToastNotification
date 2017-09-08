namespace ToastContracts
{
    public interface IModule
    {
        void RegisterViewModelLocator();

        void RegisterToastNotficationService(IToastNotificationService toastNotificationService);
    }
}
