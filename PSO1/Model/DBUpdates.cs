using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.IO;

namespace PSO1.Model
{
    public class DBUpdates
    {
        public static void DeleteUser(string user)
        {
            var psContext = new psDBContext();
            var userToDelete = psContext.Users.First(x => x.UserName == user);
            if(userToDelete!=null)
            {
                psContext.Users.Remove(userToDelete);
                psContext.SaveChanges();
            }  
        }
        public static void DeleteUserData(string user)
        {
            var psContext = new psDBContext();
            var queryPersonalData = psContext.UserPersonalDatas.First(x => x.UserName == user);
            if(queryPersonalData != null)
            {
                psContext.UserPersonalDatas.Remove(queryPersonalData);
                psContext.SaveChanges();
            }            
        }
        public static void DeleteUserAddress(string user)
        {
            var psContext = new psDBContext();
            var queryPersonalAddress = psContext.UserAddresses.First(x => x.UserName == user);
            if (queryPersonalAddress != null)
            {
                psContext.UserAddresses.Remove(queryPersonalAddress);
                psContext.SaveChanges();
            }
        }

        public static void DeleteAllUserData(string userName)
        {
            DeleteUserData(userName);
            DeleteUserAddress(userName);
            DeleteUser(userName);
        }

        /*
        public static async void WriteUserPersonalDataToDB<T>(string choice, string input, T context) where T : IDbContext
        {
            string loggedUser = Form.ActiveForm.Text;
            var crtUser = context.Users.First(x => x.UserName == loggedUser);
            UserPersonalData pdata = context.UserPersonalDatas.Find(crtUser.UserPersonalDataId);
            UserPDataChange(pdata, choice, input);
            await context.SaveChangesAsync();
        }*/

        public static async Task WriteUserPersonalDataToDB<T>(string choice, string input, T context) where T : IDbContext
        {
            string loggedUser = Form.ActiveForm.Text;
            var crtUser = context.Users.First(x => x.UserName == loggedUser);
            UserPersonalData pdata = context.UserPersonalDatas.Find(crtUser.UserPersonalDataId);
            UserPDataChange(pdata, choice, input);
            await context.SaveChangesAsync();
        }

        public static void UserPDataChange(UserPersonalData userData, string choice, string change)
        {
            switch (choice)
            {
                case "FirstName":
                    if (UserInputCheck.CheckName(change))
                    {
                        userData.FirstName = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong name");
                    }
                    break;
                case "LastName":
                    if (UserInputCheck.CheckName(change))
                    {
                        userData.LastName = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong name");
                    }
                    break;
                case "email":
                    if (UserInputCheck.CheckEmailAddress(change))
                    {
                        userData.Email = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong email address");
                    }

                    break;
                case "Telephone":
                    if (UserInputCheck.CheckNumber(change))
                    {
                        userData.Telephone = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong number");
                    }
                    break;
            }
        }

        public static async Task WriteUserAddressToDB<T>(string choice, string input, T context) where T :IDbContext
        {
            string loggedUser = Form.ActiveForm.Text;

            var crtUser = context.Users.First(x => x.UserName == loggedUser);
            UserAddress personalAddr = context.UserAddresses.Find(crtUser.UserAddressId);

            UserAddressChange(personalAddr, choice, input);
            await context.SaveChangesAsync();
        }

        public static void UserAddressChange(UserAddress userAddress, string choice, string change)
        {
            switch (choice)
            {
                case "Street":
                    if (UserInputCheck.CheckMultiName(change))
                    {
                        userAddress.Street = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong street name");
                    }

                    break;
                case "StreetNr":
                    int address;
                    if (int.TryParse(change, out address))
                    {
                        userAddress.StreetNr = address;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong input!");
                    }
                    break;
                case "City":
                    if (UserInputCheck.CheckMultiName(change))
                    {
                        userAddress.City = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong city name");
                    }
                    break;
                case "Region":
                    if (UserInputCheck.CheckMultiName(change))
                    {
                        userAddress.Region = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong region name");
                    }
                    break;
                case "Country":
                    if (UserInputCheck.CheckMultiName(change))
                    {
                        userAddress.Country = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong country name");
                    }
                    break;
                case "PostalCode":
                    int code;
                    if (int.TryParse(change, out code))
                    {
                        userAddress.PostalCode = code;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong input!");
                    }
                    break;
            }
        }
        public static async Task WriteNewPassToDB<T>(string newPass, T context) where T: IDbContext
        {
            string loggedUser = Form.ActiveForm.Text;

            var crtUser = context.Users.First(x => x.UserName == loggedUser);
            crtUser.Password = newPass;

            await context.SaveChangesAsync();
        }

