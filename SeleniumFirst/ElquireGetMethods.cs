using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElquireWithSelenium
{
    class ElquireGetMethods
    {
        public static string GetText(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType == "Name")
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }

        public static string GetTextFromDDl(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementType == "Name")
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }


    }
}
