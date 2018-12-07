using GisMng.Common.Helpers;
using GisMng.IService.IServices;
using GisMng.Models.ModelDto;
using GisMng.Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GisMng.Service.Services
{
    /// <summary>
    /// 功能描述    ：线路容量服务  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/12/4 13:34:52 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/12/4 13:34:52 
    /// </summary>
    public class LineCapacityService : ILineCapacityService
    {
        public async Task<IEnumerable<LineCapacityDto>> GetAllAsync()
        {
            return await SqliteHelper.GetAllAsync<LineCapacityDto>();
        }
    }
}
