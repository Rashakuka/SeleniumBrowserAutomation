using NUnit.Framework;
using SeleniumBrowserAutomation.Core;
using SeleniumBrowserAutomation.Pages;
using SeleniumSeleniumBrowserAutomation;

namespace SeleniumBrowserAutomation.Flows
{
    [TestFixture]
    public class LoginTest : TestBase
    {
        [Test]
        public void FormSentUser_When_InfoValid()
        {
            var homePage = new HomePage(Driver);

            homePage.Navigate();

            homePage.LoginClick();

            homePage.IFrameLoginSelect();

            var loginPage = new LoginPage(Driver);

            var clientInfo = new LoginInfo(Username: $"{ConfigE2E.Username}",
                                            Password: $"{ConfigE2E.Password}");

            loginPage.FillInfo(clientInfo);

            loginPage.AssertHomeFormSent();
        }

        [Test]
        public void ValidatedLogin_When_UsernameNotSet()
        {
            var homePage = new HomePage(Driver);

            homePage.Navigate();

            homePage.LoginClick();

            homePage.IFrameLoginSelect();

            var loginPage = new LoginPage(Driver);

            var clientInfo = new LoginInfo(Username: "",
                                            Password: "ValidPassword");

            loginPage.FillInfo(clientInfo);

            loginPage.AssertLoginValidationDisplayed();
        }

        [Test]
        public void ValidatedLogin_When_PasswordNotSet()
        {
            var homePage = new HomePage(Driver);

            homePage.Navigate();

            homePage.LoginClick();

            homePage.IFrameLoginSelect();

            var loginPage = new LoginPage(Driver);

            var clientInfo = new LoginInfo(Username: "ValidUsername",
                                            Password: "");

            loginPage.FillInfo(clientInfo);

            loginPage.AssertLoginValidationDisplayed();
        }

        [Test]
        public void ValidatedLogin_When_WrongCredentials()
        {
            var homePage = new HomePage(Driver);

            homePage.Navigate();

            homePage.LoginClick();

            homePage.IFrameLoginSelect();

            var loginPage = new LoginPage(Driver);

            var clientInfo = new LoginInfo(Username: "WrongUsername",
                                            Password: "WrongPassword");

            loginPage.FillInfo(clientInfo);

            loginPage.AssertLoginValidationDisplayed();
        }
    }
}
