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

        public static int GetShoppingCartItemAmount(string user, int index)
        {
            
            var psContext = new psDBContext();
            var crtUserId = psContext.Users.First(x => x.UserName == user).Id;
            int amount = psContext.ShoppingCartItems.Where(x => x.UserId == crtUserId).ToList()[index].Amount;
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

        public static List<int> GetTransactionItemsIds(int transId)
        {
            List<int> transactionItemsIds = new List<int>();
            var psContext = new psDBContext();
            var queryTransactionItems = psContext.TransactionItems.Where(x => x.TransactionId == transId).ToList();
            foreach(TransactionItem item in queryTransactionItems)
            {
                transactionItemsIds.Add(item.Id);
            }
            return transactionItemsIds;
        }

        public static int GetNrOfPurchasedTransItems(string user, int transId)
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
        public static int GetAmountOfSameTransItems(string user, int transId, int itemIndex) //To fix
        {
            var psContext = new psDBContext();
            int crtUserId = psContext.Users.First(x => x.UserName == user).Id;
            int itemId = psContext.TransactionItems.Where(x => (x.UserId == crtUserId)
                                                                  && (x.TransactionId == transId)
                                                                  ).ToList()[itemIndex].ProductId;
            int transItemsNr = psContext.TransactionItems.First(x => x.ProductId == itemId).Amount;
            return transItemsNr;
        }

        public static string ConstructTransactionItemInfo(int transItemId)
        {
            var psContext = new psDBContext();
            string itemInfo = string.Empty;
            StringBuilder infoBuilder = new StringBuilder();

            var crtTransItem = psContext.TransactionItems.First(x => x.Id == transItemId);
            string TransItemId = crtTransItem.Id.ToString();
            var crtProduct = psContext.Products.First(x => x.Id == crtTransItem.ProductId);
            int amount = crtTransItem.Amount;
            string plural = (amount > 1) ? "s" : string.Empty;
            string cost = (crtTransItem.Cost / amount).ToString();

            infoBuilder.Append($"Item with ID {crtProduct.Id}: ");
            infoBuilder.Append($"{amount} Pc{plural}.");
            infoBuilder.Append($"Price per unit: {crtProduct.crtSellPrice} \n");
            infoBuilder.Append(crtProduct.ProductName + "\n");
     
            itemInfo = infoBuilder.ToString();
            return itemInfo; 
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

        public static decimal GetProductPrice(int PID)
        {
            var psContext = new psDBContext();
            decimal productPrice = psContext.Products.First(x => x.Id == PID).crtSellPrice;
            return productPrice;
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

       
        public static int GetNrOfProductsInCart(string userName)
        {
            var psContext = new psDBContext();
            int productsInCart = 0;
            int crtUserId = psContext.Users.First(x => x.UserName == userName).Id;
            //var queryCartProducts = psContext.ShoppingCartItems.Where(x => x.UserId == crtUserId).ToList();
            var queryCartProducts = psContext.ShoppingCartItems.Where(x => x.UserId == crtUserId).ToList();
            foreach(ShoppingCartItem item in queryCartProducts)
            {
                productsInCart += item.Amount;                               
            }
            //productsInCart = queryCartProducts.Count();
            return productsInCart;
        }

        public static bool CheckIfEnoughCreditforPurcahasing(string user, decimal purchaseValue)
        {
            bool enoughCredit = false;
            var psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            if(crtUser.Credit >= purchaseValue)
            {
                enoughCredit = true;
            }
            return enoughCredit;
        }

        public static string GetCrtCreditStatus(string user)
        {
            var psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            string crtCredit = crtUser.Credit.ToString();
            return crtCredit;
        }




    }
}
