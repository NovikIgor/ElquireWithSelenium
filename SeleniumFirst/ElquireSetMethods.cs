using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace ElquireWithSelenium
{
    class ElquireSetMethods
    {
        public static void SignInPopapPajeObject(IWebDriver driver, string email, string password, string value1, string value2,  string clickElement)
        {
            if (value1 != null && value2 != null)
            {
                driver.FindElement(By.XPath(email)).SendKeys(value1);
                driver.FindElement(By.XPath(password)).SendKeys(value2);
            }
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(clickElement)).Click();
            Thread.Sleep(1000);
        }

        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            driver.FindElement(By.XPath(element)).SendKeys(value);
            //if (elementType == "Id")
            //    driver.FindElement(By.Id(element)).SendKeys(value);
            //if (elementType == "Name")
            //    driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click into a button, select etc.
        public static void Click(IWebDriver driver, string element, string elementType)
        {
            driver.FindElement(By.XPath(element)).Click();
            //if (elementType == "Id")
            //    driver.FindElement(By.Id(element)).Click();
            //if (elementType == "Name")
            //    driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementType)
        {
            new SelectElement(driver.FindElement(By.XPath(element))).SelectByText(value);
            //if (elementType == "Id")
            //    new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            //if (elementType == "Name")
            //    new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
