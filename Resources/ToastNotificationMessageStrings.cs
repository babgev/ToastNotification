namespace ToastThis.Resources
{
    public class ToastNotificationMessageStrings
    {
        public const string SaveSuccess = "This is a success.";

        public const string SaveFailed = "This has failed.";

        public const string SaveWarning = "This is a warning.";

        public static string TextInput(string action)
        {
            return string.Format("{0} input completed.", action);
        }        
    }
}
