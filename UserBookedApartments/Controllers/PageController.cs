using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessService;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer;
using PresentationLayer.Models;
using UserBookedApartments.Models;
using static DataStorage.Enums.PageEnums;

namespace UserBookedApartments.Controllers
{
    public class PageController : Controller
    {
        private DataManager dataManager;
        private ServicesManager servicesManager;
        public PageController(DataManager dataManager)
        {
            this.dataManager = dataManager;
            this.servicesManager = new ServicesManager(dataManager);
        }

        /// <summary>
        /// Открываем страницу с нужной инфомрацией в зависимости от типа.
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="pageType"></param>
        /// <returns></returns>
        public IActionResult Index(int pageId, PageType pageType)
        {
            PageViewModel viewModel;
            switch (pageType)
            {
                case PageType.Apartments: viewModel = servicesManager.Apartments.ApartmentDBToViewModelById(pageId); break;
                case PageType.Users: viewModel = servicesManager.Users.UserDBModelToView(pageId); break;
                default: viewModel = null; break;
            }
            ViewBag.PageType = pageType;
            return View(viewModel);
        }

        /// <summary>
        /// Какую именно страницу показываем для редактирования в зависимости от типа.
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="pageType"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult PageEditor(int pageId, PageType pageType)
        {
            PageEditModel pageEditModel;
            switch (pageType)
            {
                case PageType.Apartments:
                    if (pageId != 0) pageEditModel = servicesManager.Apartments.GetApartmentEditModel(pageId);
                    else pageEditModel = servicesManager.Apartments.CreateNewApartmentsModel(); break;
                case PageType.Users:
                    if (pageId != 0) pageEditModel = servicesManager.Users.GetUsertEditModel(pageId);
                    else pageEditModel = servicesManager.Users.CreateNewUserModel(); break;
                default: pageEditModel = null; break;
            }
            ViewBag.PageType = pageType;
            return View(pageEditModel);
        }

        /// <summary>
        /// Сохранение или создание апартамента
        /// </summary>
        /// <param name="apartmentEditModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SaveApartment(ApartmentsEditModel apartmentEditModel)
        {
            servicesManager.Apartments.SaveApartmentEditModelToDB(apartmentEditModel);
            return RedirectToAction("PageEditor", "Page", new { pageId = apartmentEditModel.Id, pageType = PageType.Apartments });
        }

        /// <summary>
        /// Сохранение или создание пользователя
        /// </summary>
        /// <param name="userEditModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SaveUser(UsersEditModel userEditModel)
        {
            servicesManager.Users.SaveUserEditModelToDb(userEditModel);
            return RedirectToAction("PageEditor", "Page", new { pageId = userEditModel.Id, pageType = PageType.Users });
        }
    }
}