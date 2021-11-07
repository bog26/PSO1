using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class TransactionItem
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal Cost { get; set; }
        public DateTime TransactionTime { get; set; }

    }
}
