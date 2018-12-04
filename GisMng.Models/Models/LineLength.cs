using System;
using System.Collections.Generic;
using System.Text;

namespace GisMng.Models.Models
{
    /// <summary>
    /// 功能描述    ：LineLength  
    /// 创 建 者    ：huangwei
    /// 创建日期    ：2018/12/4 13:39:30 
    /// 最后修改者  ：Administrator
    /// 最后修改日期：2018/12/4 13:39:30 
    /// </summary>
    public class LineLength : BaseModel
    {
        public int Year { get; set; }
        public string Length { get; set; }
        public string Unit { get; set; }
    }
}
