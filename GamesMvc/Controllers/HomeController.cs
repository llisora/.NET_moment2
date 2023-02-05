using GamesMvc.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace GamesMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var JsonStr = System.IO.File.ReadAllText("games.json");
            var JsonObj = JsonConvert.DeserializeObject<List<GameModel>>(JsonStr);

            return View(JsonObj);
        }


        [Route("/om-sidan")]
        public IActionResult About()
        {
            ViewBag.Message = "Test av ViewBag!";
            return View();
        }
        [Route("/spel")]
        public IActionResult Games()
        {
            return View();
        }

        [HttpPost("/spel")]
        public IActionResult Games(GameModel model)
        {
            if (ModelState.IsValid)
            {
                //Korrekt ifyllt
                var JsonStr = System.IO.File.ReadAllText("games.json");
                var JsonObj = JsonConvert.DeserializeObject<List<GameModel>>(JsonStr);

                if (JsonObj != null)
                {
                    JsonObj.Add(model);
                    System.IO.File.WriteAllText("games.json", JsonConvert.SerializeObject(JsonObj, Formatting.Indented));

                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }
    }
}

