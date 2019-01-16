using OpenQA.Selenium;

namespace MyApp.Pages
{
    public class SignInPage : BasePage
    {
        public SignInPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public IWebElement EnterEmail
        {
            get { return WebDriver.FindElement(By.Id("name")); }
        }
        public IWebElement EnterPassword
        {
            get { return WebDriver.FindElement(By.Id("password")); }
        }
        public void ClickSigninbutton()
        {
            WebDriver.FindElement(By.XPath(".//input[@name = 'commit']")).Click();
        }
    }
}