        public static async Task CreateNewCategory<T>(string category, T context) where T: IDbContext
        {
            var existingCategories = context.ProductCategories.Where(x => x.Name == category).ToList();
            if (existingCategories.Count == 0)
            {
                var newCategory = new ProductCategory();
                newCategory.Name = category;
                context.ProductCategories.Add(newCategory);
            }
            await context.SaveChangesAsync();
        }

        public static async Task CreateNewManufacturer<T>(string manufacturer, T context) where T: IDbContext
        {
            var existingManufacturers = context.Manufacturers.Where(x => x.Name == manufacturer).ToList();
            if (existingManufacturers.Count == 0)
            {
                var newManufacturer = new Manufacturer();
                newManufacturer.Name = manufacturer;
                context.Manufacturers.Add(newManufacturer);
            }

            await context.SaveChangesAsync();
        }
   
        public static async Task CreateNewSubCategory<T>(string subCategory, string category, T context) where T : IDbContext
        {
            var Category = context.ProductCategories.First(x => x.Name == category);
            var existingSubCategories = context.ProductSubCategories.Where(x => x.Name == subCategory).ToList();
            if (existingSubCategories.Count == 0)
            {
                var newSubCategory = new ProductSubCategory();
                newSubCategory.Name = subCategory;
                newSubCategory.ProductCategoryId = Category.Id;
                context.ProductSubCategories.Add(newSubCategory);
            }
            await context.SaveChangesAsync();
        }

        public static async Task CreateNewProduct<T>(string[] productProperties, int initStock, decimal[] prices, T context) where T:IDbContext
        {
            string productName = productProperties[0];
            string productModel = productProperties[1];
            string productManufacturer = productProperties[2];
            string productSubcategory = productProperties[3];
            decimal sellPrice = prices[0];
            decimal supplierPrice = prices[1];
            var Manufacturer = context.Manufacturers.First(x => x.Name == productManufacturer);
            var Subcategory = context.ProductSubCategories.First(x => x.Name == productSubcategory);
            var existingProductName = context.Products.Where(x => x.ProductName == productName).ToList();
            if (existingProductName.Count == 0)
            {
                var newProduct = new Product();
                newProduct.ProductName = productName;
                newProduct.Model = productModel;
                newProduct.ManufacturerId = Manufacturer.Id;
                newProduct.SubCategory = Subcategory;
                newProduct.Stock = initStock;
                newProduct.crtSellPrice = sellPrice;
                newProduct.crtManufacturerPrice = supplierPrice;
                newProduct.Manufacturer = Manufacturer;
                context.Products.Add(newProduct);
            }
            await context.SaveChangesAsync();
        }

        public static bool DataGridViewAllowCustomExtraction(int cellIndex, int[] allowedColumnIndexes)
        {
            bool cellDataExtractionAllowed = false;
            foreach (int allowedIndex in allowedColumnIndexes)
            {
                if (cellIndex == allowedIndex)
                {
                    cellDataExtractionAllowed = true;
                }
            }

            return cellDataExtractionAllowed;
        }

