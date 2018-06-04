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
    class SignInPopapTests
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
            var TitleENGName = "SIGN IN";
            var TitleRUSName = "ВОЙТИ";

            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            var engText = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.TitleSignIn)).Text;
            Assert.AreEqual(TitleENGName, engText);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseLanguage(1))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            var rusText = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.TitleSignIn)).Text;
            Assert.AreEqual(TitleRUSName, rusText);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseLanguage(2))).Click();
            Thread.Sleep(3000);
        }

        [Test, Order(2)]
        public void CheckXButtonFunction()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.XButton)).Click();
        }

        [Test, Order(3)]
        public void CheckFaceBookButtonFunction()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseButton(1))).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles.Last()).Close();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseButton(1)));
        }

        [Test, Order(4)]
        public void CheckGoogleButtonFunction()
        {
            string email = "test.benamix@gmail.com";
            string pass = "1991SPOKe";

            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseButton(2))).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.GoogleNewWindowEmailField)).SendKeys(email);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.GoogleNewWindowEmailField)).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.GoogleNewWindowPasswordField)).SendKeys(pass);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.GoogleNewWindowPasswordField)).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles.First());
            Thread.Sleep(6000);
            driver.FindElement(By.XPath(Selectors.Front.CabinetMainPage.ServerTime));
            LogOut();
        }

        [Test, Order(5)]
        public void CheckAllLabels()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            Thread.Sleep(500);
            var login = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseLabelForFields(2))).Text.Equals("Enter your e-mail or login");
            Assert.AreEqual(true, login);
            Thread.Sleep(500);
            var or = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.OrElementLabel)).Text.Equals("or");
            Assert.AreEqual(true, or);
        }

        [Test, Order(6)]
        public void FillFielEmailWithNumbers()
        {
            var nums = "1234567890";

            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            ElquireSetMethods.SignInPopapPajeObject(driver, Selectors.Front.Popaps.SignIn.EnterEmailOrLoginField, Selectors.Front.Popaps.SignIn.EnterPaswordField, nums, PasswordFront, Selectors.Front.Popaps.SignIn.SignInButton);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.SignInButton));
        }

        [Test, Order(7)]
        public void SignIn10TimesWithEmptyFields()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            Thread.Sleep(1000);
            for (int i = 0; i < 10; i++)
            {
                driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.SignInButton)).Click();
            }

        }

        [Test, Order(8)]
        public void FillFieldsDifferentSymbols()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            Thread.Sleep(1000);
            for (int s = 0; s < 1; s++)
            {
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterEmailOrLoginField)).SendKeys("1234567890");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterPaswordField)).SendKeys("1234567890");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.SignInButton)).Click();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterEmailOrLoginField)).SendKeys("AsDfGhJkLo");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterPaswordField)).SendKeys("AsDfGhJkLo");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.SignInButton)).Click();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterEmailOrLoginField)).SendKeys("12   &^%   AgD");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterPaswordField)).SendKeys("12   &^%   AgD");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.SignInButton)).Click();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterEmailOrLoginField)).SendKeys("!@#$%^&*()");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterPaswordField)).SendKeys("!@#$%^&*()");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.SignInButton)).Click();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterEmailOrLoginField)).SendKeys("2");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterPaswordField)).SendKeys("3");
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.SignInButton)).Click();
                }
                Thread.Sleep(1000);
                for (int i = 0; i < 1; i++)
                {
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterEmailOrLoginField)).SendKeys(Symbols300);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterPaswordField)).SendKeys(Symbols300);
                    driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.SignInButton)).Click();
                }
                driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.SignInButton));
            }
        }

        [Test, Order(9)]
        public void CheckSeePasswordButton()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterPaswordField)).SendKeys(PasswordFront);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ShowSymbolsInPasswordFieldButton)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.EnterPaswordField)).Equals(PasswordFront);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ShowSymbolsInPasswordFieldButton)).Click();
        }

        [Test, Order(10)]
        public void DontHaveAccoutnAndForgotPaswordLabels()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            Thread.Sleep(500);
            var dontHave = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseLabelForlinks(1))).Text.Remove(22);
            Assert.AreEqual("Don`t have an account?", dontHave);
            Thread.Sleep(500);
            var forgot = driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseLabelForlinks(2))).Text.Remove(21);
            Assert.AreEqual("Forgot your password?", forgot);
        }

        [Test, Order(11)]
        public void CheckSignUpClickLink()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseSignUp_or_RestoreLink(1))).Click();
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignUp.TitleSignUp));
        }

        [Test, Order(12)]
        public void CheckRestoreClickLink()
        {
            InitializeFront();
            driver.FindElement(By.XPath(Selectors.Front.MainPage.SignInButton)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.Popaps.SignIn.ChooseSignUp_or_RestoreLink(2))).Click();
            driver.FindElement(By.XPath(Selectors.Front.Popaps.RestorePassword.TitleRestorePassword));
        }

        [Test, Order(13)]
        public void SuccessAutorization()
        {
            InitializeFront();
            ElquireSetMethods.Click(driver, Selectors.Front.MainPage.SignInButton, null);
            ElquireSetMethods.SignInPopapPajeObject(driver, Selectors.Front.Popaps.SignIn.EnterEmailOrLoginField, Selectors.Front.Popaps.SignIn.EnterPaswordField, LoginFront, PasswordFront, Selectors.Front.Popaps.SignIn.SignInButton);
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(Selectors.Front.CabinetMainPage.ServerTime));
        }

        [Test, Order(14)]
        public void Cabinet()
        {
            driver.FindElement(By.XPath(Selectors.Front.CabinetMainPage.ServerTime));
            LogOut();
            CleanUp();
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
