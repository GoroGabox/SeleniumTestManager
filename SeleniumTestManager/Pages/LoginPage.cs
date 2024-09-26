using OpenQA.Selenium;
using SeleniumTestManager.Locators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestManager.Pages
{
    public class LoginPage : BasePage
    {
        private By locator_usuario = LoginPageLocators.InputUsuario;
        private By locator_password = LoginPageLocators.InputPassword;
        private By locator_ingresar = LoginPageLocators.ButtonIngresar;
        public LoginPage(IWebDriver driver) : base(driver) { }
        IWebElement InputUsuario => driver.FindElement(locator_usuario);
        IWebElement InputPassword => driver.FindElement(locator_password);
        IWebElement BtnIngresar => driver.FindElement(locator_ingresar);

        public void Login(string username, string password)
        {
            InputUsuario.EnterText(username);
            InputPassword.EnterText(password);
            BtnIngresar.Click();
        }
        public bool IsTitleMatches(string text)
        {
            return driver.Title.Contains(text);
        }

        public bool ExisteInputUsuario()
        {
            return driver.FindElements(locator_usuario).Count > 0;
        }

        public bool ExisteInputPassword()
        {
            return driver.FindElements(locator_password).Count > 0;
        }

        public bool ExisteIngresarButton()
        {
            return driver.FindElements(locator_ingresar).Count > 0;
        }
    }
}
