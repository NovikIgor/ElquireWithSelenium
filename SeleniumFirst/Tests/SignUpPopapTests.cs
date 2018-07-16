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
    [Order(2)]
    class SignUpPopapTests
    {
        //Pre-tests settings
        IWebDriver driver = new ChromeDriver();

        string ElquireFrontURL = "https://test.elirtex.dev.htechsprt.com";
        string ElquireAdminURL = "http://94.245.111.205/htech-admin/withdraw";
        string LoginFront = "el504110"; // Chan_1
        string PasswordFront = "SPOKe";
        string LoginAdmin = "i.novik@benamix.solutions";
        string PasswordAdmin = "1991spokE!"; // 1991SPOKe!
        string Symbols300 = "Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text for test! Some text forSome te";

        [Test, Order(1)]
        public void CheckTitleName()
        {
            var TitleENGName = "SIGN UP";
            var TitleRUSName = "РЕГИСТРАЦИЯ";

            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            var engText = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.TitleSignUp)).Text;
            Assert.AreEqual(TitleENGName, engText);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.ChooseLanguage(2))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            var rusText = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.TitleSignUp)).Text;
            Assert.AreEqual(TitleRUSName, rusText);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.ChooseLanguage(3))).Click();
            Thread.Sleep(6000);
        }

        [Test, Order(2)]
        public void CheckXButtonFunction()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.XButton)).Click();
            Thread.Sleep(1000);
        }

        [Test, Order(3)]
        public void CheckAllLabels()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            Thread.Sleep(1000);
            var fieldLabel = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailLabel)).Text.Equals("Enter your email");
            Assert.AreEqual(true, fieldLabel);
            Thread.Sleep(1000);
            var linkLabel = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.IAgreeLabel)).Text.Remove(12);
            Assert.AreEqual("I agree with", linkLabel);
            Thread.Sleep(1000);
            var alreadyLabel = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.HaveAccountLabel)).Text.Remove(31);
            Assert.AreEqual("Do you already have an account?", alreadyLabel);
        }

        [Test, Order(4)]
        public void FillFieldEmailDifferentSymbols() 
        {
            var nums = "1234567890";

            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            Thread.Sleep(1000);
            for (int s = 0; s < 1; s++)
            {
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).SendKeys(nums);
                    Thread.Sleep(500);
                    string numbers = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).GetAttribute("value");
                    Assert.AreEqual(nums, numbers);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).Clear();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).SendKeys("AsDfGhJkLo");
                    Thread.Sleep(500);
                    string letters = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).GetAttribute("value");
                    Assert.AreEqual("AsDfGhJkLo", letters);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).Clear();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).SendKeys("12   &^%   AgD");
                    Thread.Sleep(500);
                    string symbols = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).GetAttribute("value");
                    Assert.AreEqual("12   &^%   AgD", symbols);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).Clear();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).SendKeys("!@#$%^&*()");
                    Thread.Sleep(500);
                    string symbols = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).GetAttribute("value");
                    Assert.AreEqual("!@#$%^&*()", symbols);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).Clear();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).SendKeys("2");
                    Thread.Sleep(500);
                    string oneNumber = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).GetAttribute("value");
                    Assert.AreEqual("2", oneNumber);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).Clear();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).SendKeys(Symbols300);
                    Thread.Sleep(500);
                    string manySymbols = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).GetAttribute("value");
                    Assert.AreEqual(Symbols300, manySymbols);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).Clear();
                }

            }
        }
        
        [Test, Order(5)]
        public void CheckActivationDeactivationOfCheckBox()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            Thread.Sleep(1000); 
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.IAgreeCheckBox)).Click(); 
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.IAgreeCheckBox)).Click();
        }

        [Test, Order(6)]
        public void CheckSuccessRegistration()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);

            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).SendKeys("username" + randomInt + "@gmail.com");
            Thread.Sleep(500);
            var free = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EmailExistOrFreeLabel)).Text.Equals("Email available");
            Assert.AreEqual(true, free);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.IAgreeCheckBox)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.SignUpButton)).Click();
            Thread.Sleep(7000);
            driver.FindElement(By.XPath(Selectors.Front.CabinetMainPage.ServerTime));
        }

        [Test, Order(7)]
        public void CheckSuccessLogOut()
        {
            driver.FindElement(By.XPath(Selectors.Front.CabinetMainPage.GamburgerMenuButton)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.CabinetMainPage.LogOutButton)).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton));
        }

        [Test, Order(8)]
        public void CheckEmailIsExist()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EnterEmailField)).SendKeys("igornovik1991@gmail.com");
            Thread.Sleep(2000);
            var notFree = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.EmailExistOrFreeLabel)).Text.Equals("This email already exists");
            Assert.AreEqual(true, notFree);
            Thread.Sleep(1000);
        }

        [Test, Order(9)]
        public void CheckTerms()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.TermsLink)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.TermPage.TitleTerms));
        }

        [Test, Order(10)]
        public void CheckSignIn()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.SignInLink)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.TitleSignIn));
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseSignUp_or_RestoreLink(1))).Click();
        }

        [Test, Order(11)]
        public void CheckRuEnEsLanguages()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignUpButton)).Click();
            Thread.Sleep(500);

            var rusLang = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.ChooseLanguage(2))).Text;
            Assert.AreEqual("RU", rusLang);
            var engLang = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.ChooseLanguage(3))).Text;
            Assert.AreEqual("EN", engLang);
            var espLang = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.ChooseLanguage(1))).Text;
            Assert.AreEqual("ES", espLang);
            CleanUp();
        }

        // HELPERS METHODS
        //[SetUp] //Mетод, который выполняeться каждый раз перед выполнением [Test]
        public void InitializeFront()
        {
            driver.Navigate().GoToUrl(this.ElquireFrontURL);
            Thread.Sleep(1000);
            //driver.Manage().Window.Maximize();
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
            Console.Read();
        }
    }
}
