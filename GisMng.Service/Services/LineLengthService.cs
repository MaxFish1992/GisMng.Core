using GisMng.Common.Helpers;
using GisMng.IService.IServices;
using GisMng.Models.ModelDto;
using GisMng.Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GisMng.Service.Services
{
    /// <summary>
    /// 功能描述    ：线路长度服务  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/12/4 13:41:18 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/12/4 13:41:18 
    /// </summary>
    public class LineLengthService : ILineLengthService
    {
        public async Task<IEnumerable<LineLengthDto>> GetAllAsync()
        {
            return await SqliteHelper.GetAllAsync<LineLengthDto>();
        }
    }
}
