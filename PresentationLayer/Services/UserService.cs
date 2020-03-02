using BusinessService;
using DataStorage.Entityes;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Services
{
    public class UserService
    {
        private DataManager dataManager;
        public UserService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        /// <summary>
        /// Получаем и возвращаем список пользовательских моделей.
        /// </summary>
        /// <returns></returns>
        public List<UsersViewModel> GetUsersList()
        {
            var users = dataManager.Users.GetAllUsers();
            List<UsersViewModel> usersList = new List<UsersViewModel>();
            foreach (var user in users)
            {
                usersList.Add(UserDBModelToView(user.Id));
            }
            return usersList;
        }

        /// <summary>
        /// Получаем одну модель конкретного пользователя.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UsersViewModel UserDBModelToView(int userId)
        {
            return new UsersViewModel() { Users = dataManager.Users.GetUsersbyId(userId) };
        }

        /// <summary>
        /// Если пользователь есть, то редактируем. Если такого нет, то создаём нового.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UsersEditModel GetUsertEditModel(int userId = 0)
        {
            if (userId != 0)
            {
                var userDB = dataManager.Users.GetUsersbyId(userId);
                var userEditModel = new UsersEditModel()
                {
                    Id = userDB.Id,
                    Login = userDB.Login,
                    MobilePhone = userDB.MobilePhone
                };
                return userEditModel;
            }
            else
            {
                return new UsersEditModel() { };
            }
        }

        /// <summary>
        /// Сохраняем модель пользователя в БД.
        /// </summary>
        /// <param name="editModel"></param>
        /// <returns></returns>
        public UsersViewModel SaveUserEditModelToDb(UsersEditModel editModel)
        {
            User user;
            if (editModel.Id != 0)
            {
                user = dataManager.Users.GetUsersbyId(editModel.Id);
            }
            else
            {
                user = new User();
            }
            user.Login = editModel.Login;
            user.MobilePhone = editModel.MobilePhone;
            dataManager.Users.SaveUser(user);
            return UserDBModelToView(user.Id);
        }

        /// <summary>
        /// Создаём новую модель пользователя.
        /// </summary>
        /// <returns></returns>
        public UsersEditModel CreateNewUserModel()
        {
            return new UsersEditModel() { };
        }

    }
}
