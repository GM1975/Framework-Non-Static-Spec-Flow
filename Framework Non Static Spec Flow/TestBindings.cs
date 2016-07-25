using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public sealed class TestBindings
    {

        [BeforeTestRun]
        public static void TestInitialise()
        {

        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver.Initialise();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
        }
    }
}
