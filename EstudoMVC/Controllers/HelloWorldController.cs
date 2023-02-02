using Microsoft.AspNetCore.Mvc;

using EstudoMVC.Models;

namespace EstudoMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<AnimalDomestico> dogs = new List<AnimalDomestico>();
        public IActionResult Index()
        {
            return View(dogs);
        }
        public IActionResult Create() 
        {
            var DogVm = new AnimalDomestico();
            return View(DogVm);
        }
        public IActionResult CreateDog(AnimalDomestico dog) 
        {
            dogs.Add(dog);
            return RedirectToAction(nameof(Index));
        }
    }
}
