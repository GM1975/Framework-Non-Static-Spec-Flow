using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Selenium.Selenium
{
    public static class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {

            get { return ConfigurationManager.AppSettings["EnvUrl"]; }

        }

        public static void Initialise()
        {

           Instance = new ChromeDriver();
        }

        public static void DriverNavigateTo()
        {

            Instance.Navigate().GoToUrl("http://cmhtest-cnotes4.dev.local/carenotesvm/");
        }

        public static void Close()

        {
            Instance.Quit();
        }
    }

}
