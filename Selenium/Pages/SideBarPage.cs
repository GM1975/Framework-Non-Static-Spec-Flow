using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium.Selenium;

namespace Selenium.Pages
{
    public class SideBarPage
    {
        public void CickTheButtonBlogPostsAdd()
        {
            IWebElement addNewBlogPostButton = Driver.Instance.FindElement(By.ClassName("add-new"));
            addNewBlogPostButton.Click();
        }
    }
}
