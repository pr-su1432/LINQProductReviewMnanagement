using Microsoft.Azure.Amqp.Framing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProductReviewMnanagement
{
    internal class ReviewManagement
    {
        public void getProductReview(List<ProductReview> productReviewsList)
        {
            foreach (var list in productReviewsList)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }

        }

        public void TopRatedRecords(List<ProductReview> productReviewList)
        {
            var data = (from ProductReview in productReviewList
                          orderby ProductReview.Rating descending
                          select ProductReview).Take(3);
            foreach (var list in data)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }
        }
        public void RecordsOfratingsGreaterThan3(List<ProductReview> productReviewList)
        {
            var data = (from productReview in productReviewList
                          where productReview.Rating > 3 &&
                          (productReview.ProductID == 1 || productReview.ProductID == 4 || productReview.ProductID == 9)
                          select productReview);
            Console.WriteLine("Retrive all records of ratings greater than 3 and who's product ID is 1 or 4 or 9.");
            foreach (var list in data)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }
        }
    }
}
