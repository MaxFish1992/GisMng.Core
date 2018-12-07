using GisMng.Common.Helpers;
using GisMng.IService.IServices;
using GisMng.Models.ModelDto;
using GisMng.Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GisMng.Service.Services
{
    /// <summary>
    /// 功能描述    ：用户服务  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/12/4 13:40:44 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/12/4 13:40:44 
    /// </summary>
    public class UserService : IUserService
    {
        public async Task<IEnumerable<UserDto>> GetAllUser()
        {
            return await SqliteHelper.GetAllAsync<UserDto>();
        }

        public async Task<UserDto> GetUserById(int id)
        {
            return await SqliteHelper.GetAsync<UserDto>(id);
        }

        public async Task<UserDto> GetUserByName(string name)
        {
            return await SqliteHelper.GetAsync<UserDto>(name);
        }
    }
}
