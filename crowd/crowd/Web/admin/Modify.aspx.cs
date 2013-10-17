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
namespace Crowd.Web.admin
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string adminID= Request.Params["id"];
					ShowInfo(adminID);
				}
			}
		}
			
	private void ShowInfo(string adminID)
	{
		Crowd.BLL.admin bll=new Crowd.BLL.admin();
		Crowd.Model.admin model=bll.GetModel(adminID);
		this.lbladminID.Text=model.adminID;
		this.txtadminName.Text=model.adminName;
		this.txtadminPwd.Text=model.adminPwd;
		this.chkcreatAdmin.Checked=model.creatAdmin;
		this.chkdeleteAdmin.Checked=model.deleteAdmin;
		this.chkban.Checked=model.ban;
		this.chkpostInfo.Checked=model.postInfo;
		this.chksee.Checked=model.see;
		this.chkupdateV.Checked=model.updateV;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtadminName.Text.Trim().Length==0)
			{
				strErr+="adminName不能为空！\\n";	
			}
			if(this.txtadminPwd.Text.Trim().Length==0)
			{
				strErr+="adminPwd不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string adminID=this.lbladminID.Text;
			string adminName=this.txtadminName.Text;
			string adminPwd=this.txtadminPwd.Text;
			bool creatAdmin=this.chkcreatAdmin.Checked;
			bool deleteAdmin=this.chkdeleteAdmin.Checked;
			bool ban=this.chkban.Checked;
			bool postInfo=this.chkpostInfo.Checked;
			bool see=this.chksee.Checked;
			bool updateV=this.chkupdateV.Checked;


			Crowd.Model.admin model=new Crowd.Model.admin();
			model.adminID=adminID;
			model.adminName=adminName;
			model.adminPwd=adminPwd;
			model.creatAdmin=creatAdmin;
			model.deleteAdmin=deleteAdmin;
			model.ban=ban;
			model.postInfo=postInfo;
			model.see=see;
			model.updateV=updateV;

			Crowd.BLL.admin bll=new Crowd.BLL.admin();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
