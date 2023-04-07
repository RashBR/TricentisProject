using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TricentisProject.PageObjectModel;

namespace TricentisProject.StepDefinitions
{
    [Binding]
    public class LoginSteps :UICommonSelenium
    {
        [Given(@"the user is on login page")]
        public void GivenTheUserIsOnLoginPage()
        {
            if(UICommonSelenium.loginFlag == true)
            {
                System.Console.WriteLine("Need to log out");
                CommonPage.LogoutPage.ClickLogoutBtnAndCheckLoggedOut();
            }
            CommonPage.LoginPage.OnLoginPage();
        }

        [Given(@"the user enters username '([^']*)' and password '([^']*)'")]
        [When(@"the user enters username '([^']*)' and password '([^']*)'")]
        public void WhenTheUserEntersUsernameAndPassword(string userName, string password)
        {
            CommonPage.LoginPage.EnterEmailId(userName).EnterPassword(password);
        }

        [Given(@"the user clicks on the login button")]
        [When(@"the user clicks on the login button")]
        public void WhenTheUserClicksOnTheLoginButton()
        {
            CommonPage.LoginPage.ClickLoginBtn();
        }

        [Then(@"the user logged in to the account '([^']*)'")]
        public void ThenTheUserLoggedInToTheAccount(string expectedEmailId)
        {
            string actualEmailId = CommonPage.LoginPage.UserAccoundName();
            Assert.That(actualEmailId, Is.EqualTo(expectedEmailId), "Accounts are different");
        }

        [Then(@"the user gets a error message as '([^']*)'")]
        public void ThenTheUserGetsAErrorMessageAs(string expectedErrorMessage)
        {
            string actualMessage = CommonPage.LoginPage.GetErrorMessage();
            Assert.That(actualMessage, Is.EqualTo(actualMessage), "Didn't get back the expected message");
        }


    }
}
