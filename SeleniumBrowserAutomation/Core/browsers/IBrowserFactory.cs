using OpenQA.Selenium;

namespace SeleniumBrowserAutomation.Core.Browsers
{
    public interface IBrowserFactory
    {
        IBrowser Create<T>() where T : IWebDriver;
    }
}
