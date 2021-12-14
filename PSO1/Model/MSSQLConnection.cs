﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    //public class MSSQLConnection : IDbConnection<psDBContext>
    //public class MSSQLConnection<T> : IDbConnection<T> where T: psDBContext,IDbContext, new()
    public class MSSQLConnection<T> where T : psDBContext, new() //psDBContext, IDbContext, 
    //public class MSSQLConnection<T> where T : new() //ok
    {
        //private psDBContext context;

        /*
        public psDBContext Context{ get; set; }
        public MSSQLConnection()
        {
            Context = new psDBContext();
        }
        public psDBContext Connection()
        {
            return new psDBContext();
        }
        */
        public T Context { get; set; }
        public MSSQLConnection()
        {
            Context = new T();
        }
        public T Connection()
        {
            return new T();
        }

        /*
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
        */
    }
}
