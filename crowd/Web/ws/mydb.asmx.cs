using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Crowd.Web.ws
{
    /// <summary>
    /// WebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
     [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string selectUserID(int uid)
        {
            BLL.userinfo blluser = new BLL.userinfo();
            List<Model.userinfo> users = blluser.GetModelList("userID='" + uid + "'");
            if (users.Count == 0)
            {
                return "用户名可用";

            }
            else
            {
                return "用户名已存在";
            
            }


            
        }


    }
}
