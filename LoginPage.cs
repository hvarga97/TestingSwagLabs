using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSwagLabs
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "user-name")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "login-button")]
        public IWebElement btnLogin { get; set; }


        public EAPage_1Objects Login(string userName, string passWord)
        {
            txtUserName.EnterText(userName);
            txtPassword.EnterText(passWord);
            btnLogin.Submit();

            return new EAPage_1Objects();
        }
    }
}
