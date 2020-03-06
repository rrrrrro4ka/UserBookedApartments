using BusinessService.Interfaces;
using DataStorage;
using DataStorage.Entityes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BusinessService.Implementations
{
    public class EFUsers : IUsers
    {
        private FrameworkDBContext context;
        public EFUsers(FrameworkDBContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Удалить пользователя
        /// </summary>
        /// <param name="user"></param>
        public void DeleteUser(int userId)
        {
            var userToDelete = context.Users.FirstOrDefault(u => u.Id == userId);
            if (userToDelete != null) context.Remove(userToDelete);
            context.SaveChanges();
        }

        /// <summary>
        /// Получить всех пользователей
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAllUsers()
        {
            return context.Users.ToList();
        }

        /// <summary>
        /// Получить пользователя по Id
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public User GetUsersbyId(int userid)
        {
            return context.Users.FirstOrDefault(u => u.Id == userid);
        }

        /// <summary>
        /// Сохранить пользователя
        /// </summary>
        /// <param name="user"></param>
        public void SaveUser(User user)
        {
            if (user.Id == 0)
            {
                context.Users.Add(user);
            }
            else
            {
                context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            context.SaveChanges();
        }

        /// <summary>
        /// Список пользователей для API
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsersAsync()
        {
            return await context.Users.ToListAsync();
        }

        /// <summary>
        /// Отдаём одного пользователя по id. API
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<ActionResult<User>> GetUserAsync(int userId)
        {
            return await context.Users.FindAsync(userId);
        }

        /// <summary>
        /// Добавляем пользователя, ожидаем JSON. API
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task AddUserAsync(User user)
        {
            var userAdd = await context.Users.FindAsync(user.Id);
            if (userAdd == null)
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Удаления пользователя. API
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public async Task DeleteUserAsync(int userid)
        {
            var user = await context.Users.FindAsync(userid);
            if (user != null)
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
            }
        }
    }
}
