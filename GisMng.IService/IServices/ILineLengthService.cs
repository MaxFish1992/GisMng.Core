using GisMng.Models.ModelDto;
using GisMng.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GisMng.IService.IServices
{
    /// <summary>
    /// 功能描述    ：ILineLengthService  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/12/4 14:19:41 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/12/4 14:19:41 
    /// </summary>
    public interface ILineLengthService
    {
        Task<IEnumerable<LineLengthDto>> GetAllAsync();
    }
}
