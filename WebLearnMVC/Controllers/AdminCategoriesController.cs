using Microsoft.AspNetCore.Mvc;

namespace WebLearnMVC.Controllers
{
    public class AdminCategoriesController : Controller
    {
        //AdminCategories/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //AdminCategories/Add?name=name
        [HttpPost]
        public IActionResult Add(string name)
        {
            var lastCategory = ShopController.categories.LastOrDefault()!;
            ShopController.categories.Add(new Models.Category
            {
                Id = lastCategory.Id + 1,
                Name = name
            });
            return RedirectToAction("Categories", controllerName: "Shop");
        }

        public IActionResult Edit() { return View(); }

        public IActionResult Delete() { return View(); }
    }
}