        public static async Task<bool> WriteProductDataToDB<T>(int productId, int column, string value, T context) where T:IDbContext
        {
            bool writeToDBSuccessful = false;
            var crtProd = context.Products.Find(productId);

            if (column == 1)
            {
                crtProd.ProductName = value;
                writeToDBSuccessful = true;
            }
            else if (column == 6)
            {
                if (int.TryParse(value, out int stock) && stock >= 0)
                {
                    crtProd.Stock = stock;
                    writeToDBSuccessful = true;
                }
            }
            else if (column == 7)
            {
                if (decimal.TryParse(value, out decimal manufPrice) && manufPrice >= 0)
                {
                    crtProd.crtManufacturerPrice = manufPrice;
                    writeToDBSuccessful = true;
                }
            }
            else if (column == 8)
            {
                if (decimal.TryParse(value, out decimal sellPrice) && sellPrice >= 0)
                {
                    crtProd.crtSellPrice = sellPrice;
                    writeToDBSuccessful = true;
                }

            }
            if (column == 9)
            {
                crtProd.ProductSpecification = value;
                writeToDBSuccessful = true;
            }
            await context.SaveChangesAsync();
            return writeToDBSuccessful;
        }


        public static async Task SaveProductToWishlist<T>(string user, int PID, T context) where T:IDbContext
        {

            int crtUserId = context.Users.First(x => x.UserName == user).Id;
            var queryWishListItems = context.WishListItems.Where(x => (x.UserId == crtUserId)
                                                                         && x.ProductId == PID).ToList();
            if(queryWishListItems.Count == 0)
            {
                WishListItem newItem = new WishListItem();
                newItem.ProductId = PID;
                newItem.UserId = crtUserId;
                context.WishListItems.Add(newItem);
            }
            await context.SaveChangesAsync();
        }

        public static async Task SaveProductImgToDB<T>(int PID, string fileName, T context) where T:IDbContext
        {
            ProductPicture picture = new ProductPicture();
            picture.ProductId = PID;
            picture.CreateImage(fileName);
            await DeleteProductImageIfExisting(context);
            context.ProductPictures.Add(picture);
            await context.SaveChangesAsync();
        }
        public static async Task DeleteProductImageIfExisting<T>(T context) where T:IDbContext
        {
            int imgCount = context.ProductPictures.Count(); 
            if(imgCount!=0)
            {
                context.ProductPictures.Remove(context.ProductPictures.ToList()[0]);
                await context.SaveChangesAsync();
            }
        }


        public static async Task SaveProductSpecToDB<T>(int PID, string fileName, T context) where T:IDbContext
        {
            ProductSpecification spec = new ProductSpecification();
            spec.ProductId = PID;
            spec.CreateSpec(fileName);
            context.ProductSpecifications.Add(spec);
            await context.SaveChangesAsync();
        }


        public static async Task<bool> WriteMessageToDB<T>(Message newMessage, T context) where T:IDbContext
        {
            bool writeToDBSuccessful = false;
            if (InternalDBQueries.CheckForExistingUserGen(newMessage.Receiver, context))
            {
                context.Messages.Add(newMessage);
                await context.SaveChangesAsync();
                writeToDBSuccessful = true;
            }
            return writeToDBSuccessful;
        }

        /*
        public static string GetReplyMessage(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var queryReplyMessage = from message in psContext.Messages
                                    where message.Receiver == user
                                        && message.MessageReceiverStatus != "deleted"
                                        && message.MessageReceiverStatus != "spam"
                                    select message.MessageBody;
            string ReplyMessage = "";
            if (messageIndex >= 0)
            {
                ReplyMessage = queryReplyMessage.ToList()[messageIndex];
            }

            return ReplyMessage;
        }*/


        

