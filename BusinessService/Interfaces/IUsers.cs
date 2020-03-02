using DataStorage.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Interfaces
{
    public interface IUsers
    {
        IEnumerable<User> GetAllUsers();
        User GetUsersbyId(int userid);
        void SaveUser(User user);
        void DeleteUser(User user);
    }
}
