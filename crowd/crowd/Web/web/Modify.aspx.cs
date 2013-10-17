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
namespace Crowd.Web.web
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
		Crowd.BLL.web bll=new Crowd.BLL.web();
		Crowd.Model.web model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtwebName.Text=model.webName;
		this.txtAuthor.Text=model.Author;
		this.txtversion.Text=model.version;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtwebName.Text.Trim().Length==0)
			{
				strErr+="webName不能为空！\\n";	
			}
			if(this.txtAuthor.Text.Trim().Length==0)
			{
				strErr+="Author不能为空！\\n";	
			}
			if(this.txtversion.Text.Trim().Length==0)
			{
				strErr+="version不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string webName=this.txtwebName.Text;
			string Author=this.txtAuthor.Text;
			string version=this.txtversion.Text;


			Crowd.Model.web model=new Crowd.Model.web();
			model.id=id;
			model.webName=webName;
			model.Author=Author;
			model.version=version;

			Crowd.BLL.web bll=new Crowd.BLL.web();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