        public static bool IsSentMessageEncrypted(string user, int messageIndex)
        {
            bool messageEncryption = false;
            psDBContext psContext = new psDBContext();
            var queryReceivedMessages = from message in psContext.Messages
                                        where message.Sender == user
                                           && message.MessageSenderStatus != "deleted"
                                        select message.IsEncrypted;
            if (messageIndex >= 0)
            {
                messageEncryption = queryReceivedMessages.ToList()[messageIndex];
            }
            return messageEncryption;
        }
        public static bool IsDeletedMessageEncrypted(string user, int messageIndex)
        {
            bool messageEncryption = false;
            psDBContext psContext = new psDBContext();
            var queryReceivedMessages = from message in psContext.Messages
                                        where message.Receiver == user
                                           && message.MessageReceiverStatus == "deleted"
                                        select message.IsEncrypted;
            if (messageIndex >= 0)
            {
                messageEncryption = queryReceivedMessages.ToList()[messageIndex];
            }
            return messageEncryption;
        }
        public static bool IsSpamMessageEncrypted(string user, int messageIndex)
        {
            bool messageEncryption = false;
            psDBContext psContext = new psDBContext();
            var queryReceivedMessages = from message in psContext.Messages
                                        where message.Receiver == user
                                           && message.MessageReceiverStatus == "spam"
                                        select message.IsEncrypted;
            if (messageIndex >= 0)
            {
                messageEncryption = queryReceivedMessages.ToList()[messageIndex];
            }
            return messageEncryption;
        }
        public static bool IsMessageEncrypted(string user, int messageIndex, string searchWord)
        {
            bool messageEncryption = false;
            psDBContext psContext = new psDBContext();
            var queryReceivedMessages = from message in psContext.Messages
                                            //where message.Receiver == user
                                        where message.Receiver == user &&
                                              //message.MessageStatus != "deleted" &&
                                              message.MessageReceiverStatus != "deleted"
                                              && message.MessageReceiverStatus != "spam"
                                              && message.MessageBody.Contains(searchWord)
                                        select message.IsEncrypted;
            if (messageIndex >= 0)
            {
                messageEncryption = queryReceivedMessages.ToList()[messageIndex];
            }
            return messageEncryption;
        }

        public static void DeleteReceiverMsg(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var messages = psContext.Messages.Where(x => (x.Receiver == user)
                                                        && ((x.MessageReceiverStatus == "unread")
                                                           || (x.MessageReceiverStatus == "read")));
            if (messageIndex >= 0)
            {
                var messageToDelete = messages.ToList()[messageIndex];
                //messageToDelete.DeleteMessage();
                messageToDelete.DeleteReceiverMessage();
            }
            psContext.SaveChanges();
        }
        public static void DeleteSenderMsg(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var messages = psContext.Messages.Where(x => (x.Sender == user)
                                                        && (x.MessageSenderStatus == "sent"));
            if (messageIndex >= 0)
            {
                var messageToDelete = messages.ToList()[messageIndex];
                //messageToDelete.DeleteMessage();
                messageToDelete.DeleteSenderMessage();
            }
            psContext.SaveChanges();
        }
        public static void SpamMsg(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var messages = psContext.Messages.Where(x => (x.Receiver == user)
                                                     && ((x.MessageReceiverStatus == "read")
                                                       || (x.MessageReceiverStatus == "unread")));
            if (messageIndex >= 0)
            {
                var messageToSpam = messages.ToList()[messageIndex];
                messageToSpam.SpamMessage();
            }

            psContext.SaveChanges();
        }
        public static void ReadMsg(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var messages = psContext.Messages.Where(x => (x.Receiver == user)
                                                       // && (  (x.MessageStatus == "sent") 
                                                       //    || (x.MessageStatus == "read"))
                                                       && ((x.MessageReceiverStatus == "read")
                                                        || (x.MessageReceiverStatus == "unread")));
            if (messageIndex >= 0)
            {
                var messageToRead = messages.ToList()[messageIndex];
                messageToRead.ReadMessage();
            }


            psContext.SaveChanges();
        }
        public static void ReadSentMsg(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var messages = psContext.Messages.Where(x => (x.Sender == user)
                                                      && x.MessageSenderStatus != "deleted");
            if (messageIndex >= 0)
            {
                var messageToRead = messages.ToList()[messageIndex];
                messageToRead.ReadMessage();
            }


            psContext.SaveChanges();
        }
        public static void ReadDeletedMsg(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var messages = psContext.Messages.Where(x => (x.Receiver == user)
                                                      && x.MessageReceiverStatus == "deleted");
            if (messageIndex >= 0)
            {
                var messageToRead = messages.ToList()[messageIndex];
                messageToRead.DeleteReceiverMessage();
            }
            psContext.SaveChanges();
        }
        public static void ReadSpamMsg(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var messages = psContext.Messages.Where(x => (x.Receiver == user)
                                                      && x.MessageReceiverStatus == "spam");
            if (messageIndex >= 0)
            {
                var messageToRead = messages.ToList()[messageIndex];
                messageToRead.SpamMessage();
            }
            psContext.SaveChanges();
        }

