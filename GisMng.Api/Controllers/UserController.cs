using System.Collections.Generic;
using GisMng.Api.Common;
using GisMng.IService.IServices;
using GisMng.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace GisMng.Api.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class UserController : WebApiControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET api/values
        [HttpGet("GetAllUser")]
        public List<User> GetAllUser()
        {
            return _userService.GetAllUser();
        }

        // GET api/values/5
        [HttpGet("GetUserById")]
        public User GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }
    }
}
