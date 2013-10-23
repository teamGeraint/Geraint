using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crowd.Web
{
    public partial class uspb : System.Web.UI.UserControl
    {
        private int _publishID;

        public int PublishID
        {
            get { return _publishID; }
            set { _publishID = value; }
        }
        private string _txtpublish;

        public string Txtpublish
        {
            get { return _txtpublish; }
            set { _txtpublish = value; }
        }
 
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.publish bllpublish = new BLL.publish();
            Model.publish publish = bllpublish.GetModel(_publishID);
            txtcnt.Text = publish.text;

            BLL.userinfo blluser=new BLL.userinfo();
            List<Model.userinfo> users=blluser.GetModelList("id='"+publish.userID+"'");
            txtfdname.Text = users[0].userName;
            
            if (users[0].headImg==null)
            {
                fdhead.ImageUrl = "images/default.jpg";
            }
            


            BLL.image bllimage=new BLL.image();
            List<Model.image> images=bllimage.GetModelList("publishID='"+publish.id+"'");
            if (images.Count==0)
            {
                imgcnt.Visible = false;
                return;
            }
            imgcnt.ImageUrl = images[0].smallImg;
            


            
        }
    }
}