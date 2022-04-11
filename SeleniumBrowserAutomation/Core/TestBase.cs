using System;
using NUnit.Framework;
using SeleniumBrowserAutomation.Core.Browsers;

namespace SeleniumBrowserAutomation.Core
{
    [SetUpFixture]
    public class TestBase
    {
        public bool _testFailed;
        private readonly Lazy<BrowserFactory> _factory = new Lazy<BrowserFactory>();
        protected IBrowser Driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Driver = _factory.Value.GetBrowser(Config.Browser);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status != NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                _testFailed = true;
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            if (Config.RemoteBrowser && Config.UseSauceLabs)
            {
                Driver.JavaScript.Execute($"sauce:job-result={(_testFailed ? "failed" : "passed")}");
            }
            Driver.Page.Quit();
        }
    }
}
