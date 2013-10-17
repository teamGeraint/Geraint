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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		Crowd.BLL.image bll=new Crowd.BLL.image();
		Crowd.Model.image model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtsmallImg.Text=model.smallImg;
		this.txtbigImg.Text=model.bigImg;
		this.txtpublishID.Text=model.publishID.ToString();
		this.txtmiddleImg.Text=model.middleImg;
		this.txtphotoID.Text=model.photoID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int id=int.Parse(this.lblid.Text);
			string smallImg=this.txtsmallImg.Text;
			string bigImg=this.txtbigImg.Text;
			int publishID=int.Parse(this.txtpublishID.Text);
			string middleImg=this.txtmiddleImg.Text;
			int photoID=int.Parse(this.txtphotoID.Text);


			Crowd.Model.image model=new Crowd.Model.image();
			model.id=id;
			model.smallImg=smallImg;
			model.bigImg=bigImg;
			model.publishID=publishID;
			model.middleImg=middleImg;
			model.photoID=photoID;

			Crowd.BLL.image bll=new Crowd.BLL.image();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
