using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page;

public class HomePage
{
    private IWebDriver _driver = WebDriver.Instance;

    // ovde ubaciti selectore

    public void SelectOption(string option)
    {
        SelectElement drop = new SelectElement(_driver.FindElement(By.Id("TitleId")));
        drop.SelectByText(option); // ovo vam sluzi da izabere iz drop downa Mr. ili Ms. potrebno je da mu u test kazete sta od ova dva zelite da izbare
    }


}
