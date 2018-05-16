using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElquireWithSelenium.Selectors.Front.Popaps
{
    class SignUp
    {
        //-----------------------------------------------------SIGN UP popap
        public static string TitleSignUp = "//*[@id='sidebar-signup']/div/div/p";

        //Buttons and links
        public static string XButton = "//*[@id='sidebar-signin']/span";
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
        public static string IAgreeLabel = "//*[@id='sidebar-signup']//div[2]/div/label";
        public static string HaveAccountLabel = "//*[@id='sidebar-signup']/div/div/div/p";

        //Field
        public static string EnterEmailField = "//*[@id='sidebar-signup']//div[1]/div/input";

        //CheckBox
        public static string IAgreeCheckBox = "//*[@id='agree']";

    }
}