        public static void CreateNewShoppingCartItem(string user, int PID, int amount)
        {
            psDBContext psContext = new psDBContext();
            ShoppingCartItem Item = new ShoppingCartItem();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            Item.UserId = crtUser.Id;
            Item.ProductId = PID;
            Item.Amount = amount;
            psContext.ShoppingCartItems.Add(Item);
            psContext.SaveChanges();

        }
        public static void DeleteCartItem(string user, int itemSelection)
        {
            psDBContext psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            try
            {
                var cartItem = psContext.ShoppingCartItems.Where(x => x.UserId == crtUser.Id).ToList()[itemSelection];
                psContext.ShoppingCartItems.Remove(cartItem);
            }
            catch(ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            psContext.SaveChanges();
        }

        public static void DeleteWishListItem(string user, int itemSelection)
        {
            psDBContext psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            var cartItem = psContext.WishListItems.Where(x => x.UserId == crtUser.Id).ToList()[itemSelection];
            psContext.WishListItems.Remove(cartItem);
            psContext.SaveChanges();
        }
        public static void DeleteCartItem(string user, ShoppingCartItem item)
        {

        }
        public static void CheckoutCartItems<T>(string user, T context) where T:IDbContext
        {
            var crtUser = context.Users.First(x => x.UserName == user);
            List<ShoppingCartItem> CartItems = GetCartItems(user);
            if(CartItems.Count !=0)
            {
                Transaction crtTransaction = GetCrtTransaction(user);
                foreach (ShoppingCartItem item in CartItems)
                {
                    TransactionItem newItem = CreateNewTransactionItem(item, crtTransaction);
                    context.TransactionItems.Add(newItem);
                    ShoppingCartItem crtItem = context.ShoppingCartItems.First(x => (x.UserId == item.UserId)
                                                                                && (x.ProductId == item.ProductId));
                    context.ShoppingCartItems.Remove(crtItem);
                    context.Transactions.First(x => x.Id == crtTransaction.Id).TotalCost -= newItem.Cost;
                    Product crtProduct = context.Products.First(x => x.Id == item.ProductId);

                    crtProduct.decreaseStock(newItem.Amount);
                    crtUser.ModifyCredit(-newItem.Cost);
                    context.SaveChanges();
                    StockCheck(item.ProductId, context);
                }
            }
            else 
            {
                MessageBox.Show("Cart is empty!");
            }
        }

        public static void StockCheck<T>(int PID, T context) where T: IDbContext
        {
            Product crtProduct = context.Products.First(x => x.Id == PID);
            if(InternalDBQueries.CheckIfProductAlarmExists(PID, context))
            {
                if(InternalDBQueries.GetWarehouseProductAlarmTriggerValue(PID, context) > crtProduct.Stock)
                { 
                    var queryWarehouseAlarm = context.WarehouseProductStockAlarms.First(x => x.ProductId == PID);
                    queryWarehouseAlarm.TriggerAlarm(crtProduct.Stock);
                    context.SaveChanges();
                }
            }
        }
    public static void ModifyShoppingCartItemAmount(string user, int selection, int newAmount)
        {
            psDBContext psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            try 
            {
                var crtShoppingCartItem = psContext.ShoppingCartItems.Where(x => x.UserId == crtUser.Id).ToList()[selection];
                crtShoppingCartItem.Amount = newAmount;
            }
            catch(ArgumentOutOfRangeException e)
            {
                MessageBox.Show(e.ToString());
            }
            
            psContext.SaveChanges();
        }
        public static bool CheckIfEnoughFounds(string user)
        {
            bool enoughFounds = false;
            psDBContext psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            List<ShoppingCartItem> CartItems = GetCartItems(user);
            decimal totalCostCart = 0;

            foreach (ShoppingCartItem item in CartItems)
            {
                decimal productCost = psContext.Products.First(x => x.Id == item.ProductId).crtSellPrice;
                totalCostCart += productCost * item.Amount;
            }
            if (crtUser.Credit >= totalCostCart)
            {
                enoughFounds = true;
            }

            return enoughFounds;
        }

        public static TransactionItem CreateNewTransactionItem(ShoppingCartItem cartItem, Transaction transaction)
        {
            psDBContext psContext = new psDBContext();
            TransactionItem newItem = new TransactionItem();
            decimal price = psContext.Products.First(x => x.Id == cartItem.ProductId).crtSellPrice;
            newItem.TransactionId = transaction.Id;
            newItem.UserId = cartItem.UserId;
            newItem.ProductId = cartItem.ProductId;
            newItem.Amount = cartItem.Amount;
            newItem.Cost = cartItem.Amount * price;
            newItem.TransactionTime = transaction.TransactionTime;
            return newItem;
        }
        public static Transaction GetCrtTransaction(string user)
        {
            psDBContext psContext = new psDBContext();
            Transaction newTransaction = new Transaction();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            newTransaction.UserId = crtUser.Id;
            psContext.Transactions.Add(newTransaction);
            psContext.SaveChanges();
            return newTransaction;

        }

        public static void AddCredit(string user, decimal credit)
        {
            psDBContext psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            
            crtUser.ModifyCredit(credit);
            Transaction newTransaction = new Transaction();
            newTransaction.UserId = crtUser.Id;
            newTransaction.TotalCost = credit;

            psContext.Transactions.Add(newTransaction);
            psContext.SaveChanges();
        }

        public static void TransactionInit(string user)
        {
            psDBContext psContext = new psDBContext();
            Transaction newTransaction = new Transaction();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            newTransaction.UserId = crtUser.Id;
            psContext.Transactions.Add(newTransaction);
            psContext.SaveChanges();
        }

        public static List<ShoppingCartItem> GetCartItems(string user)
        {
            psDBContext psContext = new psDBContext();
            List<int> cartItemsList = new List<int>();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            var cartItems = psContext.ShoppingCartItems.Where(x => x.UserId == crtUser.Id).ToList();

            return cartItems;
        }

        public static void CreateNewReview(string user, int PID, string title, string review, int rating)
        {
            psDBContext psContext = new psDBContext();
            UserItemReview newReview = new UserItemReview();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            newReview.UserId = crtUser.Id;
            newReview.ProductId = PID;
            newReview.UserItemScore = rating;
            newReview.Title = title;
            newReview.Review = review;
            psContext.UserItemReviews.Add(newReview);
            psContext.SaveChanges();
        }

        public static void CreateNewWarehouseProductStockAlarm(string user, int PID, int minAmount )
        {
            psDBContext psContext = new psDBContext();
            WarehouseProductStockAlarm newWarehouseProductStockAlarm = new WarehouseProductStockAlarm();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            newWarehouseProductStockAlarm.UserId = crtUser.Id;
            newWarehouseProductStockAlarm.ProductId = PID;
            newWarehouseProductStockAlarm.MinAmount = minAmount;
            newWarehouseProductStockAlarm.CreateMessage();
            psContext.WarehouseProductStockAlarms.Add(newWarehouseProductStockAlarm);
            psContext.SaveChanges();
        }
        public static void ModifyWarehouseProductStockAlarm(string user, int PID, int minAmount)
        {
            psDBContext psContext = new psDBContext();
            var crtUser = psContext.Users.First(x => x.UserName == user);
            WarehouseProductStockAlarm queryWarehouseProductStockAlarm = psContext.WarehouseProductStockAlarms.First(x => x.UserId == crtUser.Id
                                                                                                    && x.ProductId == PID);
            queryWarehouseProductStockAlarm.MinAmount = minAmount;
            queryWarehouseProductStockAlarm.CreateMessage();
            psContext.SaveChanges();
        }

    }
}
