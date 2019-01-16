using MyApp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Configuration;

namespace MyApp
{
    public static class MyAppWebApp
    {
        public static HomePage Open()
        {
            IWebDriver webDriver = null;

            if (ConfigurationManager.AppSettings["Browser"].ToLower() == "firefox")
            {
                FirefoxOptions firefoxProfile = new FirefoxOptions();
                firefoxProfile.SetPreference("browser.download.folderList", 2);
                firefoxProfile.SetPreference("browser.download.manager.showWhenStarting", false);
                firefoxProfile.SetPreference("browser.download.dir", Environment.CurrentDirectory);
                firefoxProfile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/pdf");
                webDriver = new FirefoxDriver(firefoxProfile);
            }

            if (ConfigurationManager.AppSettings["Browser"].ToLower() == "chrome")
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddUserProfilePreference("download.default_directory", Environment.CurrentDirectory);
                webDriver = new ChromeDriver(chromeOptions);
            }

            if (ConfigurationManager.AppSettings["Browser"].ToLower() == "internetexplorer")
            {
                webDriver = new InternetExplorerDriver();
            }

            if(ConfigurationManager.AppSettings["Browser"].ToLower() == "edge")
            {
                EdgeOptions edgeOptions = new EdgeOptions();
                webDriver = new EdgeDriver(edgeOptions);
            }

            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(ConfigurationManager.AppSettings["Environment"]);
            var homePage = PageFactory.Create<HomePage>(webDriver);
            homePage.WaitLoading();
            return homePage;
        }
    }
}
