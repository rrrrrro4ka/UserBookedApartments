using BusinessService;
using DataStorage.Entityes;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Services
{
    public class ApartmentService
    {
        private DataManager dataManager;
        public ApartmentService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        /// <summary>
        /// Достаём все апартаменты и делаем list из них.
        /// </summary>
        /// <returns></returns>
        public List<ApartmentsViewModel> GetApartmentsList()
        {
            var aps = dataManager.Apartments.GetAllApartments();
            List<ApartmentsViewModel> apsModelList = new List<ApartmentsViewModel>();
            foreach (var item in aps)
            {
                apsModelList.Add(ApartmentDBToViewModelById(item.Id));
            }
            return apsModelList;
        }

        /// <summary>
        /// Получаем Апартамент по Id
        /// </summary>
        /// <param name="apartmentId"></param>
        /// <returns></returns>
        public ApartmentsViewModel ApartmentDBToViewModelById(int apartmentId)
        {
            return new ApartmentsViewModel() { Apartments = dataManager.Apartments.GetApartmentsbyId(apartmentId) };
        }

        /// <summary>
        /// Если апартамент есть, то редактируем или создаём новый.
        /// </summary>
        /// <param name="apartmentId"></param>
        /// <returns></returns>
        public ApartmentsEditModel GetApartmentEditModel(int apartmentId = 0)
        {
            if (apartmentId != 0)
            {
                var apsDB = dataManager.Apartments.GetApartmentsbyId(apartmentId);
                var apsEditModel = new ApartmentsEditModel()
                {
                    Id = apsDB.Id,
                    Address = apsDB.Address,
                    Area = apsDB.Area,
                    MaxGuets = apsDB.MaxGuets,
                    Rooms = apsDB.Rooms,
                    Cost = apsDB.Cost
                };
                return apsEditModel;
            }
            else
            {
                return new ApartmentsEditModel() { };
            }
        }

        /// <summary>
        /// Приводим модель к модели БД и сохраняем.
        /// </summary>
        /// <param name="apartmentEditModel"></param>
        /// <returns></returns>
        public ApartmentsViewModel SaveApartmentEditModelToDB(ApartmentsEditModel apartmentEditModel)
        {
            Apartments apartmentDBModel;
            if (apartmentEditModel.Id != 0)
            {
                apartmentDBModel = dataManager.Apartments.GetApartmentsbyId(apartmentEditModel.Id);
            }
            else
            {
                apartmentDBModel = new Apartments() { };
            }
            apartmentDBModel.Area = apartmentEditModel.Area;
            apartmentDBModel.Address = apartmentEditModel.Address;
            apartmentDBModel.Cost = apartmentEditModel.Cost;
            apartmentDBModel.Rooms = apartmentEditModel.Rooms;
            apartmentDBModel.MaxGuets = apartmentDBModel.MaxGuets;

            dataManager.Apartments.SaveApartment(apartmentDBModel);

            return ApartmentDBToViewModelById(apartmentDBModel.Id);
        }

        /// <summary>
        /// Удаление апартамента
        /// </summary>
        /// <param name="ApartmentViewModelId"></param>
        public void DeleteApartment(int ApartmentViewModelId)
        {
            dataManager.Apartments.DeleteApartment(ApartmentViewModelId);
        }
        /// <summary>
        /// Создаём новую модель для пользователя.
        /// </summary>
        /// <returns></returns>
        public ApartmentsEditModel CreateNewApartmentsModel()
        {
            return new ApartmentsEditModel() { };
        }
    }
}
