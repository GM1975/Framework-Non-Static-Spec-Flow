using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium.Selenium;

namespace Selenium.Pages
{
    public class TopBarPage
    {
        public void ClickMySite()
        {
            IWebElement mySiteButton = Driver.Instance.FindElement(By.ClassName("masterbar__item-content"));
            mySiteButton.Click();
        }
    }
}
