using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TricentisProject.Support;

namespace TricentisProject
{
    public class UICommonSelenium : CommonSelenium
    {
        public static IWebDriver Driver { get; private set; }
        public static SeleniumSettings SeleniumSettings;
        public UICommonActions CommonActions { get;  set; }
        public static string url = "http://demowebshop.tricentis.com/";
        public static string username;
        public static string password;
        public static bool loginFlag = false; 

        public UICommonSelenium()
        {
            CommonActions = new UICommonActions();
        }

        public static void LanchBrowser(string browserName)
        {
            ChromeOptions options = new ChromeOptions();
            switch(browserName)
            {
                case "Chrome":
                   // options.AddArgument(UICommonActions.language);
                    Driver = new ChromeDriver();
                    Driver.Navigate().GoToUrl(url);
                    break;

                default: 
                    throw new WebDriverException($"Cannot process driver with name {browserName}");
            }
            Driver.Manage().Window.Size = new System.Drawing.Size(1800, 1200);
        }
    }
}
