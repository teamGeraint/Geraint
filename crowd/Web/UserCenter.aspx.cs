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

            //个人信息
            uid = Convert.ToInt32(Request.QueryString["uid"]);
            //uid=Convert.ToInt32(Session["uid"].ToString());
            BLL.userinfo blluser=new BLL.userinfo();
            Model.userinfo user=blluser.GetModel(uid);
            txtusername.Text = user.userName;
            txtuserdesc.Text = user.describe;
            if (user.headImg == null)
            {
                userhead.Style["background-image"] = "../images/UserCenter/publishbg.png";
                imguserhead.ImageUrl="../images/default.jpg";
            }
            else {
                BLL.image bllimage = new BLL.image();
                Model.image headimg = bllimage.GetModel(Convert.ToInt32(user.headImg.ToString()));
                userhead.Style["background-image"] = headimg.smallImg;
            
            }

            




            
            BLL.fans bllfans = new BLL.fans();
            List<Model.fans> fans = bllfans.GetModelList("userID='" + uid + "'");
            txtguanzhu.Text = fans.Count.ToString();
            
            //好友动态
            foreach (var fan in fans)
            {
                
                BLL.publish bllpublish=new BLL.publish();
                List<Model.publish> publishs = bllpublish.GetModelList("userID='" + fan.fansID + "'");
                foreach (var publish in publishs)
                {
                    Web.uspb ctl = (Web.uspb)Page.LoadControl("uspb.ascx");
                    ctl.PublishID = publish.id;
                    this.pholder.Controls.Add(ctl);
                }
            }

            List<Model.fans> bfans = bllfans.GetModelList("fansID='" + uid + "'");
            txtfans.Text = bfans.Count.ToString();

            BLL.publish blluserpb = new BLL.publish();
            List<Model.publish> userpb = blluserpb.GetModelList("userID='"+uid+"'");
            txtpublsh.Text = userpb.Count.ToString();







        }

    }
}