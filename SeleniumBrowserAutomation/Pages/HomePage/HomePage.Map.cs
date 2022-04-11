using OpenQA.Selenium;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class HomePage
    {
        public IWebElement NavBarLogo => _browser.Page.FindElement(By.CssSelector(".navbar-header .navbar-brand"));
        public IWebElement LoginButton => _browser.Page.FindElement(By.CssSelector(".account-management li:nth-child(4) > a"));
        public IWebElement SignUpButton => _browser.Page.FindElement(By.CssSelector(".btn-group-create-account a"));
        public IWebElement LoginModal => _browser.Page.FindElement(By.Id("disneyid-wrapper"));
        public IWebElement SignUpModal => _browser.Page.FindElement(By.Id("disneyid-wrapper"));
        public IWebElement GlobalSearchIcon => _browser.Page.FindElement(By.Id("global-search-trigger"));
        public IWebElement FollowButton => _browser.Page.FindElement(By.CssSelector(".ClubhouseHeader__Follow"));
        public IWebElement GlobalSearchInput => _browser.Page.FindElement(By.Id("global-search-input"));
        public IWebElement SubmitSearchInput => _browser.Page.FindElement(By.CssSelector(".btn-search"));
        public By LoginIFrame => By.Id("disneyid-iframe");
        public By SignUpIFrame => By.Id("disneyid-iframe");
    }
}
