using NUnit.Framework;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class SignUpPage
    {
        public void AssertHomeFormSent()
        {
            Assert.True(_browser.Page.CurrentPage.EndsWith("espn.com/"), "Form not sent");
        }
    }
}
