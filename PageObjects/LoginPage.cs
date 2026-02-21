using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        private By usernameInput = By.Id("user-name");
        private By passwordInput = By.Id("password");
        private By loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        public void Login(string username, string password)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(usernameInput)).SendKeys(username);
            _wait.Until(ExpectedConditions.ElementIsVisible(passwordInput)).SendKeys(password);
            _wait.Until(ExpectedConditions.ElementToBeClickable(loginButton)).Click();
        }
     }
}
