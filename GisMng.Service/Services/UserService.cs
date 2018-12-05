using GisMng.Common.Helpers;
using GisMng.IService.IServices;
using GisMng.Models.ModelDto;
using GisMng.Models.Models;
using System.Collections.Generic;

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
        public List<UserDto> GetAllUser()
        {
            return SqliteHelper.QueryAll<UserDto>("select * from User");
        }

        public UserDto GetUserById(int id)
        {
            return SqliteHelper.Query<UserDto>(string.Format("select * from User where id={0}", id));
        }

        public UserDto GetUserByName(string name)
        {
            return SqliteHelper.Query<UserDto>(string.Format("select * from User where name={0}", name));
        }
    }
}
