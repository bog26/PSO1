using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    //public interface IDbConnection<T>
    public interface IDbConnection<T> 
    {
        T Context { get; set; }
        T Connection();
        ISet<User> Users { get; set; }
        ISet<User> Products { get; set; }
        ISet<User> Transactions { get; set; }
        ISet<User> Reviews { get; set; }
        ISet<User> UserPersonalDatas { get; set; }
        ISet<User> UserAddresses { get; set; }
        ISet<User> ProductSubCategories { get; set; }
        ISet<User> ProductCategories { get; set; }
        ISet<User> Manufacturers { get; set; }
        ISet<User> Messages { get; set; }
        ISet<User> ShoppingCartItems { get; set; }
        ISet<User> WishListItems { get; set; }
        ISet<User> TransactionItems { get; set; }
        ISet<User> ProductPictures { get; set; }
        ISet<User> ProductSpecifications { get; set; }
        ISet<User> UserItemReviews { get; set; }
        ISet<User> WarehouseProductStockAlarms { get; set; }

    }
}
