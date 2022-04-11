using NUnit.Framework;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class LoginPage
    {
        public void AssertHomeFormSent()
        {
            Assert.True(_browser.Page.CurrentPage.EndsWith("espn.com") || _browser.Page.CurrentPage.EndsWith("espn.com/Login"), "Form not sent");
        }

        public void AssertLoginValidationDisplayed()
        {
            _browser.JavaScript.WaitReadyState();
            Assert.True(LoginValidation.Displayed);
        }
    }
}
