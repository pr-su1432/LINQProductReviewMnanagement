using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQProductReviewMnanagement
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to product review management problem ststement:");
            List<ProductReview> ProductReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1, UserID=1, Rating=9,Review="Good",IsLike=false},
                new ProductReview(){ProductID=2, UserID=1, Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=3, UserID=2, Rating=5,Review="Good",IsLike=false},
                new ProductReview(){ProductID=4, UserID=2, Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=5, UserID=1, Rating=4,Review="very bad",IsLike=true},
                new ProductReview(){ProductID=6, UserID=3, Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=7, UserID=3, Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=8, UserID=3, Rating=5,Review="nice",IsLike=false},
                new ProductReview(){ProductID=9, UserID=4, Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=10, UserID=5, Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=12, UserID=5, Rating=5,Review="Good",IsLike=false},
                new ProductReview(){ProductID=13, UserID=1, Rating=4,Review="Bad",IsLike=true},
                new ProductReview(){ProductID=14, UserID=1, Rating=5,Review="Good",IsLike=false},
                new ProductReview(){ProductID=15, UserID=1, Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=16, UserID=10, Rating=2,Review="Good",IsLike=false},
                new ProductReview(){ProductID=17, UserID=10, Rating=6,Review="Good",IsLike=true},
                new ProductReview(){ProductID=18, UserID=10, Rating=7,Review="Good",IsLike=true},
                new ProductReview(){ProductID=19, UserID=10, Rating=8,Review="not good",IsLike=false},
                new ProductReview(){ProductID=20, UserID=10, Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=21, UserID=10, Rating=5,Review="nice",IsLike=true},
                new ProductReview(){ProductID=22, UserID=10, Rating=2,Review="nice",IsLike=false},
                new ProductReview(){ProductID=23, UserID=10, Rating=5,Review="super",IsLike=true},
                new ProductReview(){ProductID=24, UserID=10, Rating=5,Review="nice",IsLike=false},
                new ProductReview(){ProductID=25, UserID=10, Rating=5,Review="nice",IsLike=false},
            };
            LINQProductReviewMnanagement.ReviewManagement review = new LINQProductReviewMnanagement.ReviewManagement();
            //review.getProductReview(ProductReviewList);
            //review.TopRatedRecords(ProductReviewList);
            //review.RecordsOfratingsGreaterThan3(ProductReviewList);
            //review.retriveCountOfRecords(ProductReviewList);
            //review.RetriveproductIDAndReview(ProductReviewList);
            review.recorsSkipTop5Records(ProductReviewList);

        }
    }
}