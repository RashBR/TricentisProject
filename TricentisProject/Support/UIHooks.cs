using System;
using TechTalk.SpecFlow;
using TricentisProject.PageObjectModel;

namespace TricentisProject.Support
{
    [Binding]
    public sealed class UIHooks : Hooks
    {
        

        public UIContext context { get;private set; }

        public UIHooks(UIContext uIContext)
        {
            context = uIContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            UICommonSelenium.LanchBrowser("Chrome");

        }

        [AfterScenario]
        [Scope(Tag = "logoutteardown")]
        public void LogOutTearDown()
        {
            CommonPage.LogoutPage.ClickLogoutBtnAndCheckLoggedOut();
            UICommonSelenium.loginFlag = false;

        }

        [AfterTestRun]
        public static void TeardownEyes()
        {
            Console.WriteLine("TearDown");
            if(UICommonSelenium.Driver != null)
            {
                UICommonSelenium.Driver.Quit();
            }
        }
    }
}
