using Microsoft.AspNetCore.Mvc;

using EstudoMVC.Models;

namespace EstudoMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }
        public IActionResult Create() 
        {
            var DogVm = new DogViewModel();
            return View(DogVm);
        }
        public IActionResult CreateDog(DogViewModel dog) 
        {
            dogs.Add(dog);
            return RedirectToAction(nameof(Index));
        }
    }
}
