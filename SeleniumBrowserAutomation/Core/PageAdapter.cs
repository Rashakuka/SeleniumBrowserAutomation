using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBrowserAutomation.Core.Browsers;

namespace SeleniumBrowserAutomation.Core
{
    public sealed class PageAdapter<T> : IPage where T : IWebDriver
    {
        private readonly BrowserAdapter<T> _browser;
        private readonly T _driver;

        public PageAdapter(BrowserAdapter<T> browser)
        {
            _browser = browser;
            _driver = browser.Driver;
        }

        public string Title => _driver.Title;
        public string PageSource => _driver.PageSource;
        public string CurrentWindowHandle => _driver.CurrentWindowHandle;
        public string CurrentPage => _driver.Url;
        public ReadOnlyCollection<string> WindowHandles => _driver.WindowHandles;

        public void GoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public IEnumerable<IWebElement> FindElements(By by)
        {
            return _driver.FindElements(by);
        }

        public void NavigateBack()
        {
            _driver.Navigate().Back();
        }

        public void Refresh()
        {
            _driver.Navigate().Refresh();
        }

        public void Close()
        {
            _driver.Close();
        }

        public void Quit()
        {
            _driver.Quit();
        }

        public IWebElement FindElement(By by)
        {
            WaitElement(by);
            return _driver.FindElement(by);
        }

        ReadOnlyCollection<IWebElement> ISearchContext.FindElements(By by)
        {
            return _driver.FindElements(by);
        }

        public IOptions Manage()
        {
            return _driver.Manage();
        }

        public INavigation Navigate()
        {
            return _driver.Navigate();
        }

        public ITargetLocator SwitchTo()
        {
            return _driver.SwitchTo();
        }

        public IWebDriver SwitchToIFrame(By by)
        {
            WaitElement(by);
            IWebElement parentFrame = _driver.FindElements(by).First();
            
            return _driver.SwitchTo().Frame(parentFrame);
        }

        public void SwitchToParentFrame()
        {
            _driver.SwitchTo().DefaultContent();
        }

        public IWebElement WaitElementShow(By by)
        {
            WaitElement(by);
            return _driver.FindElements(by).First();
        }

        public void WaitElement(By by)
        {
            IWait<IWebDriver> wait = new DefaultWait<IWebDriver>(_driver);
            wait.Timeout = TimeSpan.FromSeconds(10);
            wait.PollingInterval = TimeSpan.FromMilliseconds(300);
            wait.Until(d => d.FindElements(by).Count > 0);
        }

        public string Url { get; set; }

        public void Dispose()
        {
            _driver.SwitchTo();
        }
    }
}
