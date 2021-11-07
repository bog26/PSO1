using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        //public Client Client { get; set; }
        private Dictionary<Product, int> cartItems;
        public decimal ShoppingCartCalculation()
        {
            decimal cost = 0;
            foreach (KeyValuePair<Product, int> pair in this.cartItems)
            {
                cost += pair.Key.crtSellPrice * pair.Value;
            }
            return cost;
        }
        public void AddItemToCart(KeyValuePair<Product, int> Item)
        {
            this.cartItems.Add(Item.Key, Item.Value);
        }

    }
}
