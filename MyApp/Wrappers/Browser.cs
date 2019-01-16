using OpenQA.Selenium;

namespace MyApp.Wrappers
{
    public static class Browser
    {
        public static IJavaScriptExecutor Scripts(this IWebDriver driver)
        {
            return (IJavaScriptExecutor)driver;
        }
    }
}
