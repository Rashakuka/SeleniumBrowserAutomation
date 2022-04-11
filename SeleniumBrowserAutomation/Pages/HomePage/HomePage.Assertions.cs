using System.Linq;
using NUnit.Framework;
using SeleniumSeleniumBrowserAutomation;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class HomePage
    {
        public void AssertOpenHomePage()
        {
            Assert.True(_browser.Page.CurrentPage.Contains("espn.com"), "Home page not found");
        }

        public void AssertOpenYankeesSearchPage()
        {
            Assert.True(_browser.Page.CurrentPage.Contains("Yankees") || _browser.Page.CurrentPage.Contains("search"), "Yankees page not found");
        }

        public void AssertCheckNewTab()
        {
            SwitchToLastTab();
            Assert.True(_browser.Page.CurrentPage.Contains("espn.com"), "espn.com web site url not found");
        }

        public void AssertOpenLoginPage()
        {
            Assert.True(_browser.Page.CurrentPage.Contains("espn.com"), "espn.com web site url not found");
        }

        public void AssertOpenSignUpPage()
        {
            Assert.True(_browser.Page.CurrentPage.Contains("espn.com"), "espn.com web site url not found");
        }

        public void AssertOpenPage()
        {
            Assert.True(_browser.Page.CurrentPage.Contains(ConfigE2E.E2EServerUrl), " page not found");
        }

        private void SwitchToLastTab()
        {
            _browser.Page.SwitchTo().Window(_browser.Page.WindowHandles.Last());
        }
    }
}
