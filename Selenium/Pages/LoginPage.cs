using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium.Selenium;

namespace Selenium.Pages
{
    public class LoginPage
    {
        public void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
        }



        public void LoginAs(string userName, string password)
        {

            IWebElement userNameInput = Driver.Instance.FindElement(By.Id("user_login"));
            userNameInput.SendKeys(userName);

            IWebElement passwordInput = Driver.Instance.FindElement(By.Id("user_pass"));
            passwordInput.SendKeys(password);

            IWebElement logInButton = Driver.Instance.FindElement(By.Id("wp-submit"));
            logInButton.Click();


        }
    }
}
