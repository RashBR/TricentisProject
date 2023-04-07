using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricentisProject.PageObjectModel
{
    public class LogoutPage : CommonPage
    {
        #region Locators
        string LogoutBtn = "xpath=//a[@class = 'ico-logout' and text()= 'Log out']";
        #endregion

        public LogoutPage ClickLogoutBtnAndCheckLoggedOut()
        {
            Click(LogoutBtn, 5);
            UICommonSelenium.loginFlag = false;
           return new LogoutPage();
        }    
    }
}
