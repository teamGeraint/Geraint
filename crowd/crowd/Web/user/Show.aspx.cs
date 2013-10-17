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
namespace Crowd.Web.user
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
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		Crowd.BLL.user bll=new Crowd.BLL.user();
		Crowd.Model.user model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lbluserID.Text=model.userID.ToString();
		this.lbluserName.Text=model.userName;
		this.lbluserPwd.Text=model.userPwd;
		this.lbluserEmail.Text=model.userEmail;
		this.lblbirthday.Text=model.birthday.ToString();
		this.lblsex.Text=model.sex?"是":"否";
		this.lblGschool.Text=model.Gschool;
		this.lblDschool.Text=model.Dschool;
		this.lblcompany.Text=model.company;
		this.lbldescribe.Text=model.describe;
		this.lbllocation.Text=model.location;
		this.lblprofession.Text=model.profession;

	}


    }
}
