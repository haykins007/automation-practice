using System;
using NUnit.Framework;
using Reqnroll;

namespace AutomationPractice.StepDefinitions
{
    [Binding]
    public class InventoryStepDefinitions
    {
        [Given("I am logged into the application")]
        public void GivenIAmLoggedIntoTheApplication()
        {
          
        }

        [When("I sort the products by {string}")]
        public void WhenISortTheProductsBy(string sortOption)
        {
          
        }

        [Then("the first product price should be {string}")]
        public void ThenTheFirstProductPriceShouldBe(string expectedPrice)
        {
            Assert.Pass("Assertion placeholder");
        }
    }
}
