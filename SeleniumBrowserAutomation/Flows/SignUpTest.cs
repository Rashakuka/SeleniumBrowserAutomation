using Bogus;
using NUnit.Framework;
using SeleniumBrowserAutomation.Core;
using SeleniumBrowserAutomation.Pages;

namespace SeleniumBrowserAutomation.Flows
{
    [TestFixture]
    public class SignUpTest : TestBase
    {
        [Test]
        public void FormSentUser_When_InfoValid()
        {
            var homePage = new HomePage(Driver);

            homePage.Navigate();

            homePage.LoginClick();

            homePage.IFrameLoginSelect();

            homePage.SignUpClick();

            var signUpPage = new SignUpPage(Driver);

            var faker = new Faker("en_US");

            var clientInfo = new SignUpInfo(FirstName: faker.Person.FirstName,
                                            LastName: faker.Person.LastName,
                                            Email: faker.Person.Email,
                                            Password: "fakePassword@48523");

            signUpPage.SwitchToParentFrame();

            signUpPage.FillInfo(clientInfo);

            signUpPage.AssertHomeFormSent();
        }
    }
}
