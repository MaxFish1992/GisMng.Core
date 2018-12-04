using System;
using System.Collections.Generic;
using System.Text;

namespace GisMng.Models.Models
{
    /// <summary>
    /// 功能描述    ：LineCapacity  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/12/4 13:39:49 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/12/4 13:39:49 
    /// </summary>
    public class LineCapacity : BaseModel
    {
        public int Year { get; set; }
        public string Capacity { get; set; }
        public string Unit { get; set; }
    }
}
