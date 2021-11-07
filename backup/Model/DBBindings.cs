using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Entity;


namespace PSO1.Model
{
    public class DBBindings
    {
        public static BindingSource BindAllUserDataToGrid()
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            var query = from i in psContext.Admins
                        orderby i.Id
                        select new
                        {
                            i.Id,
                            UserName = i.UserName,
                            Name = i.UserInfo.FirstName,
                            LastName = i.UserInfo.LastName,
                            BirthDate = i.UserInfo.BirthDate,
                            email = i.UserInfo.Email,
                            Telephone = i.UserInfo.Telephone
                        };
            binding.DataSource = query.ToList();
            return binding;
        }

        public static BindingSource BindCrtUserDataToGrid(string userName)
        {

            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            var queryAdmin = from user in psContext.Admins
                             where user.UserName == userName
                             select new
                             {
                                 UserName = user.UserName,
                                 FirstName = user.UserInfo.FirstName,
                                 LastName = user.UserInfo.LastName,
                                 BirthDate = user.UserInfo.BirthDate,
                                 email = user.UserInfo.Email,
                                 Telephone = user.UserInfo.Telephone
                             };
            var queryClient = from user in psContext.Clients
                              where user.UserName == userName
                              select new
                              {
                                  UserName = user.UserName,
                                  FirstName = user.UserInfo.FirstName,
                                  LastName = user.UserInfo.LastName,
                                  BirthDate = user.UserInfo.BirthDate,
                                  email = user.UserInfo.Email,
                                  Telephone = user.UserInfo.Telephone
                              };


            if (InternalDBQueries.CheckForAdminRights(userName))
            {
                binding.DataSource = queryAdmin.ToList();
            }
            else
            {
                binding.DataSource = queryClient.ToList();
            }
            return binding;

        }

        //TBD:
        private static IEnumerable<Object> UserDataQuery(string userName, psDBContext psContext)
        {
            IUser loggedUser;
            if (InternalDBQueries.CheckForAdminRights(userName))
            {
                loggedUser = psContext.Admins.First(x => x.UserName == userName);
            }
            else
            {
                loggedUser = psContext.Clients.First(x => x.UserName == userName);
            }


            var newData = new  //null obj
            {
                UserName = loggedUser.UserName,
                FirstName = loggedUser.UserInfo.FirstName,
                LastName = loggedUser.UserInfo.LastName,
                BirthDate = loggedUser.UserInfo.BirthDate,
                email = loggedUser.UserInfo.Email,
                Telephone = loggedUser.UserInfo.Telephone
            };


            if (loggedUser.GetType() == typeof(Admin))
            {
                var query = from user in psContext.Admins
                            where user.UserName == userName
                            select newData
                            ;

                return query;
            }
            else
            {
                var query = from user in psContext.Clients
                            where user.UserName == userName
                            select newData;

                return query;
            }

        }


        public static BindingSource BindCrtUserAddressToGrid(string userName)
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            var queryAdmin = from user in psContext.Admins
                             where user.UserName == userName
                             select new

                             {
                                 Street = user.UserAddress.Street,
                                 StreetNr = user.UserAddress.StreetNr,
                                 City = user.UserAddress.City,
                                 Region = user.UserAddress.Region,
                                 Country = user.UserAddress.Country,
                                 PostalCode = user.UserAddress.PostalCode
                             };

            var queryClient = from user in psContext.Clients
                              where user.UserName == userName
                              select new
                              {
                                  Street = user.UserAddress.Street,
                                  StreetNr = user.UserAddress.StreetNr,
                                  City = user.UserAddress.City,
                                  Region = user.UserAddress.Region,
                                  Country = user.UserAddress.Country,
                                  PostalCode = user.UserAddress.PostalCode
                              };



