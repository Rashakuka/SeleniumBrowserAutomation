using SeleniumBrowserAutomation.Configuration;
using System;

namespace SeleniumBrowserAutomation.Core.Browsers
{
    public class Config
    {
        public static bool RemoteBrowser
        {
            get
            {
                var remoteBrowser = bool.Parse(ConfigurationHelper.AppSetting("RemoteBrowser"));
#if E2E
                remoteBrowser = true;
#endif
                return remoteBrowser;
            }  
        }
        public static BrowserType Browser => (BrowserType) Enum.Parse(typeof(BrowserType), ConfigurationHelper.AppSetting("Browser"));
        public static string Platform => ConfigurationHelper.AppSetting("Platform");
        public static string BaseUrl => ConfigurationHelper.AppSetting("BaseUrl");
        public static string Username => ConfigurationHelper.AppSetting("Username");
        public static string Password => ConfigurationHelper.AppSetting("Password");

        public static bool UseSeleniumGrid => bool.Parse(ConfigurationHelper.AppSetting("UseSeleniumGrid"));
        public static string GridHubUri => ConfigurationHelper.AppSetting("GridHubUrl");

        public static bool UseSauceLabs => bool.Parse(ConfigurationHelper.AppSetting("UseSauceLabs"));
        public static string SauceLabsHubUri => ConfigurationHelper.AppSetting("SauceLabsHubUrl");
        public static string SauceLabsUsername => ConfigurationHelper.AppSetting("SauceLabsUsername");
        public static string SauceLabsAccessKey => ConfigurationHelper.AppSetting("SauceLabsAccessKey");

        public static bool UseBrowserstack => bool.Parse(ConfigurationHelper.AppSetting("BrowserStack"));
        public static string BrowserStackHubUrl => ConfigurationHelper.AppSetting("BrowserStackHubUrl");
        public static string BrowserStackUsername => ConfigurationHelper.AppSetting("BrowserStackUsername");
        public static string BrowserStackAccessKey => ConfigurationHelper.AppSetting("BrowserStackAccessKey");

    }
}
