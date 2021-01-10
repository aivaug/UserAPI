using AutoMapper;
using UserAPI.Dto.Users;
using UserAPI.Models.Users;

namespace UserAPI.Helpers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserDTO>();
        }
    }
}
