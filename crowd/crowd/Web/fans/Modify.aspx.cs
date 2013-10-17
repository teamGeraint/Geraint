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
namespace Crowd.Web.fans
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
		Crowd.BLL.fans bll=new Crowd.BLL.fans();
		Crowd.Model.fans model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtuserID.Text=model.userID.ToString();
		this.txtfansID.Text=model.fansID.ToString();
		this.txtremarkName.Text=model.remarkName;
		this.chkSfocus.Checked=model.Sfocus;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtuserID.Text))
			{
				strErr+="userID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtfansID.Text))
			{
				strErr+="fansID格式错误！\\n";	
			}
			if(this.txtremarkName.Text.Trim().Length==0)
			{
				strErr+="remarkName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int userID=int.Parse(this.txtuserID.Text);
			int fansID=int.Parse(this.txtfansID.Text);
			string remarkName=this.txtremarkName.Text;
			bool Sfocus=this.chkSfocus.Checked;


			Crowd.Model.fans model=new Crowd.Model.fans();
			model.id=id;
			model.userID=userID;
			model.fansID=fansID;
			model.remarkName=remarkName;
			model.Sfocus=Sfocus;

			Crowd.BLL.fans bll=new Crowd.BLL.fans();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
