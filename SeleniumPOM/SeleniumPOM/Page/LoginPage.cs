using OpenQA.Selenium;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page
{
    public class LoginPage
    {

        private IWebDriver _driver = WebDriver.Instance;

        // ovde ubaciti selectore

        public void LoginOnPage(string name, string password)
        {
           //methoda za Lopgin pozvati slectore ovde
        }
    }
}
