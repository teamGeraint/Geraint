using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

namespace Crowd.web
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            string userID="";
            string userPwd = "";
            
            userID = loginidInput1.Value;
            userPwd = loginpwdInput1.Value;
            BLL.userinfo blluser = new BLL.userinfo();

           
            List<Model.userinfo> users = blluser.GetModelList("userID='"+userID+"' and userPwd='"+userPwd+"'");
            if (users.Count == 0)
            {
                loginError.Text = "用户名或密码错误！";
                return;
            }
            //Session["uid"] = users[0].id;
            //Server.Transfer("UserCenter.aspx");
            string url;
            url="UserCenter.aspx?uid="+users[0].id;
            Response.Redirect(url);

        }

        protected void regbtn_Click(object sender, EventArgs e)
        {


        }


    }
}