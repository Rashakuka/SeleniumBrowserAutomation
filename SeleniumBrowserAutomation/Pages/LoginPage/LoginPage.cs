using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBrowserAutomation.Core.Browsers;
using SeleniumSeleniumBrowserAutomation;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class LoginPage
    {
        private readonly IBrowser _browser;

        public LoginPage(IBrowser browser)
        {
            _browser = browser;
        }

        public void FillInfo(LoginInfo loginInfo)
        {
            Username.SendKeys(loginInfo.Username);
            Password.SendKeys(loginInfo.Password);
            ClickSubmitButton();
        }

        private void ClickSubmitButton()
        {
            _browser.JavaScript.FireClickJQueryEvent(SubmitButton);
        }
    }
}
