using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    //class Messaging<IUser, Message>
    public class Messaging 
    {
        //public static Message CreateMessage(string sender, string receiver,string title, string body)
        public static Message CreateMessage(string[] args)
        {
            Message newMessage = new Message(args[4]);
            newMessage.Sender = args[0];
            newMessage.Receiver = args[1];
            newMessage.MessageTitle = args[2];
            newMessage.MessageBody = args[3];
            newMessage.MessageTime = DateTime.Now;
            //newMessage.MessageTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            //.ToString("MM/dd/yyyy hh:mm tt")
            return newMessage;
        }
    }
}
