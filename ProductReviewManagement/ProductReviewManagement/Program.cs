using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problem");

            //UC1-Adding default 25 values
            List<ProductReview> Product;
            Product = new List<ProductReview>
            {
                new ProductReview() { ProductId = 12, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 70, UserId = 16, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 35, UserId = 111, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 167, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 16, UserId = 13, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 85, UserId = 15, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 96, UserId = 12, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 50, UserId = 16, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 126, UserId = 111, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 100, UserId = 178, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 30, UserId = 123, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 18, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 20, UserId = 11, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 70, UserId = 16, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 10, UserId = 19, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 12, Rating = 2, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 40, UserId = 15, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 60, UserId = 11, Rating = 4, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 20, UserId = 15, Rating = 1, Review = "Bad", isLike = false },
                new ProductReview() { ProductId = 80, UserId = 19, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 30, UserId = 19, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 50, UserId = 11, Rating = 2, Review = "Good", isLike = false },
                new ProductReview() { ProductId = 60, UserId = 25, Rating = 3, Review = "Average", isLike = true },
                new ProductReview() { ProductId = 90, UserId = 19, Rating = 1, Review = "Good", isLike = false }
            };
            //UC2
            ProductManagement.Top3Records(Product);

            //UC3-Retrieve all records who's Rating is Greater that 3 and Product ID is 1 or 4 or 9
            ProductManagement.RetriveAllRecordWhosRatingGreaterThan3(Product);

            //UC4-Retrieve count of review present for each Product ID
            ProductManagement.RetrieveCountofReviewForEachProiductId(Product);


        }
    }
}
