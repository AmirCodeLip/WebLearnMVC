using Microsoft.AspNetCore.Mvc;
using WebLearnMVC.Models;

namespace WebLearnMVC.Controllers
{
    public class ShopController : Controller
    {
        public static List<Category> categories = new List<Category>
        {
            new Category { Id = 1, Name =  "تی شرت مردانه" },
            new Category { Id = 2, Name =  "شلوار مردانه" },
            new Category { Id = 3, Name =  "هودی" },
        };

        public static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "تی شرت آستین بلند مردانه زی سا" , CategoryId = 1, ImageAddress = "images/image1.jpg" ,Price=100 },
            new Product { Id = 2, Name = "تیشرت آستین کوتاه مردانه 1991 اس دبلیو" , CategoryId = 1, ImageAddress = "images/image2.jpg", Price=200 },
            new Product { Id = 3, Name = "تی شرت لانگ آستین بلند مردانه باینت" , CategoryId = 1, ImageAddress = "images/image3.jpg" ,Price=170},
            new Product { Id = 4, Name = "تی شرت آستین بلند مردانه باینت 2" , CategoryId = 1, ImageAddress = "images/image4.jpg" ,Price=170},
            new Product { Id = 5, Name = "شلوار مردانه مدل کارگو کتان" , CategoryId = 2, ImageAddress = "images/image5.jpg" ,Price=337},
            new Product { Id = 6, Name = "شلوار اسلش مردانه طرح جین مدل 5 جیب کد KH5" , CategoryId = 2, ImageAddress = "images/image6.jpg" ,Price=349},
            new Product { Id = 7, Name = "هودی مردانه طرح چنگ کد A03 رنگ مشکی" , CategoryId = 3, ImageAddress = "images/image7.jpg" ,Price=122},
            new Product { Id = 8, Name = "هودی مردانه طرح Assassins کد S436 رنگ طوسی" , CategoryId = 3, ImageAddress = "images/image8.jpg" ,Price=101},
        };

        public IActionResult Categories()
        {
            return View(categories);
        }

        public IActionResult Category(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }
            var productsModel = products.Where(product => product.CategoryId == id).ToList();
            return View(productsModel);
        }

        public IActionResult Product()
        {
            return View();
        }
    }
}
