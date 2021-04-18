using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSwagLabs
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertyCollection.driver = new ChromeDriver();
            PropertyCollection.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Test] //test 01
        public void Test_01()
        {
            LoginPage pageLogin = new LoginPage();
            pageLogin.Login("standard_user", "secret_sauce");
        }

        [Test]
        public void Test_02()
        {
            LoginPage pageLogin = new LoginPage();
            EAPage_1Objects pageEA = pageLogin.Login("standard_user", "secret_sauce");
            pageEA.DoTheShopping();
        }

        [Test]
        public void Test_03()
        {
            LoginPage pageLogin = new LoginPage();
            EAPage_1Objects pageEA = pageLogin.Login("standard_user", "secret_sauce");
            pageEA.DoTheShopping();
            pageEA.RemoveItemsFromCart();
        }

        [Test]
        public void Test_04()
        {
            LoginPage pageLogin = new LoginPage();
            EAPage_1Objects pageEA = pageLogin.Login("standard_user", "secret_sauce");
            pageEA.OpenCart();
        }

        [TearDown]                                                     
        public void CleanUp()
        {
            PropertyCollection.driver.Close();
        }
    }
}
