using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElquireWithSelenium.Selectors.Front.Popaps
{
    class SignIn
    {
        public static string TitleSignIn = "//*[@id='sidebar-signin']/div/div/p";

        //Buttons and links
        public static string XButton = "//*[@id='sidebar-signin']/span";
        public static string SignInButton = "//*[@id='sidebar-signin']//div[4]/button";
        public static string ShowSymbolsInPasswordFieldButton = "//*[@id='sidebar-signin']//div[3]/div/span";
        public static string GoogleNewWindowConfirmEmailButton = "//*[@id='identifierNext']/div[2]";
        public static string GoogleNewWindowConfirmPasswordButton = "//*[@id='passwordNext']/div[2]";

        public static string ChooseButton(int value)
        {
            var select = $"//*[@id='sidebar-signin']//div[1]/section/div[{value}]/button"; // 1 FaceBook. 2 Google
            return select;
        }

        public static string ChooseSignUp_or_RestoreLink(int value)
        {
            var select = $"//*[@id='sidebar-signin']//p[{value}]/a"; // 1 Sign Up. 2 Restore
            return select;
        }

        public static string ChooseLanguage(int value)
        {
            var select = $"//*[@id='sidebar-signin']/div/div/ul/li[{value}]/a";
            return select;
        }

        //Labels
        public static string OrElementLabel = "//*[@id='sidebar-signin']/div/div/div/div[1]//p";
        public static string ChooseLabelForFields(int value)
        {
            var select = $"//*[@id='sidebar-signin']//div[{value}]/label"; // 2 Enter your e-mail or login. 3 Enter password 
            return select;
        }

        public static string ChooseLabelForlinks(int value)
        {
            var select = $" //*[@id='sidebar-signin']/div/div/div/p[{value}]"; // 1 Don't have account. 2 Restore password 
            return select;
        }

        //Fields
        public static string EnterEmailOrLoginField = "//*[@id='sidebar-signin']//div[2]/input";
        public static string EnterPaswordField = "//*[@id='sidebar-signin']//div[3]/div/input";
        public static string FaceBookNewWindow = "//*[@id='u_0_0']";
        public static string GoogleNewWindowEmailField = "//*[@id='identifierId']";
        public static string GoogleNewWindowPasswordField = "//*[@id='password']/div[1]//div[1]/input";
    }
}
