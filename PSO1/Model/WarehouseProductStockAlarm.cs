using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class WarehouseProductStockAlarm: IAlarm
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        User User { get; set; }
        public int ProductId { get; set; }
        Product Product { get; set; }
        public string message { get; set; }
        public int MinAmount { get; set; }
        public void CreateMessage()
        {
            string productInfo = $"New Product stock alarm created for product with PID {ProductId}. ";
            string amountInfo = $"Minimum allowed stock: {MinAmount}";
            message = productInfo + amountInfo;
        }
    }
}
