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
        string userID = "";
        string userPwd = "";
        string userPwd2 = "";
        string useremail = "";
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void loginbtn_Click(object sender, EventArgs e)
        {


            userID = regidInput.Value;
            userPwd = loginpwdInput1.Value;
            BLL.userinfo blluser = new BLL.userinfo();

           
            List<Model.userinfo> users = blluser.GetModelList("userID='"+userID+"'");
            if (userID=="")
            {
                tipregid.Text = "请输入用户名";
                return;
            }
            if (userPwd == "")
            {
                tippwd.Text = "请输入密码";
                return;
            }
            if (users.Count == 0)
            {
                tipid.Text = "用户名不存在";
                return;
            }
            if (users[0].userPwd!=userPwd)
            {
                tippwd.Text = "密码错误";
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
            userID = loginidInput1.Value;
            userPwd = loginpwdInput1.Value;
            userPwd2 = regpwdInput2.Value;
            useremail = regemailInput.Value;

            if (userID == "")
            {
                tipregid.Text = "请输入用户名";
                return;
            }
            if (userPwd == "")
            {
                tippwd.Text = "请输入密码";
                return;
            }
            if (userPwd2 == "")
            {
                tippwd2.Text = "请输入重复密码";
                return;
            }
            if (useremail=="")
            {
                tipemail.Text = "请输入邮箱";
                return;
            }
            



        }


    }
}