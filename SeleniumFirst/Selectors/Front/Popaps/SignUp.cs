using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElquireWithSelenium.Selectors.Front.Popaps
{
    class SignUp
    {
        public static string TitleSignUp = "//*[@id='sidebar-signup']/div/div/p";

        //Buttons and links
        public static string XButton = "//*[@id='sidebar-signup']/span";
        public static string SignUpButton = "//*[@id='sidebar-signup']//div[3]/button";
        public static string TermsLink = "//*[@id='sidebar-signup']//div[2]/div/label/a";
        public static string SignInLink = "//*[@id='sidebar-signup']//p/a";

        public static string ChooseLanguage(int value)
        {
            var select = $"//*[@id='sidebar-signup']//ul/li[{value}]/a";
            return select;
        }

        //Labels
        public static string EnterEmailLabel = "//*[@id='sidebar-signup']/div/div/div/div[1]/label";
        public static string IAgreeLabel = "//*[@id='sidebar-signup']//div[2]//label";
        public static string HaveAccountLabel = "//*[@id='sidebar-signup']/div/div/div/p";
        public static string EmailExistOrFreeLabel = "//*[@id='sidebar-signup']//div[1]//span"; //Free email or This email already exists

        //Field
        public static string EnterEmailField = "//*[@id='sidebar-signup']//div[1]/div/input";

        //CheckBox
        public static string IAgreeCheckBox = "//*[@id='sidebar-signup']//div[2]//label";
    }
}
