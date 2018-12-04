using GisMng.Common.Helpers;
using GisMng.IService.IServices;
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
        public List<User> GetAllUser()
        {
            return SqliteHelper.QueryAll<User>("select * from User");
        }

        public User GetUserById(int id)
        {
            return SqliteHelper.Query<User>(string.Format("select * from User where id={0}", id));
        }

        public User GetUserByName(string name)
        {
            return SqliteHelper.Query<User>(string.Format("select * from User where name={0}", name));
        }
    }
}
