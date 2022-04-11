using OpenQA.Selenium;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class SportPage
    {
        public IWebElement FollowButton => _browser.Page.FindElement(By.CssSelector(".ClubhouseHeader__Follow"));
    }
}
