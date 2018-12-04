using System.Collections.Generic;
using GisMng.Api.Common;
using GisMng.IService.IServices;
using GisMng.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace GisMng.Api.Controllers
{
    public class LineLengthController : WebApiControllerBase
    {
        ILineLengthService _lineLengthService;
        public LineLengthController(ILineLengthService lineLengthService)
        {
            _lineLengthService = lineLengthService;
        }
        /// <summary>
        /// 获取所有线路长度数据
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public List<LineLength> GetAll()
        {
            return _lineLengthService.GetAll();
        }
    }
}