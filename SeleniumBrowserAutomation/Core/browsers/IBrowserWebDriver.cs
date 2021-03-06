using OpenQA.Selenium;

namespace SeleniumBrowserAutomation.Core.Browsers
{
    public interface IBrowserWebDriver<out T> where T : IWebDriver
    {
        IBrowser<T> Create();
    }
}
