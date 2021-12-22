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
        public static bool CheckForExistingUserGen<T>(string userName, T context) where T : IDbContext// psDBContext
        {

            bool exisitingUser = false;
            var queryUsers =context.Users.Where(x => x.UserName == userName).ToList();
            if (queryUsers.Count != 0)
            {
                exisitingUser = true;
            }
            return exisitingUser;
        }

        public static int GetUserPersonalDataId<T>(string userName, T context) where T: IDbContext
        {
            int UserPersonalDataId = context.UserPersonalDatas.First(x => x.UserName == userName).Id;
            return UserPersonalDataId;
        }

        public static int GetUserAddressId<T>(string userName, T context) where T:IDbContext
        {
            int UserAddressId = context.UserAddresses.First(x => x.UserName == userName).Id;
            return UserAddressId;
        }

        public static bool CheckForCorrectPassword<T>(string loggedUser, string password, T context) where T: IDbContext
        {
            bool correctPassword = false;
            var crtUser = context.Users.First(x => x.UserName == loggedUser);
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

        public static bool CheckForAdminRights<T>(string userName, T context) where T:IDbContext
        {
            var crtUser = context.Users.First(x => x.UserName == userName);
            bool isAdmin = crtUser.isAdmin;
            return isAdmin;
        }

        public static bool CheckForExistingAdmin<T>(T context) where T:IDbContext
        {
            bool alreadyExistingAdmin = false;
            var queryAdmins = context.Users.Where(x => x.isAdmin == true).ToList();
            if(queryAdmins.Count!=0)
            {
                alreadyExistingAdmin = true;
            }
            return alreadyExistingAdmin;
        }

        public static int GetWishListSize<T>(string userName, T context) where T: IDbContext
        {
            var psContext = new psDBContext();
            int crtUserId = context.Users.First(x => x.UserName == userName).Id;
            int wishListSize = context.WishListItems.Where(x => x.UserId == crtUserId).ToList().Count;
            return wishListSize;
        }

        public static bool IsProductInCart<T>(string user, int PID, T context) where T:IDbContext
        {
            bool productinCart = false;
            var crtUser = context.Users.First(x => x.UserName == user);
            var item = context.ShoppingCartItems.Where(x => (x.ProductId == PID) && (x.UserId == crtUser.Id)).ToList();

            if (item.Count > 0)
            {
                productinCart = true;
            }
            return productinCart;
        }

        public static int GetMaxAmount<T>(int PID, T context) where T:IDbContext
        {
            int amount;
            Product productQuery = context.Products.First(x => x.Id == PID);
            amount = productQuery.Stock;
            return amount;
        }

        public static int GetShoppingCartItemAmount<T>(string user, int index, T context) where T:IDbContext
        {
            var crtUserId = context.Users.First(x => x.UserName == user).Id;
            int amount = context.ShoppingCartItems.Where(x => x.UserId == crtUserId).ToList()[index].Amount;
            return amount;
        }
        public static int GetNrOfTransItems<T>(string user, int transId, T context) where T:IDbContext
        {
            var crtUser = context.Users.First(x => x.UserName == user);
            int transItemsNr = context.TransactionItems.Where(x => (x.UserId == crtUser.Id)
                                                                  && (x.TransactionId == transId)).ToList().Count;
            return transItemsNr;
        }

        public static List<int> GetTransactionItemsIds<T>(int transId, T context) where T:IDbContext 
        {
            List<int> transactionItemsIds = new List<int>();
            var queryTransactionItems = context.TransactionItems.Where(x => x.TransactionId == transId).ToList();
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

        public static string ConstructTransactionItemInfo<T>(int transItemId, T context) where T: IDbContext
        {
            string itemInfo = string.Empty;
            StringBuilder infoBuilder = new StringBuilder();

            var crtTransItem = context.TransactionItems.First(x => x.Id == transItemId);
            string TransItemId = crtTransItem.Id.ToString();
            var crtProduct = context.Products.First(x => x.Id == crtTransItem.ProductId);
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

        public static string[] GetLastTransInfo<T>(string user, T context) where T:IDbContext
        {
            string[] lastTransInfo = new string[4];
            var crtUser = context.Users.First(x => x.UserName == user);
            lastTransInfo[0] = crtUser.UserName;
            Transaction lastTransaction = context.Transactions.Where(x => x.UserId == crtUser.Id).ToList().Last();
            lastTransInfo[1] = lastTransaction.Id.ToString();
            lastTransInfo[2] = lastTransaction.TotalCost.ToString();
            lastTransInfo[3] = InfoMessagesConstruction.ConstructTransactionInfo(lastTransaction.Id, user);
            return lastTransInfo;
        }

        public static decimal GetProductPrice<T>(int PID, T context) where T:IDbContext
        {
            decimal productPrice = context.Products.First(x => x.Id == PID).crtSellPrice;
            return productPrice;
        }

        public static string ConstructProductHierarchy<T>(int PID, T context) where T:IDbContext
        {
            string hierarchyText = string.Empty;
            Product crtProduct = context.Products.First(x => x.Id == PID);
            ProductSubCategory crtSubCategory = context.ProductSubCategories.First(x => x.Id == crtProduct.ProductSubCategoryId);
            string categoryName = context.ProductCategories.First(x => x.Id == crtSubCategory.ProductCategoryId).Name;
            hierarchyText = categoryName + ">" + crtSubCategory.Name + ">" + crtProduct.Model.ToString();
            return hierarchyText;
        }

       
        public static int GetNrOfProductsInCart<T>(string userName, T context) where T:IDbContext
        {
            int productsInCart = 0;
            int crtUserId = context.Users.First(x => x.UserName == userName).Id;
            var queryCartProducts = context.ShoppingCartItems.Where(x => x.UserId == crtUserId).ToList();
            foreach(ShoppingCartItem item in queryCartProducts)
            {
                productsInCart += item.Amount;                               
            }
            return productsInCart;
        }

        public static bool CheckIfEnoughCreditforPurcahasing<T>(string user, decimal purchaseValue, T context) 
                                                                where T:IDbContext 
        {
            bool enoughCredit = false;
            var crtUser = context.Users.First(x => x.UserName == user);
            if(crtUser.Credit >= purchaseValue)
            {
                enoughCredit = true;
            }
            return enoughCredit;
        }

        public static string GetCrtCreditStatus<T>(string user, T context) where T:IDbContext
        {
            var crtUser = context.Users.First(x => x.UserName == user);
            string crtCredit = crtUser.Credit.ToString();
            return crtCredit;
        }

        public static bool CheckIfReviewedProduct<T>(string user, int index, T context) where T:IDbContext
        {
            bool wasReviewed = false;
            var crtUser = context.Users.First(x => x.UserName == user);

            List<Product> purchasedProducts = DBBindings.BuildUserPurchasedProductsList(user);
            int crtPID = purchasedProducts[index].Id;  

            List <UserItemReview> userReviews = context.UserItemReviews.Where(x => x.UserId == crtUser.Id).ToList();
            foreach(UserItemReview review in userReviews)
            {
                if(review.ProductId == crtPID)
                {
                    wasReviewed = true;
                    return wasReviewed;
                }
            }
            return wasReviewed; 
        }
        public static int GetCrtPIDFromPurchasedProdList<T>(string user, int index, T context) where T:IDbContext 
        {
            var crtUser = context.Users.First(x => x.UserName == user);
            List<Product> purchasedProducts = DBBindings.BuildUserPurchasedProductsList(user);
            int crtPID = purchasedProducts[index].Id;
            return crtPID;
        }

        public static string GetProductName<T>(int PID, T context) where T:IDbContext
        {
            string prodName = context.Products.First(x =>x.Id == PID).ProductName; 
            return prodName;
        }
        public static string GetProductNameProt(GenericDBEntityQueries<Product> query)
        {

            string prodName = query.GetItem().ProductName;
            return prodName;
        }



        public static int GetCrtReviewId<T>(string user, int index, T context ) where T:IDbContext
        {
            var crtUser = context.Users.First(x => x.UserName == user);
            int PID = GetCrtPIDFromPurchasedProdList(user, index, context);
            int reviewId = context.UserItemReviews.First(x => (x.UserId == crtUser.Id)
                                                                && (x.ProductId == PID)).Id; 
            return reviewId;
        }
        public static string GetReviewer<T>(int reviewId, T context) where T:IDbContext
        {
            int userId = context.UserItemReviews.First(x => x.Id == reviewId).UserId;
            string reviewer = context.Users.First(x => x.Id == userId).UserName;
            return reviewer; 
        }
        public static string GetReviewProductName<T>(int reviewId, T context) where T:IDbContext
        {
            int PID = context.UserItemReviews.First(x => x.Id == reviewId).ProductId;
            string productName = GetProductName(PID, context);
            return productName;
        }

        public static string GetReviewTitle<T>(int reviewId, T context) where T:IDbContext
        {
            string title = context.UserItemReviews.First(x => x.Id == reviewId).Title;
            return title;
        }
        public static string GetReview<T>(int reviewId, T context) where T:IDbContext
        {
            string review = context.UserItemReviews.First(x => x.Id == reviewId).Review;
            return review;
        }
        public static string GetReviewProductRating<T>(int reviewId, T context) where T:IDbContext 
        {
            string rating = context.UserItemReviews.First(x => x.Id == reviewId).UserItemScore.ToString();
            return rating;
        }

        public static string GetReviewDate<T>(int reviewId, T context) where T:IDbContext
        {
            string reviewDate = context.UserItemReviews.First(x => x.Id == reviewId).ReviewTime.ToString();
            return reviewDate;
        }

        /*
        public static UserItemReview GetUserItemReview(int UserItemReviewId)
        {
            var psContext = new psDBContext();
            UserItemReview userItemReview = psContext.UserItemReviews.First(x => x.Id == UserItemReviewId);
            return userItemReview;
        }*/
        public static List<int> GetProductReviewIds<T>(int PID, T context) where T:IDbContext
        {
            List<int> productReviewIds = new List<int>();
            List<UserItemReview> queryUserItemReviews = context.UserItemReviews.Where(x => x.ProductId ==PID).ToList(); 
            foreach(UserItemReview item in queryUserItemReviews)
            {
                productReviewIds.Add(item.Id);
            }
            return productReviewIds;
        }

        /*
        public static List<int> GetProductReviewIdsProt(GenericDBItemsQueries<UserItemReview> query)
        {
            List<int> productReviewIds = new List<int>();
            var queryUserItemReviews = query.GetItemsList();
            foreach (UserItemReview item in queryUserItemReviews)
            {
                productReviewIds.Add(item.Id);
            }
            return productReviewIds;
        }*/

        public static int GetNrOfUnreadMessages<T>(string userName, T context) where T: IDbContext
        {
            var queryUnreadMessages = context.Messages.Where(x => x.Receiver == userName
                                                                && x.MessageReceiverStatus == "unread").ToList();
            int unreadMessages = queryUnreadMessages.Count();
            return unreadMessages;
        }
        
        public static int GetAllTransCount() 
        {
            var psContext = new psDBContext();

            int allTransCount = psContext.Transactions.Count(); 
            return allTransCount;
        }
        /*
        public async static Task<string> GetAllTransCountAsync()
        {
            var psContext = new psDBContext();
            int allTransCount = psContext.Transactions.Count();
            await Task.Delay(50); // simulation DB read delay
            return allTransCount.ToString();
        }*/
        public async static Task<string> GetAllTransCountAsync(IDbContext context) 
        {
            int allTransCount = context.Transactions.Count();
            await Task.Delay(50); // simulation DB read delay
            return allTransCount.ToString();
        }

        public static int GetSentMesssagesCount()
        {
            var psContext = new psDBContext();
            int allMsgCount = psContext.Messages.Count();
            return allMsgCount;
        }
        public async static Task<string> GetSentMesssagesCountAsync(IDbContext context)
        {
            var psContext = new psDBContext();
            int allMsgCount = psContext.Messages.Count();
            await Task.Delay(50); // simulation DB read delay
            return allMsgCount.ToString();
        }
        public static int GetReviewsCount()
        {
            var psContext = new psDBContext();
            int allRevsCount = psContext.UserItemReviews.Count();
            return allRevsCount;
        }

        public async static Task<string> GetReviewsCountAsync(IDbContext context)
        {
            int allRevsCount = context.UserItemReviews.Count();
            await Task.Delay(50); // simulation DB read delay
            return allRevsCount.ToString();
        }

        public static int GetSoldProductsCount()
        {
            var psContext = new psDBContext();
            int allSoldProdCount = 0;
            var queryTransItems = psContext.TransactionItems.ToList();
            foreach(TransactionItem item in queryTransItems)
            {
                allSoldProdCount += item.Amount;
            }
            return allSoldProdCount;
        }

        public async static Task<string> GetSoldProductsCountAsync(IDbContext context)
        {
            int allSoldProdCount = 0;
            var queryTransItems = context.TransactionItems.ToList();
            foreach (TransactionItem item in queryTransItems)
            {
                allSoldProdCount += item.Amount;
            }
            await Task.Delay(50); // simulation DB read delay
            return allSoldProdCount.ToString();
        }


        public static decimal GetTotalIncome()
        {
            var psContext = new psDBContext();
            decimal totalIncome = 0;
            var queryTransItems = psContext.TransactionItems.ToList();
            foreach (TransactionItem item in queryTransItems)
            {
                totalIncome += item.Cost;
            }
            return totalIncome;
        }

        public async static Task<string> GetTotalIncomeAsync(IDbContext context)
        {
            decimal totalIncome = 0;
            var queryTransItems = context.TransactionItems.ToList();
            foreach (TransactionItem item in queryTransItems)
            {
                totalIncome += item.Cost;
            }
            await Task.Delay(50); // simulation DB read delay
            return totalIncome.ToString();
        }

        public static decimal GetTotalBoughtCredit()
        {
            var psContext = new psDBContext();
            decimal totalCreditBought = 0;
            var allTransactions = psContext.Transactions.Where(x => x.TotalCost>0).ToList();
            foreach(Transaction trans in allTransactions)
            {
                totalCreditBought += trans.TotalCost;
            }
            return totalCreditBought;
        }

        public async static Task<string> GetTotalBoughtCreditAsync(IDbContext context)
        {
            decimal totalCreditBought = 0;
            var allTransactions = context.Transactions.Where(x => x.TotalCost > 0).ToList();
            foreach (Transaction trans in allTransactions)
            {
                totalCreditBought += trans.TotalCost;
            }
            await Task.Delay(50); // simulation DB read delay
            return totalCreditBought.ToString();
        }

        public static string GetProductRating<T>(int PID, T context) where T:IDbContext
        {
            string ratingStr = "Not rated";
            double ratingsSum = 0;
            var queryProductRatings = context.UserItemReviews.Where(x => x.ProductId == PID).ToList();
            if (queryProductRatings.Count>0)
            {
                foreach(UserItemReview review in queryProductRatings)
                {
                    ratingsSum += review.UserItemScore;
                }
                ratingStr = (ratingsSum / queryProductRatings.Count).ToString();
            }
            return ratingStr;
        }
        /*
        public static string GetProductRatingProt1(GenericDBItemsQueries<UserItemReview> query)
        {
            string ratingStr = "Not rated";
            double ratingsSum = 0;
            var queryProductRatings = query.GetItemsList();

            if (queryProductRatings.Count > 0)
            {
                foreach (UserItemReview review in queryProductRatings)
                {
                    ratingsSum += review.UserItemScore;
                }
                ratingStr = (ratingsSum / queryProductRatings.Count).ToString();
            }
            return ratingStr;
        }*/
        
        public static bool CheckIfAlarmIsCreated<T>(string user, int PID, T context) where T: IDbContext
        {
            bool alarmCreated = false;
            int userId = context.Users.First(x => x.UserName == user).Id;
            var queryWarehouseProductStockAlarms = context.WarehouseProductStockAlarms.Where(x => x.UserId == userId
                                                                                                && x.ProductId == PID).ToList();
            if(queryWarehouseProductStockAlarms.Count !=0)
            {
                alarmCreated = true;
            }
            return alarmCreated;
        }
        public static bool CheckIfProductAlarmExists<T>(int PID, T context) where T:IDbContext 
        {
            bool alarmExists = false;
            var queryAlarm = context.WarehouseProductStockAlarms.Where(x => x.ProductId == PID).ToList();
            if(queryAlarm.Count != 0)
            {
                alarmExists = true; 
            }
            return alarmExists;
        }
        public static int GetWarehouseProductAlarmTriggerValue<T>(int PID, T context) where T:IDbContext
        {
            var queryAlarm = context.WarehouseProductStockAlarms.First(x => x.ProductId == PID);
            return queryAlarm.MinAmount;
        }

        public static string GetProductSpec<T>(int PID, T context) where T : IDbContext
        {
            var queryProducts = context.Products.FirstOrDefault(x => x.Id == PID).ProductSpecification;
            return queryProducts;
        }

        public static byte[] GetPictureData<T>(int PID, T context) where T : IDbContext
        {
            byte[] pictureData = new byte[] { };
            try
            {
                pictureData = context.ProductPictures.First(x => x.ProductId == PID).ImageData;

            }
            catch (InvalidOperationException e)
            {

            }
            return pictureData;
        }

        public static byte[] GetSpecData<T>(int PID, T context) where T:IDbContext
        {
            byte[] specData = new byte[] { };
            try
            {
                specData = context.ProductSpecifications.First(x => x.ProductId == PID).SpecData;
            }
            catch (InvalidOperationException e)
            {

            }
            return specData;
        }
  

        public static string GetMessage<T>(string user, int messageIndex, T context) where T:IDbContext
        {
            psDBContext psContext = new psDBContext();
            var queryReceivedMessages = context.Messages.Where(x => x.Receiver == user
                                                                 && x.MessageReceiverStatus != "deleted"
                                                                 && x.MessageReceiverStatus != "spam")
                                                        .Select(x => x.MessageBody);
            string messageToDisplay = "";
            if (messageIndex >= 0)
            {
                messageToDisplay = queryReceivedMessages.ToList()[messageIndex]; // System.ArgumentOutOfRangeException: 'Index was out of range. 
            }
            return messageToDisplay;
        }


    }
}
