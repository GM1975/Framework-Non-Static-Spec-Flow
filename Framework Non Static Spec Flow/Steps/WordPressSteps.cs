using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.Pages;
using Selenium.Selenium;
using TechTalk.SpecFlow;

namespace Framework_Non_Static_Spec_Flow.Steps
{
    [Binding]
    public sealed class WordPress
    {

        [Given(@"a browser opened at WordPress login page")]
        public void GivenABrowserOpenedAtWordPressLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.GoTo();
        }

        [When(@"WordPress is logged in as '(.*)' with password '(.*)'")]
        public void WhenWordPressIsLoggedInAsWithPassword(string userName, string password)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.LoginAs(userName, password);
        }

        [Then(@"The WordPress homepage is displayed")]
        public void ThenTheWordPressHomepageIsDisplayed()
        {
            ReaderPage readerPage = new ReaderPage();
            Assert.IsTrue(readerPage.IsAt());
        }

        [When(@"I click the button My Site")]
        public void WhenIClickTheButtonMySite()
        {
            TopBarPage topBarPage = new TopBarPage();
            topBarPage.ClickMySite();
        }

        [When(@"I click the button Blog Posts Add")]
        public void WhenIClickTheButtonBlogPostsAdd()
        {
            SideBarPage sideBarPage = new SideBarPage();
            sideBarPage.CickTheButtonBlogPostsAdd();
        }

        [Then(@"the new post editor is displayed")]
        public void ThenTheNewPostEditorIsDisplayed()
        {
            NewPostPage newPostPage = new NewPostPage();
            newPostPage.PostEditorDisplayed();
        }




    }
}
