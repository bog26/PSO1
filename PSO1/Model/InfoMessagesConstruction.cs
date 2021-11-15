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
            int nrOfItems = GetNrOfTransItems(user, transId);
            transInfo = nrOfItems.ToString() + " " + "different products in total" + "\n";

            List<int> transItemsIds = GetTransactionItemsIds(transId);
            foreach (int transItemsId in transItemsIds)
            {
                transInfo = transInfo + ConstructTransactionItemInfo(transItemsId);
            }

            return transInfo;
        }
        public static string ConstructProductReviewInfo(int reviewId)
        {
            string reviewer = GetReviewer(reviewId);
            string product = GetReviewProductName(reviewId);
            string rating = GetReviewProductRating(reviewId);
            string title = GetReviewTitle(reviewId);
            string review = GetReview(reviewId);
            string date = GetReviewDate(reviewId);
            string productReview = $"{reviewer} rewiewed {product} on {date} and rated it with {rating} stars \n" +
                                   $"{title}\n{review}";
            return productReview.ToString();
        }
    }
   
}
