using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;

namespace SeleniumBrowserAutomation.Core.Browsers
{
    public sealed class BrowserFactory :
        AbstractFactory,
        IBrowserWebDriver<FirefoxDriver>,
        IBrowserWebDriver<ChromeDriver>,
        IBrowserWebDriver<RemoteWebDriver>
    {
        IBrowser<ChromeDriver> IBrowserWebDriver<ChromeDriver>.Create()
        {
            var dirName = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin", StringComparison.Ordinal));
            var fileInfo = new FileInfo(dirName);
            var parentDirName = fileInfo?.FullName;
            return new BrowserAdapter<ChromeDriver>(new ChromeDriver(parentDirName + @"BrowserWebDrivers"), BrowserType.Chrome);
        }

        IBrowser<FirefoxDriver> IBrowserWebDriver<FirefoxDriver>.Create()
        {
            var dirName = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin", StringComparison.Ordinal));
            var fileInfo = new FileInfo(dirName);
            var parentDirName = fileInfo?.FullName;
            var service = FirefoxDriverService.CreateDefaultService(parentDirName + @"\BrowserWebDrivers");
            service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            return new BrowserAdapter<FirefoxDriver>(new FirefoxDriver(service), BrowserType.Firefox);
        }

        IBrowser<RemoteWebDriver> IBrowserWebDriver<RemoteWebDriver>.Create()
        {

            var options = new ChromeOptions();
            var gridUrl = Config.GridHubUri;

            switch (Config.Browser)
            {
                case BrowserType.Chrome:
                    options = new ChromeOptions();
                    break;
                case BrowserType.Firefox:
                    options = new ChromeOptions();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (Config.RemoteBrowser && Config.UseSauceLabs)
            {
                var sauceOptions = new Dictionary<string, object>();
                var testName = TestContext.CurrentContext?.Test?.ClassName ?? "Unknown Test";
                sauceOptions.Add("name", testName);
                options.AddArguments("username", Config.SauceLabsUsername);
                options.AddArguments("accessKey", Config.SauceLabsAccessKey);
                options.AddAdditionalOption("sauce:options", sauceOptions);
                gridUrl = Config.SauceLabsHubUri;
            }
            else if (Config.RemoteBrowser && Config.UseBrowserstack)
            {
                options.AddArguments("username", Config.BrowserStackUsername);
                options.AddArguments("accessKey", Config.BrowserStackAccessKey);
                gridUrl = Config.BrowserStackHubUrl;
            }

            return
                new BrowserAdapter<RemoteWebDriver>(
                    new RemoteWebDriver(new Uri(gridUrl), options), BrowserType.Remote);
        }
    }
}
