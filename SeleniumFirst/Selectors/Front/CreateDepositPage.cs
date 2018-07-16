using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElquireWithSelenium.Selectors.Front
{
    class CreateDepositPage
    {
        public static string TitleCreateDeposit = "//*[@id='site']//div[8]/div[1]/div/div[1]";
        public static string ServerTime = "//*[@id='site']//section/div[8]/header//ul/li[4]//span";
        public static string Logo = "//*[@id='site']//section/div[8]/header//ul/li[1]/a";

        //Buttons
        public static string LanguageButton = "//*[@id='site']//section/div[8]/header/div/div/div/ul/li[2]/div";
        public static string ChooseLanguage(int value)
        {
            var select = $"//*[@id='site']//section/div[8]/header//ul/li[2]//ul/li[{value}]";
            return select;
        }
        public static string LogInButton = "//*[@id='ajax-create-deposit']/div[3]/p/a";
        public static string CreateDepositButton(int value)
        {
            var select = $"//*[@id='site']//section/div[8]/div[1]//div[2]/div[1]/div[{value}]/button"; // 5 log in, 6 not log in
            return select;
        }

        public static string ChooseBackButton(int value)
        {
            var select = $"//*[@id='site']//section/div[8]/div[1]//div[2]/div[1]/div[{value}]/div[2]/button";
            return select;
        }
        public static string PickCurrencyButton = "//*[@id='site']//section/div[8]/div[1]//div[2]/div[1]/div[2]/div[3]/button";
        public static string PickCryptoButton = "//*[@id='site']//section/div[8]/div[1]//div[2]/div[1]/div[2]/div[3]//ul/li";
        //value1: 1 log in, 2 not log in. Value2: choose crypto
        public static string ChooseLoginOrNo_ChooseCrypto(int value1, int value2)
        {
            var select = $"//*[@id='site']/div/div/section/div[8]/div[1]/div/div[2]/div[1]/div[{value1}]/div[{value2}]/div/div"; 
            return select;
        }
        //value1: 1 log in, 2 not log in. Value2: choose wallet or balans
        public static string ChooseWalletOrBalance(int value1, int value2)
        {
            var select = $"//*[@id='site']//section/div[8]/div[1]//div[2]/div[1]/div[{value1}]/div[8]/div[{value2}]/label";
            return select;
        }
        //value1: 2 log in, 3 not log in. Value2: choose wallet or balans
        public static string ChoosePlan(int value1, int value2)
        {
            var select = $"//*[@id='site']//section/div[8]/div[1]/div/div[2]/div[1]/div[{value1}]/div[3]/div[{value2}]/div[2]/div[2]/div";
            return select;
        }
        //value1: 3 log in, 4 not log in. Value2: choose amount of balans
        public static string ChooseAmountDeposit(int value1, int value2)
        {
            var select = $"//*[@id='site']//section/div[8]/div[1]//div[2]/div[1]/div[{value1}]/div[3]/div[2]/div[1]/div[{value2}]/p";
            return select;
        }

        //Fields
        public static string EnterEmailField = "//*[@id='ajax-create-deposit']/div[3]//input";
        public static string PickDepositAmountField = "//*[@id='site']//section/div[8]/div[1]//div[2]/div[1]/div[4]/div[3]/div[1]//input";

        //Labels
        public static string EnterEmailForAccountRegistrationLabel = "//*[@id='ajax-create-deposit']/div[2]/div[2]";
        public static string IfYouAreRegisteredLabel = "//*[@id='ajax-create-deposit']/div[3]/p";
        public static string EmailMustBeFilledLabel = "//*[@id='ajax-create-deposit']/div[3]/div/p";
        public static string PickCurrencyLabel = "//*[@id='site']/div/div/section/div[8]/div[1]//div[2]/div[1]/div[2]/div[2]/div[2]";
        public static string PickPlanLabel = "//*[@id='site']//section/div[8]/div[1]/div/div[2]/div[1]/div[3]/div[2]/div[2]";
        public static string PickDepositAmountLabel = "//*[@id='site']//section/div[8]/div[1]/div/div[2]/div[1]/div[4]/div[2]/div[2]";
        public static string DailyProfitORTotalReturnLabels(int value)
        {
            var select = $"//*[@id='site']//section/div[8]/div[1]//div[2]/div[1]/div[5]/div[{value}]/span[1]";
            return select;
        }
        public static string NumbersOfBlocks(int value)
        {
            var select = $"//*[@id='site']//section/div[8]/div[1]//div[2]/div[1]/div[{value}]/div[2]/div[1]";
            return select;
        }
       
        //Calculator
        //public static string TitleCreateDeposit = "";
        //public static string TitleCreateDeposit = "";
    }
}
