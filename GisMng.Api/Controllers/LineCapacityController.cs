﻿using GisMng.Api.Common;
using GisMng.IService.IServices;
using GisMng.Models.ModelDto;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<LineCapacityDto>> GetAll()
        {
            //log.Info("获取所有线路容量数据");
            return await _lineCapacityService.GetAllAsync();
        }
    }
}