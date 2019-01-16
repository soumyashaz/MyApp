using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MyApp.Pages
{
    public class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public IWebElement EnterFirstName
        {
            get { return WebDriver.FindElement(By.Id("profile_first_name")); }
        }
        public IWebElement EnterLastName
        {
            get { return WebDriver.FindElement(By.Id("profile_last_name")); }
        }
        public SelectElement SelectCountry
        {
            get { return new SelectElement(WebDriver.FindElement(By.Id("profile_country"))); }
        }
        public IWebElement EnterAddress
        {
            get { return WebDriver.FindElement(By.Id("profile_address")); }
        }
        public IWebElement EnterContactNo
        {
            get { return WebDriver.FindElement(By.Id("profile_contact_no")); }
        }
        public IWebElement EnterDateOfBirth
        {
            get { return WebDriver.FindElement(By.Id("profile_dob")); }
        }
        public IWebElement EnterEmail
        {
            get { return WebDriver.FindElement(By.Id("profile_email")); }
        }
        public IWebElement EnterPassword
        {
            get { return WebDriver.FindElement(By.Id("password")); }
        }
        public IWebElement EnterConfirmPassword
        {
            get { return WebDriver.FindElement(By.Id("identity[password_confirmation]")); }
        }
        public void EnterCaptcha()
        {

        }
        public void ClickCreateProfile()
        {
            WebDriver.FindElement(By.XPath(".//input[@name = 'commit']")).Click();
        }
    }
}
