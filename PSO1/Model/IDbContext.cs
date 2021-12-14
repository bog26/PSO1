using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public interface IDbContext :IDisposable
    {
        //DbSet<TEntity> Set<TEntity>() where TEntity : class;
        
        ISet<User> Users { get; set; }
        ISet<Product> Products { get; set; }
        ISet<Transaction> Transactions { get; set; }
        ISet<Review> Reviews { get; set; }
        ISet<UserPersonalData> UserPersonalDatas { get; set; }
        ISet<UserAddress> UserAddresses { get; set; }
        ISet<ProductSubCategory> ProductSubCategories { get; set; }
        ISet<ProductCategory> ProductCategories { get; set; }
        ISet<Manufacturer> Manufacturers { get; set; }
        ISet<Message> Messages { get; set; }
        ISet<ShoppingCartItem> ShoppingCartItems { get; set; }
        ISet<WishListItem> WishListItems { get; set; }
        ISet<TransactionItem> TransactionItems { get; set; }
        ISet<ProductPicture> ProductPictures { get; set; }
        ISet<ProductSpecification> ProductSpecifications { get; set; }
        ISet<UserItemReview> UserItemReviews { get; set; }
        ISet<WarehouseProductStockAlarm> WarehouseProductStockAlarms { get; set; }

    }
}
