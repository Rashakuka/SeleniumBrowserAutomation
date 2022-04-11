using OpenQA.Selenium;
using SeleniumBrowserAutomation.Core.Browsers;
using SeleniumSeleniumBrowserAutomation;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class SportPage
    {
        private readonly IBrowser _browser;

        public SportPage(IBrowser browser)
        {
            _browser = browser;
        }

        public void FollowClick()
        {
            _browser.JavaScript.FireClickJQueryEvent(FollowButton);
        }
    }
}
