using OpenQA.Selenium;
using System;

namespace MyApp.Pages
{
    public static class PageFactory
    {
        public static T Create<T>(IWebDriver webDriver) where T : IPage
        {
            return (T)Activator.CreateInstance(typeof(T), webDriver);
        }
    }
}
