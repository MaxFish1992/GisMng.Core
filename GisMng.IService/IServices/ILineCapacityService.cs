using GisMng.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GisMng.IService.IServices
{
    /// <summary>
    /// 功能描述    ：ILineCapacityService  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/12/4 14:17:03 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/12/4 14:17:03 
    /// </summary>
    public interface ILineCapacityService
    {
        List<LineCapacity> GetAll();
    }
}
