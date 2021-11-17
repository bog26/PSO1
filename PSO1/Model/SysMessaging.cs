using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class SysMessaging
    {
        private static readonly string sender = "System";
        public static Message CreateSysMessage(string[] args)
        {
            //Message newMessage = new Message(args[3]); //IndexOutOfRangeException
            Message newMessage = new Message();
            newMessage.Sender = sender;
            newMessage.Receiver = args[0];
            newMessage.MessageTitle = args[1];
            newMessage.MessageBody = args[2];
            newMessage.MessageTime = DateTime.Now;
            //newMessage.MessageTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            //.ToString("MM/dd/yyyy hh:mm tt")
            return newMessage;
        }
        //public static string[] CreatePurchaseInfo(string buyerName, string transId, string cost, string transactionInfo)
        public static string[] CreatePurchaseInfo(string[] args)
        {
            
            string receiver = args[0];
            string transId = args[1];
            string cost = args[2];
            string transactionInfo = args[3];
            string titleInfo = $"Do not reply -Transaction Nr. {transId}";
            string msgIntro = @"Dear valued customer,
                                Thank you for your purchase. 
                                 You can find below a summary of your purchased goods."+"\n";
            string msgEnding = @"Best regards, 
                                    Store Administration";

            string message = msgIntro + transactionInfo + "\n" + "Total cost: " + cost + "\n" + msgEnding;

            string [] purchaseInfo = new string[] { receiver, titleInfo, message };

            return purchaseInfo;
        }
        public static string[] CreatePriceAlarmInfo(string[] args)
        {
            string[] priceAlarmInfo = new string[3];


            return priceAlarmInfo;
        }

    }
}
