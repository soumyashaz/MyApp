using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            
        }
        public RegisterPage ClickRegister()
        {
            WebDriver.FindElement(By.LinkText("Register")).Click();
            var registerPage = PageFactory.Create<RegisterPage>(WebDriver);
            registerPage.WaitLoading();
            return registerPage;
        }
        public SignInPage ClickSignIn()
        {
            WebDriver.FindElement(By.LinkText("Sign in")).Click();
            var signinPage = PageFactory.Create<SignInPage>(WebDriver);
            signinPage.WaitLoading();
            return signinPage;
        }
    }
}
