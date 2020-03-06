using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessService;
using DataStorage;
using DataStorage.Entityes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PresentationLayer;
using PresentationLayer.Models;
using UserBookedApartments.Models;

namespace UserBookedApartments.Controllers
{
    public class HomeController : Controller
    {
        private DataManager datamanager;
        private ServicesManager serviceManager;
        public HomeController(DataManager dataManager)
        {
            this.datamanager = dataManager;
            this.serviceManager = new ServicesManager(datamanager);
        }

        public IActionResult Index()
        {
            List<ApartmentsViewModel> aps = serviceManager.Apartments.GetApartmentsList();
            return View(aps);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// Удаление апартмента из списка
        /// </summary>
        [HttpPost]
        public IActionResult DeleteApartment(int id)
        {
            serviceManager.Apartments.DeleteApartment(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
