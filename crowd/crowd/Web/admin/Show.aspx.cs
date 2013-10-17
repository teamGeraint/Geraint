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
namespace Crowd.Web.admin
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string adminID= strid;
					ShowInfo(adminID);
				}
			}
		}
		
	private void ShowInfo(string adminID)
	{
		Crowd.BLL.admin bll=new Crowd.BLL.admin();
		Crowd.Model.admin model=bll.GetModel(adminID);
		this.lbladminID.Text=model.adminID;
		this.lbladminName.Text=model.adminName;
		this.lbladminPwd.Text=model.adminPwd;
		this.lblcreatAdmin.Text=model.creatAdmin?"是":"否";
		this.lbldeleteAdmin.Text=model.deleteAdmin?"是":"否";
		this.lblban.Text=model.ban?"是":"否";
		this.lblpostInfo.Text=model.postInfo?"是":"否";
		this.lblsee.Text=model.see?"是":"否";
		this.lblupdateV.Text=model.updateV?"是":"否";

	}


    }
}
