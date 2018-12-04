using System;
using System.Collections.Generic;
using System.Text;

namespace GisMng.Models.Models
{
    /// <summary>
    /// 功能描述    ：User  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/12/4 13:39:09 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/12/4 13:39:09 
    /// </summary>
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
