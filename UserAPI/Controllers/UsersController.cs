using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using UserAPI.Dto.Users;
using UserAPI.Models.Users;
using UserAPI.Services.Users;

namespace UserAPI.Controllers
{
    public class UsersController : BaseController<User>
    {
        private readonly IUserService _service;

        public UsersController(IUserService service, IMapper mapper) : base(mapper)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var list = await _service.GetAll();

                if (list.Count == 0) return NotFound();

                return Ok(MapDTO<UserDTO>(list));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
