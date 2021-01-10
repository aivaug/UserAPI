using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using UserAPI.Models;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase
        where T : BaseModel
    {
        private readonly IMapper _mapper;
        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }

        protected List<Type> MapDTO<Type>(List<T> items)
        {
            return items.Select(i => _mapper.Map<Type>(i)).ToList();
        }
    }
}
