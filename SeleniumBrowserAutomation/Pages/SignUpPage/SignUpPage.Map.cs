using OpenQA.Selenium;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class SignUpPage
    {
        public IWebElement FirstName => _browser.Page.FindElement(By.XPath("input[@name='firstName']"));
        public IWebElement LastName => _browser.Page.FindElement(By.XPath("input[@name='lastName']"));
        public IWebElement Email => _browser.Page.FindElement(By.XPath("input[@name='email']"));
        public IWebElement Password => _browser.Page.FindElement(By.XPath("input[@name='newPassword']"));
        public IWebElement SubmitButton => _browser.Page.FindElement(By.XPath("//button[type='submit']"));
        public By SignUpIFrame => By.Id("disneyid-iframe");
        
    }
}
