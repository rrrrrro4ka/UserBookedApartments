using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessService;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer;
using PresentationLayer.Models;
using static DataStorage.Enums.PageEnums;

namespace UserBookedApartments.Controllers
{
    public class UserController : Controller
    {
        private DataManager dataManager;
        private ServicesManager servicesManager;
        public UserController(DataManager dataManager)
        {
            this.dataManager = dataManager;
            this.servicesManager = new ServicesManager(dataManager);
        }
        public IActionResult Index(int pageId, PageType pageType)
        {
            List<UsersViewModel> userListModel = servicesManager.Users.GetUsersList();
            return View(userListModel);
        }
    }
}