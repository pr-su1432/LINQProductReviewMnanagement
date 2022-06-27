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
            var result = (from ProductReview in productReviewList
                          orderby ProductReview.Rating descending
                          select ProductReview).Take(3);
            foreach (var list in result)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }


        }
    }
}
