using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Migrations;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services.Implementations
{
    public class UserService : BaseDBService, IUserService //Added implementation for IUserService, and add Base class for all DataBase services
    {
        public Task<User> GetUser()
        {
            return _dbContext.Users.OrderByDescending(x => x.Orders.Count()).FirstAsync();
        }

        public Task<List<User>> GetUsers()
        {
            return _dbContext.Users.Where(usr => usr.Status == Enums.UserStatus.Inactive).ToListAsync();
        }
    }
}
