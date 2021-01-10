using System.Collections.Generic;
using System.Threading.Tasks;
using UserAPI.Models.Users;

namespace UserAPI.Services.Users
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
    }
}
