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
namespace Crowd.Web.commentInfo
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
		Crowd.BLL.commentInfo bll=new Crowd.BLL.commentInfo();
		Crowd.Model.commentInfo model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtpublishID.Text=model.publishID.ToString();
		this.txtuserID.Text=model.userID.ToString();
		this.txtcomment.Text=model.comment;
		this.txtparentID.Text=model.parentID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtpublishID.Text))
			{
				strErr+="publishID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtuserID.Text))
			{
				strErr+="userID格式错误！\\n";	
			}
			if(this.txtcomment.Text.Trim().Length==0)
			{
				strErr+="comment不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtparentID.Text))
			{
				strErr+="parentID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int publishID=int.Parse(this.txtpublishID.Text);
			int userID=int.Parse(this.txtuserID.Text);
			string comment=this.txtcomment.Text;
			int parentID=int.Parse(this.txtparentID.Text);


			Crowd.Model.commentInfo model=new Crowd.Model.commentInfo();
			model.id=id;
			model.publishID=publishID;
			model.userID=userID;
			model.comment=comment;
			model.parentID=parentID;

			Crowd.BLL.commentInfo bll=new Crowd.BLL.commentInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
