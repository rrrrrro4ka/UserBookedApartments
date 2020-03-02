using BusinessService;
using PresentationLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer
{
    /// <summary>
    /// Для объединения всех моделей для вьюх.
    /// </summary>
    public class ServicesManager
    {
        private DataManager dataManager;
        private ApartmentService apartmentService;
        private UserService userService;

        public ServicesManager(DataManager dataManager)
        {
            this.dataManager = dataManager;
            apartmentService = new ApartmentService(dataManager);
            userService = new UserService(dataManager);
        }

        public ApartmentService Apartments { get { return apartmentService; } }
        public UserService Users { get { return userService; } }
    }
}
