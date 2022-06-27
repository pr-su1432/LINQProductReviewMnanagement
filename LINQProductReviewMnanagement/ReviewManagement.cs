using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProductReviewMnanagement
{
    public class ReviewManagement
    {
        public void getProductReview(List<ProductReview> productReviewsList)
        {
            foreach (var list in productReviewsList)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }

        }
    }
}
