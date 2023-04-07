using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JavasScriptExecutor = OpenQA.Selenium.IJavaScriptExecutor;
using Action = OpenQA.Selenium.Interactions.Actions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TricentisProject
{
    public class UICommonActions
    {
        private readonly IWebDriver _driver = UICommonSelenium.Driver;

        #region Global value for wait
        public static int microPause => UICommonSelenium.SeleniumSettings.microtimeout.Value;

        #endregion

        #region other hlobal value 
        //public static string language => UICommonSelenium.SeleniumSettings.lan

        #endregion

        public enum ClickType
        {
            Click,
            JSClick,
            BrowserBasedClick
        }

        public string GetElementText(string locator, int timeout=0)
        {
            WaitforVisibilityOfElement(locator, timeout);
            try
            {
               // return _driver.FindElement(By.XPath(locator)).Text;
                return FindElement(ByLocator(locator)).Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public IList<IWebElement> GetElements(string locator, int timeout = 0)
        {
            if (timeout != 0)
                WaitforVisibilityOfElement(locator, timeout);
            IList<IWebElement> elements = _driver.FindElements(ByLocator(locator));
            return elements;
        }

        public List<string>  GetElementListTexts(string locator, int timeout = 0)
        {
            WaitforVisibilityOfElement(locator, 3);
            IList<IWebElement> iconsElements = new List<IWebElement>();
            iconsElements = GetElements(locator, 3);
            List<string> iconsNameTexts = new List<string>();
            for (int i =0; i < iconsElements.Count; i++)
            {
                iconsNameTexts.Add(iconsElements[i].GetAttribute("innerText"));
            }
            return iconsNameTexts;


        }

        public By ByLocator(string locator)
        {
            var prefix = locator.Substring(0, locator.IndexOf('='));
            var suffix = locator.Substring(locator.IndexOf('=')+1);

            switch(prefix)
            {
                case "xpath":
                    return By.XPath(suffix);
                case "css":
                    return By.CssSelector(suffix);
                case "link":
                    return By.LinkText(suffix);
                case "partLink":
                    return By.PartialLinkText(suffix);
                case "name":
                    return By.Name(suffix);
                case "tag":
                    return By.TagName(suffix);
                case "id":
                    return By.Id(suffix);
                case "class":
                    return By.ClassName(suffix);
                default:
                    return By.XPath(suffix);
            }
        }

        public IWebElement FindElement(By by)
        {
            var elem = _driver.FindElement(by);
            return elem;
        }

        public IWebElement GetElement(string locator, int timeout)
        {
            WaitforVisibilityOfElement(locator, timeout);
            return FindElement(ByLocator(locator));
        }

        public bool WaitforVisibilityOfElement(string locator, int timeout)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
            try
            {
                //ErrorPopUp();
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ByLocator(locator)));
                return true;
            }
            catch(Exception)
            
            {
                return false;
            }
        }

        public void NavigateToApplication() => _driver.Navigate().GoToUrl(UICommonSelenium.url);

        public void Click (string locator, int timeout = 0, ClickType clickType = ClickType.Click)
        {
            WaitforVisibilityOfElement(locator, timeout);
            switch(clickType)
            {
                case ClickType.Click:
                    FindElement(ByLocator(locator)).Click();
                    break;
            }
        }

        public void ClickAndEnterText(string locator, string value, int timeout = 0)
        {
            if(timeout != 0)
            {
                WaitforVisibilityOfElement(locator,timeout);
            }
            var element = FindElement(ByLocator(locator));
            var action = new Action(_driver);
            action.MoveToElement(element);
            action.Click();
            action.SendKeys(value);
            action.Build().Perform();
        }

    }
}
