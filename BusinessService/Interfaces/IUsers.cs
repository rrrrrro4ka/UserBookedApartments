using DataStorage.Entityes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Interfaces
{
    public interface IUsers
    {
        IEnumerable<User> GetAllUsers();
        Task<ActionResult<IEnumerable<User>>> GetAllUsersAsync();
        User GetUsersbyId(int userid);
        Task<ActionResult<User>> GetUserAsync(int userId);
        void SaveUser(User user);
        void DeleteUser(User user);
        Task DeleteUserAsync(int userid);
        Task AddUserAsync(User user);
    }
}
