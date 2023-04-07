using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricentisProject.PageObjectModel
{
    public class LoginPage : CommonPage
    {
        #region Locators
        string LoginButton = "xpath=//a[@class = 'ico-login' and text()= 'Log in']";
        string EmailTxt = "xpath=//input[@class = 'email' and @id= 'Email']";
        string PasswordTxt = "xpath=//input[@class = 'password' and @id= 'Password']";
        string LoginBtn = "xpath=//input[@value= 'Log in']";
        string LoggedUserId = "xpath=//a[@class = 'account' and text()='123NewUser123@gmail.com' ]";
        string ErrorMessage = "xpath=//li[text() = 'The credentials provided are incorrect']";
        #endregion

        public LoginPage NavigaeToApplication()
        {
            NavigateToApplication();
            return new LoginPage();
        }

        public LoginPage OnLoginPage()
        {
            WaitforVisibilityOfElement(LoginButton, 3);
            Click(LoginButton, 3);
            return new LoginPage();
        }
        public LoginPage EnterEmailId(string emailId)
        {
            if(!string.IsNullOrEmpty(emailId))
            {
                ClickAndEnterText(EmailTxt, emailId, 3);
            }
            return new LoginPage();
        }

        public LoginPage EnterPassword(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                ClickAndEnterText(PasswordTxt, password, 3);
            }
            return new LoginPage();
        }

        public LoginPage ClickLoginBtn()
        {
            Click(LoginBtn, 3);
            UICommonSelenium.loginFlag = true;
            return new LoginPage();
        }

        public string UserAccoundName()
        {
            return GetElementText(LoggedUserId);
        }

        public string GetErrorMessage()
        {
            try
            {
                UICommonSelenium.loginFlag = false;
                return GetElementText(ErrorMessage);
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    }
    

}
