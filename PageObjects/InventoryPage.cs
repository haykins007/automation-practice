using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V142.Network;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.PageObjects
{
    public class InventoryPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        private By productPrices = By.ClassName("inventory_item_price");
        private By sortDropdown = By.ClassName("product_sort_container");
        private By inventoryItems = By.ClassName("inventory_item");

        public InventoryPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
        public decimal GetFirstProductPrice()
        {
            _wait.Until(driver => driver.FindElements(productPrices).Count > 0);

            var priceText = _driver
                .FindElements(productPrices)
                .First()
                .Text;

            return decimal.Parse(priceText.Replace("$", "").Trim());
        }
        public void SortProducts(string optionText)
        {
            var dropdownElement = _wait.Until(driver =>
            {
                var element = driver.FindElement(sortDropdown);
                return element.Displayed && element.Enabled ? element : null;
            });

            var dropdown = new SelectElement(dropdownElement);
            dropdown.SelectByText(optionText);
        }
        public int GetProductCount()
        {
            _wait.Until(driver => driver.FindElements(inventoryItems).Count > 0);
            return _driver.FindElements(inventoryItems).Count;
        }

    }
}
