using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DriveBCPOM
{
    public class Driver
    {
        public static IWebDriver BCTestDriver;

        public static void InitializeDriver()
        {
            InitDriverNoLogging();
            BCTestDriver.Navigate().GoToUrl("https://www.bellevuecollege.edu");
        }

        //public static void QuitDriver()
        //{
        //    BCTestDriver.Quit();
        //}
        public static void QuitDriver() => BCTestDriver.Quit();

        public static void GoBack() => BCTestDriver.Navigate().Back();

        private static void InitDriverNoLogging()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.EnableVerboseLogging = false;
            service.SuppressInitialDiagnosticInformation = true;
            service.HideCommandPromptWindow = true;

            ChromeOptions options = new ChromeOptions();

            options.PageLoadStrategy = PageLoadStrategy.Normal;

            options.AddArgument("--window-size=1920,1080");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--disable-crash-reporter");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-in-process-stack-traces");
            options.AddArgument("--disable-logging");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--log-level=3");
            options.AddArgument("--output=/dev/null");

            BCTestDriver = new ChromeDriver(service);

        }

    }
}
