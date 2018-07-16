using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElquireWithSelenium.Selectors.Front
{
    class MainPage
    {
        //Buttons
        public static string GamburgerMenuButton = "//*[@id='header']/ul/li[4]/a";
        public static string SignInButton = "//*[@id='header']/ul/li[3]/span/a[2]";
        public static string SignUpButton = "//*[@id='header']/ul/li[3]/span/a[1]";
        public static string ElquireLogoButton = "//*[@id='header']/ul/li[1]/a";
        public static string LogOutButton = "//*[@id='site']//div[1]//ul[2]/div/span/a";
        public static string ChooseButton(int value)
        {
            var select = $"//*[@id='header']/ul/li[3]/a[{value}]"; // 1 Main, 2 FAQ, 3 News, 4 Contacts
            return select;
        }
        public static string InvestButton = "//*[@id='section0']//div[2]//div/p[4]/button";



    }
}
