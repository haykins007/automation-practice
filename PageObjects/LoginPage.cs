using OpenQA.Selenium;
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

        private By usernameInput = By.Id("user-name");
        private By passwordInput = By.Id("password");
        private By loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Login(string username, string password)
        {
            _driver.FindElement(usernameInput).SendKeys(username);
            _driver.FindElement(passwordInput).SendKeys(password);
            _driver.FindElement(loginButton).Click();
        }
     }
}
