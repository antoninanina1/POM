using NUnit.Framework;
using SeleniumPOM.Driver;
using SeleniumPOM.Page;

namespace SeleniumPOM;

public class TestClass
{
    private LoginPage _loginPage;
    private HomePage _homePage;

    [SetUp]

    public void BeforeScenario()
    {
        WebDriver.Initialize();
        _loginPage = new LoginPage();
        _homePage = new HomePage();

    }

    [TearDown]
    public void AfterScenario()
    {
        WebDriver.CleanUp();
    }


    [Test]

    public void TC01_FillInputWithValidData_ShouldAllDataDisplayedInInput()
    {

        Login("execute", "automation");
        _homePage.Initial.SendKeys("AT");
        _homePage.Title("Ms.");
        _homePage.FirstName.SendKeys("Antonina");
        _homePage.MiddleName.SendKeys("Tasic");
        _homePage.Female.Click();
        _homePage.Hindi.Click();
        _homePage.SaveButton.Click();
    }

    [Test]
    public void TC02_OpenPopUp_ShouldDisplayed()
    {
        Login("execute", "automation");
        _homePage.HtmlPopup.Click();

    
    }


    [Test]
    public void TC03_OpenAlert_ShouldDisplayed()
    {
        Login("execute", "automation");
        _homePage.Alert();

     
    }


    public void Login(string name, string pass)
    {
        _loginPage.LoginOnPage(name, pass);
    }
}
