using OpenQA.Selenium;
using SeleniumTestManager.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestManager.Pages
{
    public class LoginPageExcel : BasePage
    {
        private Dictionary<string, By> _locators;

        public LoginPageExcel(IWebDriver driver, string locatorType) : base(driver)
        {
            _locators = LoginPageLocatorsExcel.GetLocators("Locators.xlsx","LoginPage",locatorType);
        }

        IWebElement InputUsuario => driver.FindElement(_locators["InputUsuario"]);
        IWebElement InputPassword => driver.FindElement(_locators["InputPassword"]);
        IWebElement BtnIngresar => driver.FindElement(_locators["ButtonIngresar"]);

        public void Login(string username, string password)
        {
            InputUsuario.EnterText(username);
            InputPassword.EnterText(password);
            BtnIngresar.Click();
        }
    }
}
