using SeleniumBrowserAutomation.Core.Browsers;
using SeleniumSeleniumBrowserAutomation;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class SignUpPage
    {
        private readonly IBrowser _browser;

        public SignUpPage(IBrowser browser)
        {
            _browser = browser;
        }

        public void FillInfo(SignUpInfo signUpInfo)
        {
            FirstName.SendKeys(signUpInfo.FirstName);
            LastName.SendKeys(signUpInfo.LastName);
            Email.SendKeys(signUpInfo.Email);
            Password.SendKeys(signUpInfo.Password);
            ClickSubmitButton();
        }

        public void SwitchToParentFrame() 
        {
            _browser.Page.SwitchToParentFrame();
        }

        private void ClickSubmitButton()
        {
            _browser.JavaScript.FireClickJQueryEvent(SubmitButton);
        }
    }
}
