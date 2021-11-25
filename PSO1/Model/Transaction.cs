using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class Transaction : IPSOEntity, ISearchUserId
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        
        //User User { get; set; }
        //public DateTime TransactionEnd { get; set; }
        public string TransactionStatus { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime TransactionTime { get; set; }
        public Transaction()
        {
            TransactionStatus = "Started";
            TotalCost = 0;
            TransactionTime = DateTime.Now;
        }



        //public Client Client { get; set; }
        //public int ShoppingCartId { get; set; }
        //public ShoppingCart ShoppingCart { get; set; }

    }
}
