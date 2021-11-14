using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PSO1.Model
{
    class psDBContext : DbContext
    {
        //public DbSet<Client> Clients { get; set; }
        //public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        //public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<UserPersonalData> UserPersonalDatas { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }

        //public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Message> Messages { get; set; }
        //public DbSet<WishList> WishLists { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<WishListItem> WishListItems { get; set; }
        public DbSet<TransactionItem> TransactionItems { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<ProductSpecification> ProductSpecifications { get; set; }
        public DbSet<UserItemReview> UserItemReviews { get; set; }

    }
}
