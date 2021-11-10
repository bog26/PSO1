using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO1.Model
{
    public class InternalDBQueries
    {

        public static bool CheckForExistingUser(string userName)
        {
            bool exisitingUser = false;
            var psContext = new psDBContext();

            var queryUsers = psContext.Users.Where(x => x.UserName == userName).ToList();
            if (queryUsers.Count !=0)
            {
                exisitingUser = true;
            }

            return exisitingUser;
        }
        public static int GetUserPersonalDataId(string userName)
        {
            var psContext = new psDBContext();
            int UserPersonalDataId = psContext.UserPersonalDatas.First(x => x.UserName == userName).Id; 
            return UserPersonalDataId;
        }
        public static int GetUserAddressId(string userName)
        {
            var psContext = new psDBContext();
            int UserAddressId = psContext.UserAddresses.First(x => x.UserName == userName).Id;
            return UserAddressId;
        }
        public static bool CheckForCorrectPassword(string loggedUser, string password)
        {
            var psContext = new psDBContext();
            bool correctPassword = false;

            var crtUser = psContext.Users.First(x => x.UserName == loggedUser);
            if (crtUser.Password == password)
            {
                correctPassword = true;
            }

            return correctPassword;
        }

        public static string GetPassword(string loggedUser)
        {
            var psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == loggedUser);
            return crtUser.Password;
        }


        public static bool CheckForAdminRights(string userName)
        {
            var psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == userName);
            bool isAdmin = crtUser.isAdmin;
            return isAdmin;
        }

        public static bool CheckForExistingAdmin()
        {
            var psContext = new psDBContext();
            bool alreadyExistingAdmin = false;
            var queryAdmins = psContext.Users.Where(x => x.isAdmin == true).ToList();
            if(queryAdmins.Count!=0)
            {
                alreadyExistingAdmin = true;
            }
            return alreadyExistingAdmin;
        }

        public static int GetWishListSize(string userName)
        {
            var psContext = new psDBContext();
            int crtUserId = psContext.Users.First(x => x.UserName == userName).Id;
            int wishListSize = psContext.WishListItems.Where(x => x.UserId == crtUserId).ToList().Count;
            return wishListSize;
        }

            public static bool IsProductInCart(string user, int PID)
        {
            bool productinCart = false;
            var psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            var item = psContext.ShoppingCartItems.Where(x => (x.ProductId == PID) && (x.UserId == crtUser.Id)).ToList();

            if (item.Count > 0)
            {
                productinCart = true;
            }
            return productinCart;
        }

        public static int GetMaxAmount(int PID)
        {
            int amount;
            var psContext = new psDBContext();
            Product productQuery = psContext.Products.First(x => x.Id == PID);
            amount = productQuery.Stock;
            return amount;
        }
        public static int GetNrOfTransItems(string user, int transId)
        {
            var psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            int transItemsNr = psContext.TransactionItems.Where(x => (x.UserId == crtUser.Id)
                                                                  && (x.TransactionId == transId)).ToList().Count;
            return transItemsNr;
        }
        public static string GetTransactionItemName(string user, int transId, int itemIndex)
        {
            var psContext = new psDBContext();
            int crtUserId = psContext.Users.First(x => x.UserName == user).Id;
            int itemId = psContext.TransactionItems.Where(x => (x.UserId == crtUserId)
                                                                  && (x.TransactionId == transId)
                                                                  ).ToList()[itemIndex].ProductId;
            string itemName = psContext.Products.First(x => x.Id == itemId).ProductName;
            return itemName;
        }
        public static int GetAmountOfSameTransItems(string user, int transId, int itemIndex)
        {
            var psContext = new psDBContext();
            int crtUserId = psContext.Users.First(x => x.UserName == user).Id;
            int itemId = psContext.TransactionItems.Where(x => (x.UserId == crtUserId)
                                                                  && (x.TransactionId == transId)
                                                                  ).ToList()[itemIndex].ProductId;
            int transItemsNr = psContext.TransactionItems.First(x => x.ProductId == itemId).Amount;
            return transItemsNr;
        }
        public static decimal GetTransactionItemPrice(string user, int transId, int itemIndex)
        {
            decimal itemPrice = 0;
            var psContext = new psDBContext();
            int crtUserId = psContext.Users.First(x => x.UserName == user).Id;
            int itemId = psContext.TransactionItems.Where(x => (x.UserId == crtUserId)
                                                                  && (x.TransactionId == transId)
                                                                  ).ToList()[itemIndex].ProductId;
            itemPrice = psContext.TransactionItems.First(x => x.ProductId == itemId).Cost;
            return itemPrice;
        }
        public static string ConstructProductHierarchy(int PID)
        {
            string hierarchyText = string.Empty;
            var psContext = new psDBContext();
            Product crtProduct = psContext.Products.First(x => x.Id == PID);
            ProductSubCategory crtSubCategory = psContext.ProductSubCategories.First(x => x.Id == crtProduct.ProductSubCategoryId);
            string categoryName = psContext.ProductCategories.First(x => x.Id == crtSubCategory.ProductCategoryId).Name;
            hierarchyText = categoryName + ">" + crtSubCategory.Name + ">" + crtProduct.Model.ToString();
            return hierarchyText;
        }

        public static string GetNrOfProductsInCart(string userName)
        {
            var psContext = new psDBContext();
            int crtUserId = psContext.Users.First(x => x.UserName == userName).Id;
            List<ShoppingCartItem> cartItems = psContext.ShoppingCartItems.Where(x => x.Id == crtUserId).ToList();
            int nrOfProductsInCart = 0;
            foreach(ShoppingCartItem item in cartItems )
            {
                nrOfProductsInCart += item.Amount;
            }

            string productsString = string.Empty;

            if(nrOfProductsInCart!=0)
            {
                productsString = nrOfProductsInCart.ToString();
            }
            return productsString;
        }

    }
}
