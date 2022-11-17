using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace SeleniumPOM.Driver
{
    public static class WebDriver
    {
        public static IWebDriver? Instance { get; set; }


        public static void Initialize()
        {
            Instance = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Instance.Navigate().GoToUrl("https://demosite.executeautomation.com");
        }


        public static void CleanUp()
        {
            Instance?.Quit();
        }

    }
}
