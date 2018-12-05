using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace GisMng.Api.Common
{
    [Route("api/[controller]")]
    [EnableCors("AllowDomain")]
    [ApiController]
    public class WebApiControllerBase : ControllerBase
    {
        /// <summary>
        /// 会话
        /// </summary>
        //public virtual ISession Session => Security.Sessions.Session.Instance;

        /// <summary>
        /// 返回成功消息
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="message">消息</param>
        protected virtual IActionResult Success(object data = null, string message = null)
        {
            if (message == null)
                message = "Success";
            return new Result(StateCode.Ok, message, data);
        }
    }
}
