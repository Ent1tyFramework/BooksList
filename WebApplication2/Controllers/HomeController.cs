using Data.Managers;
using Data.Managers.Interfaces;
using Domain;
using Services.Managers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private IServiceManager serviceManager;
        private IRepositoryManager dataManager;

        public HomeController(IServiceManager serviceManager, IRepositoryManager dataManager)
        {
            this.serviceManager = serviceManager;
            this.dataManager = dataManager;
        }

        //Start page
        public ActionResult List()
        {
            var genRepo = dataManager.GenericRepository<Book>();

            return View(genRepo.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    var genService = serviceManager.GenericService<Book>();

            //    bool isAdded = genService.Create(new Book()
            //    {
            //        Name = model.Name,
            //        Author = model.Author,
            //        Price = model.Price
            //    });

            //    if (isAdded)
            //        return JavaScript("alert('book added successfully!');");
            //    else
            //        return JavaScript("alert('book does not added!');");
            //}
            ModelState.AddModelError("", "ASDASDA");
            return View();
        }
    }
}