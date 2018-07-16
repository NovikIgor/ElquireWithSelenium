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
    [Order(4)]
    class CreateDepositTests
    {
        //Pre-tests settings
        IWebDriver driver = new ChromeDriver();

        string ElquireFrontURL = "https://test.elirtex.dev.htechsprt.com";
        string ElquireAdminURL = "https://testadmin.elirtex.dev.htechsprt.com/htech-admin/withdraw";
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
            driver.FindElement(By.XPath(Selectors.Front.MainPage.InvestButton)).Click();
            Thread.Sleep(1000);
            //driver.Manage().Window.Maximize();
            //driver.Manage().Window.Position = new System.Drawing.Point(400, 200);
        }

        [Test, Order(1)]
        public void CheckTitleName()
        {
            var TitleENGName = "DEPOSIT CREATION";
            var TitleRUSName = "СОЗДАНИЕ ДЕПОЗИТА";

            var engText = driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.TitleCreateDeposit)).Text;
            Assert.AreEqual(TitleENGName, engText);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.LanguageButton)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.ChooseLanguage(2))).Click();
            Thread.Sleep(4000);
            var rusText = driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.TitleCreateDeposit)).Text;
            Assert.AreEqual(TitleRUSName, rusText);
            driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.LanguageButton)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.ChooseLanguage(3))).Click();
            Thread.Sleep(4000);
        }

        [Test, Order(2)]
        public void CheckAllLabels()
        {
            //FillAllfields();
            var email = driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.EnterEmailForAccountRegistrationLabel)).Text.Equals("Enter your email or phone number");
            Assert.AreEqual(true, email);
            Thread.Sleep(500);
            var pickCurrency = driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.PickCurrencyLabel)).Text.Equals("Pick currency");
            Assert.AreEqual(true, pickCurrency);
            Thread.Sleep(500);
            var alreadyRegistered = driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.IfYouAreRegisteredLabel)).Text.Remove(29);
            Assert.AreEqual("If you are already registered", alreadyRegistered);
            Thread.Sleep(500);
            var pickPlan = driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.PickPlanLabel)).Text.Equals("Select plan");
            Assert.AreEqual(true, pickPlan);
            Thread.Sleep(500);
            var depAmount = driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.PickDepositAmountLabel)).Text.Equals("Choose amount of the deposit");
            Assert.AreEqual(true, depAmount);
            Thread.Sleep(500);
            var dailyProfit = driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.DailyProfitORTotalReturnLabels(1))).Text.Equals("Daily profit:");
            Assert.AreEqual(true, dailyProfit);
            Thread.Sleep(500);
            var totalReturn = driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.DailyProfitORTotalReturnLabels(2))).Text.Equals("Total return:");
            Assert.AreEqual(true, totalReturn);
        }

        [Test, Order(3)]
        public void EnterSuccessEmail()
        {
            FillAllfields();
            IJavaScriptExecutor js = driver as IJavaScriptExecutor; // (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.CreateDepositButton(6))).Click();
            Thread.Sleep(6000);
            driver.FindElement(By.XPath(Selectors.Front.QRCodePage.QRCode));
            CleanUp();
        }






        // HELPERS METHODS
        public void FillAllfields()
        {
            Random randomGenerator = new Random();
            Thread.Sleep(500);
            int randomInt = randomGenerator.Next(1000);
            driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.EnterEmailField)).SendKeys("username" + randomInt + "@gmail.com");
            Thread.Sleep(5000);
            //driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.PickCurrencyButton)).Click();
            //Thread.Sleep(1000);
            //driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.PickCryptoButton)).Click();
            //Thread.Sleep(1000);
            //driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.ChooseLoginOrNo_ChooseCrypto(2, 4))).Click();
            //Thread.Sleep(1000);
            //driver.FindElement(By.XPath(Selectors.Front.CreateDepositPage.ChoosePlan(3, 1))).Click();
            //Thread.Sleep(1000);
        }

        //[TearDown] //Метод, который выполняеться каждый раз после выполнения [Test]
        public void CleanUp()
        {
            Thread.Sleep(1000);
            driver.Close();
            Console.WriteLine("Closed the browser");
        }

    }
}
