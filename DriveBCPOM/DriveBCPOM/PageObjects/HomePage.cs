using OpenQA.Selenium;

namespace DriveBCPOM.PageObjects
{
    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver) => _driver = driver;

        IWebElement Title => _driver.FindElement(By.CssSelector("#content"));
        IWebElement Classes => _driver.FindElement(By.CssSelector("#nav-classes > a"));

        public string GetTitleText() => Title.Text;
        public void ClickClasses() => Classes.Click();
        
    }
}
