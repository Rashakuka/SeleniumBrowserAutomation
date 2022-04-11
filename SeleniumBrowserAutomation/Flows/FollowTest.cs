using NUnit.Framework;
using SeleniumBrowserAutomation.Core;
using SeleniumBrowserAutomation.Pages;
using SeleniumSeleniumBrowserAutomation;

namespace SeleniumBrowserAutomation.Flows
{
    [TestFixture]
    public class FollowTest : TestBase
    {
        [Test]
        public void FollowFlow_Should_FollowFavoriteSport()
        {
            var homePage = new HomePage(Driver);

            homePage.Navigate();

            homePage.LoginClick();

            homePage.IFrameLoginSelect();

            var loginPage = new LoginPage(Driver);

            var clientInfo = new LoginInfo(Username: $"{ConfigE2E.Username}",
                                            Password: $"{ConfigE2E.Password}");

            loginPage.FillInfo(clientInfo);

            homePage.GlobalSearchIconClick();

            var searchInfo = new HomeInfo(Search: "Yankees");

            homePage.FillInfo(searchInfo);

            var followPage = new SportPage(Driver);

            followPage.FollowClick();

            followPage.AssertOpenSportPage();
        }
    }
}
