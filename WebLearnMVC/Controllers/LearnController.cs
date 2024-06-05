using Microsoft.AspNetCore.Mvc;

namespace WebLearnMVC.Controllers
{
    public class LearnController : Controller
    {
        static List<string> clothes = new List<string>
        {
            "سویشرت مردانه رینگ مدل BMK01273 رنگ شیری",
            "سویشرت مردانه رینگ مدل BMK01273 رنگ آبی نفتی",
            "شلوار جین مردانه رینگ مدل PMD00533"
        };

        public string Index(string name)
        {
            return "Hello " + name;
        }

        public IActionResult SearchView()
        {
            return View();
        }

        public string GetClothes()
        {

            return string.Join(", ", clothes);
        }

        public IActionResult AddClothesView()
        {
            return View();
        }

        public string AddClothes(string name)
        {
            clothes.Add(name);
            return "OK";
        }

        public string RemoveClothes(string name)
        {
            clothes.Remove(name);
            return "OK";
        }
    }
}
