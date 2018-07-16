using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElquireWithSelenium.Selectors.Front.Popaps
{
    class RestorePassword
    {
        public static string TitleRestorePassword = "//*[@id='sidebar-restore']//p[1]";

        //Buttons and links
        public static string XButton = "//*[@id='sidebar-restore']/span";
        public static string SendLinkToEmailButton = "//*[@id='sidebar-restore']//div[2]/button";
        public static string SingInLink = "//*[@id='sidebar-restore']//p[2]/a";

        public static string ChooseLanguage(int value)
        {
            var select = $"//*[@id='sidebar-restore']//ul/li[{value}]/a";
            return select;
        }

        //Labels
        public static string EnterLoginLabel = "//*[@id='sidebar-restore']//div[1]/label";
        public static string RememberPasswordLabel = "//*[@id='sidebar-restore']//p[2]";

        //Field
        public static string EnterEmailField = "//*[@id='sidebar-restore']//div[1]/input";
    }
}