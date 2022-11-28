using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.AfterISP
{
    interface iTextMessage
    {
        void TextMessaging(string content);
    }

    interface iWhatsupText
    {
        void WhatsappText(string content);
    }

    interface iVideocall
    {
        void VideoCall(string content);
    }

    class Iphone6s : iTextMessage, iWhatsupText, iVideocall
    {
         public void TextMessaging(string content)
        {
            //Text Message Done
        }
        public void WhatsappText(string content)
        {
            //WhatsappText Done
        }
        public void VideoCall(string content)
        {
            //VideoCall Done
        }

        class Nokia1100:iTextMessage
        {
            public void TextMessaging(string content)
            {
                //Text Message Done
            }

            public void WhatsappText(string content)
            {
                //Nokia 1100 does not have whatsapp feature
                // Problem this class can not implement this feature
            }
            public void VideoCall(string content)
            {
                //Problem this class can not implement this feature
            }
        }
    }
}
