using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium.Selenium;

namespace Selenium.Pages
{
    public class NewPostPage
    {
        public bool PostEditorDisplayed()
        {
            IWebElement paragraphButton = Driver.Instance.FindElement(By.Id("mceu_1-open"));
            if (paragraphButton.Displayed)
            {
                return true;
            }
            return false;
        }
    }
}
