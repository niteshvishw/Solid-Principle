using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.BeforeISP
{
    interface iCommunication
   
    {
        void TextMessaging(string content);
        void WhatsappText(string content);
        void VideoCall(string content);
    }
    class IPhone6s:iCommunication
    {
        public void TextMessaging(string content)
        {
            //TextMassage Done
        }
        public void WhatsappText(string content)
        {
            //WhatsappText Done
        }
        public void VideoCall(string content)
        {
            //VideoCall Done
        }
    }
}
