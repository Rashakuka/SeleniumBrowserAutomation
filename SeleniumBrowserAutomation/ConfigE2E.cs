using SeleniumBrowserAutomation.Configuration;

namespace SeleniumSeleniumBrowserAutomation
{
    public static class ConfigE2E
    {
        public static string E2EServerUrl => ConfigurationHelper.AppSetting("E2EServerUrl");
        public static string Username => ConfigurationHelper.AppSetting("Username");
        public static string Password => ConfigurationHelper.AppSetting("Password");
    }
}
