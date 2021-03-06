using OpenQA.Selenium;

namespace SeleniumBrowserAutomation.Core.Browsers
{
    public interface IBrowser
    {
        IPage Page { get; }
        IJavaScript JavaScript { get; }
    }

    public interface IBrowser<out T> : IBrowser where T : IWebDriver
    {
        BrowserType Type { get; }
        T Driver { get; }
    }
}
