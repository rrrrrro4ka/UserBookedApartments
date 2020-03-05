using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessService;
using DataStorage.Entityes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserBookedApartments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataManager dataManager;

        public UsersController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        //GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await dataManager.Users.GetAllUsersAsyncToApi();
        }

        //GET: api/Users/5
        [HttpGet("{userId}")]
        public async Task<ActionResult<User>> GetUser(int userId)
        {
            var getuser = await dataManager.Users.GetUserAsyncToApi(userId);
            if (getuser.Value == null)
            {
                NotFound();
            }
            return getuser;
        }
    }
}