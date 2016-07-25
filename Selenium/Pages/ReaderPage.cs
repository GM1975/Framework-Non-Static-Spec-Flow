using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium.Selenium;

namespace Selenium.Pages
{
    public class ReaderPage
    {
        public bool IsAt()
        {

            string url = Driver.Instance.Url.ToString();

            if (url == "https://wordpress.com/")
            {
                return true;
            }
            return false;

        }
    }
}
