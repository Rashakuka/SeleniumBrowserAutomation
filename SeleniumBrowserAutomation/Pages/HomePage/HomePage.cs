using SeleniumBrowserAutomation.Core;
using SeleniumBrowserAutomation.Core.Browsers;
using SeleniumSeleniumBrowserAutomation;
using System.Threading;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class HomePage
    {
        private readonly IBrowser _browser;

        public HomePage(IBrowser browser)
        {
            _browser = browser;
        }

        public void Navigate()
        {
            _browser.Page.Navigate().GoToUrl($"{ConfigE2E.E2EServerUrl}");
            Thread.Sleep(5000);
        }

        public void FillInfo(HomeInfo homeInfo)
        {
            GlobalSearchInput.SendKeys(homeInfo.Search);
            _browser.JavaScript.FireJQueryEvent(GlobalSearchInput, JavaScriptEvent.KeyUp);
            Thread.Sleep(5000);
        }

        public void IFrameLoginSelect()
        {
            _browser.Page.SwitchToIFrame(LoginIFrame);
        }

        public void IFrameSignUpSelect()
        {
            _browser.Page.SwitchToIFrame(SignUpIFrame);
        }

        public void LoginClick()
        {
            _browser.JavaScript.FireClickJQueryEvent(LoginButton);
        }

        public void GlobalSearchIconClick()
        {
            _browser.JavaScript.FireClickJQueryEvent(GlobalSearchIcon);
        }

        public void GlobalSearchInputClick()
        {
            _browser.JavaScript.FireClickJQueryEvent(GlobalSearchInput);
        }

        public void SignUpClick()
        {
            _browser.JavaScript.FireClickJQueryEvent(SignUpButton);
        }
    }
}
