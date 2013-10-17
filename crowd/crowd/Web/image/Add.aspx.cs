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
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Crowd.Web.image
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtsmallImg.Text.Trim().Length==0)
			{
				strErr+="smallImg不能为空！\\n";	
			}
			if(this.txtbigImg.Text.Trim().Length==0)
			{
				strErr+="bigImg不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtpublishID.Text))
			{
				strErr+="publishID格式错误！\\n";	
			}
			if(this.txtmiddleImg.Text.Trim().Length==0)
			{
				strErr+="middleImg不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtphotoID.Text))
			{
				strErr+="photoID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string smallImg=this.txtsmallImg.Text;
			string bigImg=this.txtbigImg.Text;
			int publishID=int.Parse(this.txtpublishID.Text);
			string middleImg=this.txtmiddleImg.Text;
			int photoID=int.Parse(this.txtphotoID.Text);

			Crowd.Model.image model=new Crowd.Model.image();
			model.smallImg=smallImg;
			model.bigImg=bigImg;
			model.publishID=publishID;
			model.middleImg=middleImg;
			model.photoID=photoID;

			Crowd.BLL.image bll=new Crowd.BLL.image();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
