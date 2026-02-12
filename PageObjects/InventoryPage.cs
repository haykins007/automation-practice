using OpenQA.Selenium;
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

        private By productPrices = By.ClassName("inventory_item_price");

        public InventoryPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public decimal GetFirstProductPrice()
        {
            var priceText = _driver
                .FindElements(productPrices)
                .First()
                .Text;

            return decimal.Parse(priceText.Replace("$", ""));
        }

    }
}
