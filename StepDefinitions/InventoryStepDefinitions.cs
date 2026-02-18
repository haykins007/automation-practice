using System;
using AutomationPractice.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace AutomationPractice.StepDefinitions
{
    [Binding]
    public class InventoryStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly InventoryPage _inventoryPage;

        public InventoryStepDefinitions(ScenarioContext scenarioContext)
        {
            _driver = scenarioContext["driver"] as IWebDriver;
            _inventoryPage = new InventoryPage(_driver);
        }

        [Given("I am logged into the application")]
        public void GivenIAmLoggedIntoTheApplication()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            var loginPage = new LoginPage(_driver);
            loginPage.Login("standard_user", "secret_sauce");
        }

        [When("I sort the products by {string}")]
        public void WhenISortTheProductsBy(string sortOption)
        {
            _inventoryPage.SortProducts(sortOption);
        }

        [Then("the first product price should be {string}")]
        public void ThenTheFirstProductPriceShouldBe(string expectedPrice)
        {
            var actualPrice = _inventoryPage.GetFirstProductPrice();
            var expected = decimal.Parse(expectedPrice.Replace("$", ""));

            Assert.That(actualPrice, Is.EqualTo(expected));
        }

        [Then(@"the number of products displayed should be ""(.*)""")]
        public void ThenTheNumberOfProductsDisplayedShouldBe(string expectedCount)
        {
            int actualCount = _inventoryPage.GetProductCount();
            int expected = int.Parse(expectedCount);

            Assert.That(actualCount, Is.EqualTo(expected));
        }
    }
}
