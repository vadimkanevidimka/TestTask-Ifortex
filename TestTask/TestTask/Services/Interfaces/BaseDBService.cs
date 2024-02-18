using Microsoft.EntityFrameworkCore;
using TestTask.Data;

namespace TestTask.Services.Interfaces
{
    public class BaseDBService
    {
        protected ApplicationDbContext _dbContext = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
    }
}
