using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    interface ICommunication<T> //T is a message
    {
        List<T> CommunicationItems { get; set; }
        void SendItem(string[] args);
        List<T> ReceiveItems();



    }
}
