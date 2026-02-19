using AutomationPractice.Drivers;
using OpenQA.Selenium;
using Reqnroll;

namespace AutomationPractice.Hooks
{
    [Binding]
    public class Hooks
    {
        private IWebDriver _driver;

        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
            _driver = DriverFactory.CreateDriver();
            ScenarioContext.Current["driver"] = _driver;

        }


        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}