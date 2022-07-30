using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        //UC2-Top 3 Records of High Rating
        public static void Top3Records(List<ProductReview> Product)
        {
            var result = (from PM in Product orderby PM.Rating descending select PM).Take(3);
            Console.WriteLine("Top 3 Records are :");
            foreach (ProductReview pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nUser ID: " + pm.UserId +
                                    "\nRating: " + pm.Rating +
                                    "\nReview: " + pm.Review +
                                    "\nIS Liked : " + pm.isLike);
            }
        }
    }
}
