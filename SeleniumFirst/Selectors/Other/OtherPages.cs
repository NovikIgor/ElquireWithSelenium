using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElquireWithSelenium.Selectors.Other
{
    class OtherPages
    {
        //-------------------------------------------------------GOOGLE GMAIL 
        //Buttons
        public static string GmailEnterButton = "/html/body/nav//a[2]";
        public static string ChooseAccountButton = "//*[@id='view_container']//div[2]//ul[1]/li[1]/div";
        public static string NextButton = "//*[@id='passwordNext']/div[2]";
        
        //Fields
        public static string EnterPaswordField = "//*[@id='password']/div[1]//div[1]/input";


    }
}
