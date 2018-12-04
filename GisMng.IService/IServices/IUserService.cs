using GisMng.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GisMng.IService.IServices
{
    /// <summary>
    /// 功能描述    ：IUserService  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/12/4 14:21:37 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/12/4 14:21:37 
    /// </summary>
    public interface IUserService
    {
        List<User> GetAllUser();
        User GetUserById(int id);
        User GetUserByName(string name);
    }
}
