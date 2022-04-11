using System.Linq;
using NUnit.Framework;
using SeleniumSeleniumBrowserAutomation;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class SportPage
    {
        public void AssertOpenSportPage()
        {
            Assert.True(_browser.Page.CurrentPage.Contains("new-york-yankees"), "Home page not found");
        }
    }
}
