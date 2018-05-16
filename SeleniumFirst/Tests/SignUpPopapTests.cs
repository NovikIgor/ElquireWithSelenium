using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Interactions; //enter keys;

namespace ElquireWithSelenium.Tests
{
    class SignUpPopapTests
    {
        //Pre-tests settings
        IWebDriver driver = new ChromeDriver();

        string ElquireFrontURL = "http://auth-elquire.htechsprt.com";
        string ElquireAdminURL = "http://176.107.179.147:81/htech-admin";
        string LoginFront = "Chan_1";
        string PasswordFront = "SPOKe";
        string LoginAdmin = "i.novik@benamix.solutions";
        string PasswordAdmin = "1991spokE!";
        string Symbols300 = "Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text forSome te";

        [Test, Order(1)]
        public void CheckTitleName()
        {
            var TitleENGName = "Sign Up";
            var TitleRUSName = "Регистрация";

            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.TitleSignUp)).Equals(TitleENGName);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.ChooseLanguage(1))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.TitleSignUp)).Equals(TitleRUSName);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.ChooseLanguage(2))).Click();
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }











        // HELPERS METHODS
        //[SetUp] //Mетод, который выполняeться каждый раз перед выполнением [Test]
        public void InitializeFront()
        {
            driver.Navigate().GoToUrl(this.ElquireFrontURL);
            Thread.Sleep(1000);
            //driver.Manage().Window.Position = new System.Drawing.Point(400, 200);
            Console.WriteLine("Opened front URL");
        }

        public void LogOut()
        {
            driver.Navigate().GoToUrl(this.ElquireFrontURL);
            driver.FindElement(By.XPath(Selectors.Front.MainPage.GamburgerMenuButton)).Click();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.LogOutButton)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton));
        }

        //[TearDown] //Метод, который выполняеться каждый раз после выполнения [Test]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the browser");
        }

        // Is element presented on page
        public void d_RetornaResultados()
        {
            if ((driver.FindElement(By.Id("recommend_selenium_link")).Displayed).Equals(true))
            {
                Console.WriteLine("Is presente");
            }
            else
            {
                Console.WriteLine("Not present");
            }

        }
    }
}
