using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    class Warehouse
    {
        private Dictionary<Product, int> productsOnStock;
        public Warehouse()
        {

        }
        public Dictionary<Product, int> ProductsOnStock { get; set; }
        public void SupplyWarehouse(Product Product, int nrOfProducts)
        {
            ProductsOnStock[Product] += nrOfProducts;
        }
        public void shipFromWarehouse(Product Product, int nrOfProducts)
        {
            ProductsOnStock[Product] += nrOfProducts;
        }
        public void addNewProductToWarehouse(Product Product, int nrOfProducts)
        {
            if(!ProductsOnStock.Keys.Contains(Product))
            {
                ProductsOnStock.Add(Product, nrOfProducts);
            }
            
        }

    }
}
