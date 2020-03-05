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
        public void DeleteUser(User user)
        {
            var userToDelete = context.Users.FirstOrDefault(u => u.Id == user.Id);
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
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsersAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<ActionResult<User>> GetUserAsync(int userId)
        {
            return await context.Users.FindAsync(userId);
        }

        public async Task AddUserAsync(User user)
        {
            var userAdd = await context.Users.FindAsync(user.Id);
            if (userAdd == null)
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
        }

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
