using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class Status
    {
        private string crtStatus;
        private List<string> crtStatusList;
        private List<string> successfulTransactionStatuses = new List<string>()
        { "OrderRequested", "OrderAccepted", "ItemShipped", "ItemReceived", "OrderCompleted"};
        private List<string> returnTransactionStatuses = new List<string>()
        { "ReturnOrderRequested","ReturnOrderAccepted" ,"ReturnOrderStarted",
            "ItemReceived", "ReturnOrderCompleted"};
        private List<string> messageStatuses = new List<string>()
        { "sent", "received", "read"};
        public Status(Transaction tr)
        {
            this.crtStatusList = this.successfulTransactionStatuses;
            this.crtStatus = this.successfulTransactionStatuses[0];
        }
        
        public string CrtStatus
        { 
            get{ return this.crtStatus; }
            set {this.crtStatus = value; } 
        }
        public override string ToString()
        {
            return this.crtStatus;
        }
        public void ChangeTransactionStatus()
        {
            if(this.crtStatusList == this.successfulTransactionStatuses)
            {
                if(this.crtStatus == "OrderCompleted") 
                {
                    StartReturnProcess();
                }
                else 
                {
                    NextStatus();
                }
            }
            else 
            {
                if (this.crtStatus != "ReturnOrderCompleted") 
                {
                    NextStatus();
                }
            }
        }
        private void NextStatus()
        {
            int crtStatusIndex = this.crtStatusList.FindIndex(x => x == this.crtStatus);
            this.crtStatus = this.crtStatusList[crtStatusIndex++];
        }
        private void StartReturnProcess()
        {
            this.crtStatusList = this.returnTransactionStatuses;
            this.crtStatus = this.returnTransactionStatuses[0];
        }
    }
    
}
