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
    class RestorePaswordPopapTests
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

        [SetUp]
        public void InitializeFront()
        {
            driver.Navigate().GoToUrl(this.ElquireFrontURL);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseSignUp_or_RestoreLink(2))).Click();
            Thread.Sleep(1000);
            //driver.Manage().Window.Position = new System.Drawing.Point(400, 200);
            Console.WriteLine("Opened front URL");
        }

        /// <summary>
        /// Not working !
        /// </summary>
        [Test, Order(1)]
        public void CheckTitleName()
        {
            var TitleENGName = "RESTORE PASSWORD";
            var TitleRUSName = "ВОССТАНОВИТЬ ПАРОЛЬ";

            var engText = driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.TitleRestorePassword)).Text;
            Assert.AreEqual(TitleENGName, engText);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseLanguage(1))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseSignUp_or_RestoreLink(2))).Click();
            var rusText = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.TitleSignIn)).Text;
            Assert.AreEqual(TitleRUSName, rusText);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseLanguage(2))).Click();
            Thread.Sleep(3000);
        }

        [Test, Order(2)]
        public void CheckXButtonFunction()
        {
            driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.XButton)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
        }

        [Test, Order(3)]
        public void CheckAllLabels()
        {
            var login = driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterLoginLabel)).Text.Equals("Enter your login or e-mail");
            Assert.AreEqual(true, login);
            Thread.Sleep(500);
            var remPass = driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.RememberPasswordLabel)).Text.Remove(30);
            Assert.AreEqual("I'm remember password! Back to", remPass);
        }

        [Test, Order(4)]
        public void FillFieldDifferentSymbols()
        {
            for (int s = 0; s < 1; s++)
            {
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterEmailField)).SendKeys("1234567890");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.SendLinkToEmailButton)).Click();
                    Thread.Sleep(500);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterEmailField)).Clear();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterEmailField)).SendKeys("AsDfGhJkLo");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.SendLinkToEmailButton)).Click();
                    Thread.Sleep(500);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterEmailField)).Clear();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterEmailField)).SendKeys("12   &^%   AgD");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.SendLinkToEmailButton)).Click();
                    Thread.Sleep(500);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterEmailField)).Clear();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterEmailField)).SendKeys("!@#$%^&*()");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.SendLinkToEmailButton)).Click();
                    Thread.Sleep(500);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterEmailField)).Clear();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterEmailField)).SendKeys(Symbols300);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.SendLinkToEmailButton)).Click();
                    Thread.Sleep(500);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterEmailField)).Clear();
                }
            }
        }

        [Test, Order(5)]
        public void CheckSuccessSendEmail()
        {
            driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.EnterEmailField)).SendKeys("Chan_1");
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.SendLinkToEmailButton)).Click();



            var free = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EmailExistOrFreeLabel)).Text.Equals("Free email");
            Assert.AreEqual(true, free);

        }




















        // HELPERS METHODS
        //[SetUp] //Mетод, который выполняeться каждый раз перед выполнением [Test]
        public void CheckGmailLetter()
        {
            string gmail = "https://www.google.com/intl/uk/gmail/about/";

            driver.Navigate().GoToUrl(gmail);
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(Selectors.Other.OtherPages.GmailEnterButton)).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(Selectors.Other.OtherPages.ChooseAccountButton)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(Selectors.Other.OtherPages.EnterPaswordField)).SendKeys("1991SPOKe");
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Other.OtherPages.NextButton)).Click();
            Thread.Sleep(10000);





            var alreadyLabel = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.HaveAccountLabel)).Text.Remove(24);
            Assert.AreEqual("Already have an account?", alreadyLabel);
            //You need reset password!


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
