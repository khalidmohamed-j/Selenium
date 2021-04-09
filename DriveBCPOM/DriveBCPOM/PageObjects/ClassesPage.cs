using OpenQA.Selenium;

namespace DriveBCPOM.PageObjects
{
    public class ClassesPage
    {
        private IWebDriver _driver;

        public ClassesPage(IWebDriver driver) => _driver = driver;

        IWebElement Title => _driver.FindElement(By.CssSelector("#content > h2"));
        public string GetTitleText() => Title.Text;
    }
}
