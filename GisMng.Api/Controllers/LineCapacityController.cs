using GisMng.Api.Common;
using GisMng.IService.IServices;
using GisMng.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GisMng.Api.Controllers
{
    public class LineCapacityController : WebApiControllerBase
    {
        ILineCapacityService _lineCapacityService;
        public LineCapacityController(ILineCapacityService lineCapacityService)
        {
            _lineCapacityService = lineCapacityService;
        }
        /// <summary>
        /// 获取所有线路容量数据
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public List<LineCapacity> GetAll()
        {
            return _lineCapacityService.GetAll();
        }
    }
}