using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;


namespace AnimalShelter.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly AnimalShelterContext _db;

        public AnimalsController(AnimalShelterContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Animal> model = _db.Animals.GroupBy(animal => animal.Type).Select(animal => animal.First()).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Animal thisAnimal = _db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
            return View(thisAnimal);
        }

        public ActionResult AllNames(string type)
        {
            List<Animal> model = _db.Animals.Where(animals => animals.Type.Contains(type)).ToList();
            return View(model);
        }

        public ActionResult AdmitSort()
        {
            List<Animal> model = _db.Animals.OrderBy(animal => animal.AdmitDate).ToList();
             return View("Index", model);
        }

        public ActionResult NameSort()
        {
            List<Animal> model = _db.Animals.OrderBy(animal => animal.Name).ToList();
             return View(model);
        }
    }
}