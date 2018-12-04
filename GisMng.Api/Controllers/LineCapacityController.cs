using GisMng.Api.Common;
using GisMng.Common.Helpers;
using GisMng.IService.IServices;
using GisMng.Models.Models;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GisMng.Api.Controllers
{
    public class LineCapacityController : WebApiControllerBase
    {
        ILog log;
        ILineCapacityService _lineCapacityService;
        public LineCapacityController(ILineCapacityService lineCapacityService)
        {
            _lineCapacityService = lineCapacityService;

            this.log = LogManager.GetLogger(Startup.repository.Name, typeof(LineCapacityController));
        }
        /// <summary>
        /// 获取所有线路容量数据
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public List<LineCapacity> GetAll()
        {
            log.Info("获取所有线路容量数据");
            return _lineCapacityService.GetAll();
        }
    }
}