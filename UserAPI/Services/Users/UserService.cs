using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserAPI.Helpers;
using UserAPI.Models;
using UserAPI.Models.Users;

namespace UserAPI.Services.Users
{
    public class UserService : IUserService
    {
        private readonly DatabaseContext _context;

        public UserService(DatabaseContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<List<User>> GetAll()
        {
            return await _context.Users.WhereExists().ToListAsync();
        }
    }
}
