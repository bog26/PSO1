using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class Message
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }

        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public DateTime MessageTime { get; set; }

        //public string MessageStatus { get; set; }
        public string MessageSenderStatus { get; set; }
        public string MessageReceiverStatus { get; set; }
        public bool IsEncrypted { get; set; }
        public Message()
        {
            //MessageStatus = "sent";
            MessageSenderStatus = "sent";
            MessageReceiverStatus = "unread";
            IsEncrypted = false;
        }
        public Message(string encryption)
        {
            //MessageStatus = "sent";
            MessageSenderStatus = "sent";
            MessageReceiverStatus = "unread";
            if (encryption == "true")
            {
                IsEncrypted = true;
            }
            else 
            {
                IsEncrypted = false;
            }
        }
        public void ReadMessage()
        {
            //MessageStatus = "read";
            MessageReceiverStatus = "read";
        }
        public void DeleteMessage()
        {
            //MessageStatus = "deleted";
        }
        public void DeleteSenderMessage()
        {
            MessageSenderStatus = "deleted";
        }
        public void DeleteReceiverMessage()
        {
            MessageReceiverStatus = "deleted"; 
        }

        public void SpamMessage()
        {
            //MessageStatus = "spam";
            MessageReceiverStatus = "spam";
        }
        /*
        public void SpamReceiverMessage()
        {
            MessageReceiverStatus = "spam";
        }
        */

        /*
        public void MessageSend(string title, string body)
        {

        }
        public string GetMessage()
        {
            string newMessage = "";

            return newMessage;
        }
        */

    }
}
