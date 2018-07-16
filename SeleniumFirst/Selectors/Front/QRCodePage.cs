using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElquireWithSelenium.Selectors.Front
{
    class QRCodePage
    {
        public static string QRCode = "//*[@id='site']//section/div[8]//section//div[3]/div[1]/img";
        public static string QRCodeTitle = "//*[@id='site']//section/div[8]//section/div/div/p";
        public static string TextUnderTitle = "//*[@id='site']//div[8]/div/section/div/div/div[1]/p";

        //Labels
        public static string TimeToPaymentLabel  = "//*[@id='site']//div[8]/div/section/div/div/div[2]/div";
        public static string TransferAmountLabel = "//*[@id='site']//div[8]//div[3]/div[2]/div[1]/div[1]/p";
        public static string PaymentAddressLabel = "//*[@id='site']//div[8]//div[3]/div[2]/div[2]/div[1]/p";
        public static string PayOnlyOnceLabel    = "//*[@id='site']//div[8]//div[3]/div[2]/div[3]/p";
    }
}
