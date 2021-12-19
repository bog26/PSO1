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

        DbSet<User> Users { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Transaction> Transactions { get; set; }
        DbSet<Review> Reviews { get; set; }
        DbSet<UserPersonalData> UserPersonalDatas { get; set; }
        DbSet<UserAddress> UserAddresses { get; set; }
        DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        DbSet<ProductCategory> ProductCategories { get; set; }
        DbSet<Manufacturer> Manufacturers { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        DbSet<WishListItem> WishListItems { get; set; }
        DbSet<TransactionItem> TransactionItems { get; set; }
        DbSet<ProductPicture> ProductPictures { get; set; }
        DbSet<ProductSpecification> ProductSpecifications { get; set; }
        DbSet<UserItemReview> UserItemReviews { get; set; }
        DbSet<WarehouseProductStockAlarm> WarehouseProductStockAlarms { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync();

    }
}