            if (InternalDBQueries.CheckForAdminRights(userName))
            {
                binding.DataSource = queryAdmin.ToList();
            }
            else
            {
                binding.DataSource = queryClient.ToList();
            }
            return binding;
        }
        public static BindingSource BindCategories()
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var queryCategory = from category in psContext.ProductCategories
                                select category.Name;
            //{ category.Name };
            binding.DataSource = queryCategory.ToList();
            return binding;
        }
        public static BindingSource BindManufacturers()
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var queryManufacturers = from manufacturer in psContext.Manufacturers
                                     select manufacturer.Name;
            //{ category.Name };
            binding.DataSource = queryManufacturers.ToList();
            return binding;
        }
        public static BindingSource BindSubcategories()
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var querySubcategories = from subcategory in psContext.ProductSubCategories
                                     select subcategory.Name;
            binding.DataSource = querySubcategories.ToList();
            return binding;
        }
        public static BindingSource BindReceivedMessages(string user)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var queryReceivedMessages = from message in psContext.Messages 
                                where message.Receiver == user 
                                    && message.MessageReceiverStatus != "deleted"
                                    && message.MessageReceiverStatus != "spam"
                                        select message.MessageTitle;
            binding.DataSource = queryReceivedMessages.ToList();
            return binding;
        }

        public static BindingSource BindSentMessages(string user)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var querySentMessages = from message in psContext.Messages
                                        where message.Sender == user 
                                           && message.MessageSenderStatus != "deleted"
                                        select message.MessageTitle;
            binding.DataSource = querySentMessages.ToList();
            return binding;
        }

        public static BindingSource BindDeletedMessages(string user)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var queryDeletedMessages = from message in psContext.Messages
                                    where message.Receiver == user
                                      // && message.Sender == user
                                       && message.MessageReceiverStatus == "deleted"
                                       //&& message.MessageSenderStatus == "deleted"
                                    select message.MessageTitle;
            binding.DataSource = queryDeletedMessages.ToList();
            return binding;
        }

        public static BindingSource BindSpamMessages(string user)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var querySpamMessages = from message in psContext.Messages
                                       where message.Receiver == user
                                          //&& message.Sender == user
                                          && message.MessageReceiverStatus == "spam"
                                       //&& message.MessageSenderStatus == "deleted"
                                       select message.MessageTitle;
            binding.DataSource = querySpamMessages.ToList();
            return binding;
        }


        public static BindingSource BindSearchMessages(string searchword, string user)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            var queryMessages = from message in psContext.Messages
                                where message.MessageBody.Contains(searchword)
                                //&& message.MessageStatus != "deleted"
                                && message.MessageReceiverStatus != "deleted"
                                && message.MessageReceiverStatus != "spam"
                                && message.Receiver == user
                                select message.MessageTitle;

            binding.DataSource = queryMessages.ToList();
            return binding;
        }

        public static BindingSource BindProductsToGrid()
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            
            var queryProducts = from product in psContext.Products
                                select new
                                {
                                    Model = product.Model,
                                    Category = product.SubCategory.Category,
                                    Subcategory = product.SubCategory,
                                    Manufacturer = product.Manufacturer,
                                    Stock = product.Stock,
                                    ManufPrice = product.crtManufacturerPrice,
                                    SellPrice = product.crtSellPrice,

                                };

            binding.DataSource = queryProducts.ToList();

            return binding;
        }

        public static BindingSource BindWishListPIDs(string clientName)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            List<int> wishListPIDs = new List<int>();
            var crtWishList = psContext.WishLists.First(x => x.ClientName == clientName);
            int[] crtWishListArr;
            crtWishListArr = crtWishList.getPIDs();
            for(int i=0; i< crtWishListArr.Count(); i++)
            {
                wishListPIDs.Add(crtWishListArr[i]);
            }
            binding.DataSource = wishListPIDs;
            return binding;

        }
        public static BindingSource BindWishListProducts(string clientName)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            List<int> wishListPIDs = new List<int>();
            List<string> wishListProducts = new List<string>();
            var crtWishList = psContext.WishLists.First(x => x.ClientName == clientName);
            int[] crtWishListArr;
            crtWishListArr = crtWishList.getPIDs();
            
            for (int i = 0; i < crtWishListArr.Count(); i++)
            {
                int crtProductID = crtWishListArr[i];
                var queryProduct = psContext.Products.First(x => x.Id == crtProductID);
                string productModel = queryProduct.ProductName;
                wishListProducts.Add(productModel);
            }

            binding.DataSource = wishListProducts;
            return binding;
        }

        public static BindingSource BindCartProducts(string clientName)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            List<string> cartProductNames = new List<string>();
            List<int> CartProductIDs = GetCartProductIDs(clientName);
            foreach (var PID in CartProductIDs)
            {
                Product product = psContext.Products.First(x => x.Id == PID);
                cartProductNames.Add(product.ProductName);
            }
            binding.DataSource = cartProductNames;
            return binding;
        }
        public static List<int> GetCartProductIDs(string clientName)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var crtClient = psContext.Clients.First(x => x.UserName == clientName);
            var productsQuery = from shoppingCart in psContext.ShoppingCartItems
                                where shoppingCart.ClientId == crtClient.Id
                                select shoppingCart.ProductId;
            return productsQuery.ToList();
        }


        public static BindingSource BindProductsToGrid(string keyword, string minPriceStr, string maxPriceStr)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            decimal minPrice;
            decimal maxPrice;
            

            var queryProducts = psContext.Products.Where(x => x.ProductName != " ");
            if (keyword != string.Empty)
            {
                queryProducts = queryProducts.Where(x => x.ProductName.Contains(keyword));
            }
            if(decimal.TryParse(minPriceStr, out minPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice > minPrice);
            }
            if (decimal.TryParse(maxPriceStr, out maxPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice < maxPrice);
            }

            var queryProductsReturn = from product in queryProducts
                                      select new
                                      {
                                          Name = product.ProductName,
                                          Model = product.Model,
                                          Category = product.SubCategory.Category,
                                          Subcategory = product.SubCategory,
                                          Manufacturer = product.Manufacturer,
                                          Stock = product.Stock,
                                          ManufPrice = product.crtManufacturerPrice,
                                          SellPrice = product.crtSellPrice,
                                      };

            binding.DataSource = queryProductsReturn.ToList();
            return binding;
        }
        public static BindingSource BindProductsToGrid(string keyword, string minPriceStr, string maxPriceStr, string category, string manufacturer)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            
            decimal minPrice;
            decimal maxPrice;
            int maxAllowedResults =500;

            var queryProducts = psContext.Products.Where(x => x.ProductName != " ").Take(maxAllowedResults);

            if (manufacturer != String.Empty)
            {
                queryProducts = psContext.Products.Where(x => x.Manufacturer.Name == manufacturer);
            }

            if (category != String.Empty)
            {
                queryProducts = psContext.Products.Where(x => x.SubCategory.Category.Name == category);
            }

            if (keyword != string.Empty)
            {
                queryProducts = queryProducts.Where(x => x.ProductName.Contains(keyword));
            }
            if (decimal.TryParse(minPriceStr, out minPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice > minPrice);
            }
            if (decimal.TryParse(maxPriceStr, out maxPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice < maxPrice);
            }

            var queryProductsReturn = from product in queryProducts
                                      select new
                                      {
                                          PID = product.Id,
                                          Name = product.ProductName,
                                          Model = product.Model,
                                          Category = product.SubCategory.Category,
                                          Subcategory = product.SubCategory,
                                          Manufacturer = product.Manufacturer,
                                          Stock = product.Stock,
                                          ManufPrice = product.crtManufacturerPrice,
                                          SellPrice = product.crtSellPrice,
                                          Spec = product.ProductSpecification
                                      };

            binding.DataSource = queryProductsReturn.ToList();
            return binding;
        }
        public static BindingSource BindProductsToGridForClient(string keyword, string minPriceStr, string maxPriceStr, string category, string manufacturer)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            decimal minPrice;
            decimal maxPrice;
            int maxAllowedResults = 500;

            var queryProducts = psContext.Products.Where(x => x.ProductName != " ").Take(maxAllowedResults);

            if (manufacturer != string.Empty)
            {
                queryProducts = psContext.Products.Where(x => x.Manufacturer.Name == manufacturer);
            }

            if (category != string.Empty)
            {
                queryProducts = psContext.Products.Where(x => x.SubCategory.Category.Name == category);
            }

            if (keyword != string.Empty)
            {
                queryProducts = queryProducts.Where(x => x.ProductName.Contains(keyword));
            }
            if (decimal.TryParse(minPriceStr, out minPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice > minPrice);
            }
            if (decimal.TryParse(maxPriceStr, out maxPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice < maxPrice);
            }

            var queryProductsReturn = from product in queryProducts
                                      select new
                                      {
                                          PID = product.Id,
                                          Name = product.ProductName,
                                          Model = product.Model,
                                          Category = product.SubCategory.Category,
                                          Subcategory = product.SubCategory,
                                          Manufacturer = product.Manufacturer,
                                          Price = product.crtSellPrice,
                                      };

            binding.DataSource = queryProductsReturn.ToList();
            return binding;
        }

        public static BindingSource BindProductsToGrid(string keyword, string minPriceStr, string maxPriceStr, string category)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            decimal minPrice;
            decimal maxPrice;

            var queryProducts = psContext.Products.Where(x => x.ProductName != " ");
            if(category != String.Empty)
            {
                queryProducts = psContext.Products.Where(x => x.SubCategory.Category.Name == category);
            }

            if (keyword != string.Empty)
            {
                queryProducts = queryProducts.Where(x => x.ProductName.Contains(keyword));
            }
            if (decimal.TryParse(minPriceStr, out minPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice > minPrice);
            }
            if (decimal.TryParse(maxPriceStr, out maxPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice < maxPrice);
            }

            var queryProductsReturn = from product in queryProducts
                                      select new
                                      {
                                          
                                          Name = product.ProductName,
                                          Model = product.Model,
                                          Category = product.SubCategory.Category,
                                          Subcategory = product.SubCategory,
                                          Manufacturer = product.Manufacturer,
                                          Stock = product.Stock,
                                          ManufPrice = product.crtManufacturerPrice,
                                          SellPrice = product.crtSellPrice,
                                      };

            binding.DataSource = queryProductsReturn.ToList();
            return binding;
        }
       

        public static BindingSource BindProductsToGridPrototype() //ok
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            string productModel = "Iphone";
            string category = "Mobile";
            string subcategory = "IOS Smartphones";
            string manufacturer = "Apple";
            var queryProducts = from product in psContext.Products
                                where
                                      product.SubCategory.Name == subcategory &&
                                      product.Manufacturer.Name == manufacturer
                                select new
                                {
                                    Model = product.Model,
                                    Category = product.SubCategory.Category,
                                    Subcategory = product.SubCategory,
                                    Manufacturer = product.Manufacturer,
                                    Stock = product.Stock,
                                    ManufPrice = product.crtManufacturerPrice,
                                    SellPrice = product.crtSellPrice,
                                };

            binding.DataSource = queryProducts.ToList();
            return binding;
        }

        public static BindingSource BindProductsToGridPrototype1(string keyword) 
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            var queryProducts = psContext.Products.Where(x => x.ProductName != " ");
            if (keyword != string.Empty)
            {
                queryProducts = queryProducts.Where(x => x.ProductName.Contains(keyword));
            }

            var queryProductsReturn = from product in queryProducts
                                      select new
                                      {
                                          Name = product.ProductName,
                                          Model = product.Model,
                                          Category = product.SubCategory.Category,
                                          Subcategory = product.SubCategory,
                                          Manufacturer = product.Manufacturer,
                                          Stock = product.Stock,
                                          ManufPrice = product.crtManufacturerPrice,
                                          SellPrice = product.crtSellPrice,
                                      };

            binding.DataSource = queryProductsReturn.ToList();
            return binding;
        }


       
        public static BindingSource BindInboxMessagesToGridView(string user)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            var queryInboxMessages = from message in psContext.Messages
                                        where message.Receiver == user
                                            && message.MessageReceiverStatus != "deleted"
                                            && message.MessageReceiverStatus != "spam"
                                        select new
                                        {
                                            From = message.Sender,
                                            Title = message.MessageTitle,
                                            Time = message.MessageTime
                                        };

            binding.DataSource = queryInboxMessages.ToList();
            return binding;
        }

        public static BindingSource BindInboxSearchMessagesToGridView(string user, string searchword)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            var queryInboxMessages = from message in psContext.Messages
                                     where message.Receiver == user
                                         && message.MessageBody.Contains(searchword)
                                         && message.MessageReceiverStatus != "deleted"
                                         && message.MessageReceiverStatus != "spam"
                                     select new
                                     {
                                         From = message.Sender,
                                         Title = message.MessageTitle,
                                         Time = message.MessageTime
                                     };

            binding.DataSource = queryInboxMessages.ToList();
            return binding;
        }

        public static BindingSource BindSentMessagesToGridView(string user)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            var querySentMessages = from message in psContext.Messages
                                     where message.Sender == user
                                         && message.MessageSenderStatus != "deleted"
                                    select new
                                     {
                                         From = message.Sender,
                                         Title = message.MessageTitle,
                                         Time = message.MessageTime
                                     };

            binding.DataSource = querySentMessages.ToList();
            return binding;
        }

        public static BindingSource BindDeletedMessagesToGridView(string user)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            var queryDeletedMessages = from message in psContext.Messages
                                    where message.Receiver == user
                                        && message.MessageReceiverStatus == "deleted"
                                    select new
                                    {
                                        From = message.Sender,
                                        Title = message.MessageTitle,
                                        Time = message.MessageTime
                                    };

            binding.DataSource = queryDeletedMessages.ToList();
            return binding;
        }

        public static BindingSource BindSpamMessagesToGridView(string user)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            var queryDeletedMessages = from message in psContext.Messages
                                       where message.Receiver == user
                                           && message.MessageReceiverStatus == "spam"
                                       select new
                                       {
                                           From = message.Sender,
                                           Title = message.MessageTitle,
                                           Time = message.MessageTime
                                       };

            binding.DataSource = queryDeletedMessages.ToList();
            return binding;
        }

        public static BindingSource BindTransactionsToGrid(string user)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var crtUser = psContext.Clients.First(x => x.UserName == user);
            var queryTransactions = from transaction in psContext.Transactions
                                    where transaction.ClientId == crtUser.Id
                                    select new
                                    {
                                        ID = transaction.Id,
                                        Time = transaction.TransactionTime,
                                        Amount = transaction.TotalCost
                                    };
            binding.DataSource = queryTransactions.ToList();
            return binding;
        }


    }

}
