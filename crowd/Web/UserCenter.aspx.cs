using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Data;


 
namespace Crowd.web
{
    public partial class UserCenter : System.Web.UI.Page
    {
        private int uid;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            uid = Convert.ToInt32(Request.QueryString["uid"]);
            //uid=Convert.ToInt32(Session["uid"].ToString());
            BLL.userinfo blluser=new BLL.userinfo();
            Model.userinfo user=blluser.GetModel(uid);
            txtusername.Text = user.userName;
            if (user.headImg==null)
            {
                userhead.Style["background-image"]="../images/UserCenter/publishbg.png";
                return;
            }
            BLL.image bllimage = new BLL.image();
            Model.image headimg = bllimage.GetModel(Convert.ToInt32(user.headImg.ToString()));
            userhead.Style["background-image"]=headimg.smallImg;


            
            
            
        }

    }
}