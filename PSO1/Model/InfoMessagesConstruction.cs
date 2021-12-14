using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PSO1.Model.FormElementsDisplay;
using static PSO1.Model.DBBindings;
using static PSO1.Model.InternalDBQueries;
using static PSO1.Model.UserInputCheck;
using static PSO1.Model.DBUpdates;

namespace PSO1.Model
{
    public static class InfoMessagesConstruction
    {
        public static string ConstructTransactionInfo(int transId, string user)
        {
            string transInfo;
            var connection = new MSSQLConnection<psDBContext>().Context;
            int nrOfItems = GetNrOfTransItems(user, transId, connection);
            transInfo = nrOfItems.ToString() + " " + "different products in total" + "\n";

            List<int> transItemsIds = GetTransactionItemsIds(transId, connection);
            foreach (int transItemsId in transItemsIds)
            {
                transInfo = transInfo + ConstructTransactionItemInfo(transItemsId, connection);
            }

            return transInfo;
        }
        public static string ConstructProductReviewInfo(int reviewId)
        {
            var connection = new MSSQLConnection<psDBContext>().Context;
            string reviewer = GetReviewer(reviewId, connection);
            string product = GetReviewProductName(reviewId,connection);
            string rating = GetReviewProductRating(reviewId,connection);
            string title = GetReviewTitle(reviewId,connection);
            string review = GetReview(reviewId,connection);
            string date = GetReviewDate(reviewId,connection);
            string productReview = $"{reviewer} rewiewed {product} on {date} and rated it with {rating} stars \n" +
                                   $"{title}\n{review}";
            return productReview.ToString();
        }
        
        public static string ConstructProductReviews<T>(int PID, T context) where T:IDbContext
        {
            StringBuilder allReviews = new StringBuilder();
            List<int> productReviewIds = GetProductReviewIds(PID, context);
            foreach (int id in productReviewIds)
            {
                allReviews.Append(GetReviewer(id, context) + " reviewed " + GetReviewProductName(id, context) +
                                  " on " + GetReviewDate(id, context) + "\n");
                allReviews.Append(GetReviewProductRating(id, context) + " stars: " + GetReviewTitle(id, context) + "\n");
                allReviews.Append(GetReview(id, context) + "\n\n"); 
            }
            return allReviews.ToString();
        }
        
        /*
        public static string ConstructProductReviewsProt(GenericDBItemsQueries<UserItemReview> query)
        {
            StringBuilder allReviews = new StringBuilder();
            List<int> productReviewIds = GetProductReviewIdsProt(query);
            var connection = new MSSQLConnection<psDBContext>().Context;
            foreach (int id in productReviewIds)
            {
                allReviews.Append(GetReviewer(id, connection) + " reviewed " + GetReviewProductName(id,connection) +
                                  " on " + GetReviewDate(id,connection) + "\n");
                allReviews.Append(GetReviewProductRating(id,connection) + " stars: " + GetReviewTitle(id,connection) + "\n");
                allReviews.Append(GetReview(id, connection) + "\n\n");
            }
            return allReviews.ToString();
        }*/
    }
   
}
