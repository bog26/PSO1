using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    //class SQLConnection<T> : IDbConnection<T> where T: new()
    //class SQLConnection<T> where T : psDBContext, IDbContext<T>
    class SQLConnection<T> where T : psDBContext
    { 
        public T Context { get; set; }
        //public SQLConnection()
        //{
        //    Context = new T();
        //}
        
        public ISet<User> Users { get; set; }
        public ISet<User> Products { get; set; }
        public ISet<User> Transactions { get; set; }
        public ISet<User> Reviews { get; set; }
        public ISet<User> UserPersonalDatas { get; set; }
        public ISet<User> UserAddresses { get; set; }
        public ISet<User> ProductSubCategories { get; set; }
        public ISet<User> ProductCategories { get; set; }
        public ISet<User> Manufacturers { get; set; }
        public ISet<User> Messages { get; set; }
        public ISet<User> ShoppingCartItems { get; set; }
        public ISet<User> WishListItems { get; set; }
        public ISet<User> TransactionItems { get; set; }
        public ISet<User> ProductPictures { get; set; }
        public ISet<User> ProductSpecifications { get; set; }
        public ISet<User> UserItemReviews { get; set; }
        public ISet<User> WarehouseProductStockAlarms { get; set; }
    }
}
