using OpenQA.Selenium;

namespace SeleniumBrowserAutomation.Pages
{
    public partial class LoginPage
    {
        public IWebElement Username => _browser.Page.FindElement(By.XPath("//div[@id='did-ui-view']/div/section/section/form/section/div/div/label/span[2]/input"));
        public IWebElement Password => _browser.Page.FindElement(By.XPath("//div[@id='did-ui-view']/div/section/section/form/section/div[2]/div/label/span[2]/input"));
        public IWebElement LoginValidation => _browser.Page.WaitElementShow(By.CssSelector(".container .ng-scope"));
        public IWebElement SubmitButton => _browser.Page.FindElement(By.XPath("//button[@type='submit']"));
    }
}
