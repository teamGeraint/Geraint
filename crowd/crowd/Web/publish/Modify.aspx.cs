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
namespace Crowd.Web.publish
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
		Crowd.BLL.publish bll=new Crowd.BLL.publish();
		Crowd.Model.publish model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtuserID.Text=model.userID.ToString();
		this.txttext.Text=model.text;
		this.txtvideo.Text=model.video;
		this.txtmusic.Text=model.music;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtuserID.Text))
			{
				strErr+="userID格式错误！\\n";	
			}
			if(this.txttext.Text.Trim().Length==0)
			{
				strErr+="text不能为空！\\n";	
			}
			if(this.txtvideo.Text.Trim().Length==0)
			{
				strErr+="video不能为空！\\n";	
			}
			if(this.txtmusic.Text.Trim().Length==0)
			{
				strErr+="music不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int userID=int.Parse(this.txtuserID.Text);
			string text=this.txttext.Text;
			string video=this.txtvideo.Text;
			string music=this.txtmusic.Text;


			Crowd.Model.publish model=new Crowd.Model.publish();
			model.id=id;
			model.userID=userID;
			model.text=text;
			model.video=video;
			model.music=music;

			Crowd.BLL.publish bll=new Crowd.BLL.publish();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
