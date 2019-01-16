using MyApp.Wrappers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace MyApp.Pages
{
    public class BasePage : IPage
    {
        protected IWebDriver WebDriver { get; set; }
        public BasePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public string Title
        {
            get { return WebDriver.Title; }
        }
        public string Url
        {
            get { return WebDriver.Url; }
        }
        public void AcceptDialog()
        {
            WebDriver.SwitchTo().Alert().Accept();
        }
        public void DismissAlert()
        {
            WebDriver.SwitchTo().Alert().Dismiss();
        }
        public void BrowserRefresh()
        {
            WebDriver.Navigate().Refresh();
        }
        public void CancelDialog()
        {
            WebDriver.SwitchTo().Alert().Dismiss();
        }
        public void Quit()
        {
            WebDriver.Quit();
        }
        public void WaitLoading()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(double.Parse(ConfigurationManager.AppSettings["Timeout"])));
            wait.Until(driver => (bool)driver.Scripts().ExecuteScript("return document.readyState == 'complete'"));
        }
        public void SwitchToDefaultWindow()
        {
            WebDriver.SwitchTo().DefaultContent();
        }
        public void WaitForSpinnerDisappear()
        {
            WebDriverWait waitForSpinner = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(double.Parse(ConfigurationManager.AppSettings["Timeout"])));
            waitForSpinner.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath(".//div[@class='k-loading-image']")));
        }
    }
}
