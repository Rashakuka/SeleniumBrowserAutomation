using NUnit.Framework;
using SeleniumBrowserAutomation.Core;
using SeleniumBrowserAutomation.Pages;

namespace SeleniumBrowserAutomation.Flows
{
    [TestFixture]
    public class HomeTest : TestBase
    {
        [Test]
        public void Navigate_ShouldOpen_WebSite()
        {
            var homePage = new HomePage(Driver);

            homePage.Navigate();

            homePage.AssertOpenHomePage();
        }

        [Test]
        public void LoginClick_ShouldOpen_SignInPage()
        {
            var homePage = new HomePage(Driver);

            homePage.Navigate();

            homePage.LoginClick();

            homePage.IFrameLoginSelect();

            homePage.AssertOpenLoginPage();
        }

        [Test]
        public void SignUpClick_ShouldOpen_SignUpPage()
        {
            var homePage = new HomePage(Driver);

            homePage.Navigate();

            homePage.LoginClick();

            homePage.IFrameLoginSelect();

            homePage.SignUpClick();

            homePage.AssertOpenSignUpPage();
        }

        [Test]
        public void SearchYankees_ShouldOpen_BasketballPage()
        {
            var homePage = new HomePage(Driver);

            homePage.Navigate();

            homePage.GlobalSearchIconClick();

            var searchInfo = new HomeInfo(Search: "Yankees");

            homePage.FillInfo(searchInfo);

            homePage.AssertOpenYankeesSearchPage();
        }
    }
}
