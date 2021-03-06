﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GisMng.Api.Common;
using GisMng.IService.IServices;
using GisMng.Models.ModelDto;
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
        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        // GET api/values
        [HttpGet("GetAllUser")]
        public Task<IEnumerable<UserDto>> GetAllUser()
        {
            return _userService.GetAllUser();
        }
        /// <summary>
        /// 根据id获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/values/5
        [HttpGet("GetUserById")]
        public Task<UserDto> GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }
        /// <summary>
        /// 根据用户名获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/values/5
        [HttpGet("GetUserByName")]
        public Task<UserDto> GetUserByName(string name)
        {
            return _userService.GetUserByName(name);
        }
    }
}
