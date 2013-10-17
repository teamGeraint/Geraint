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
namespace Crowd.Web.commentInfo
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
		Crowd.BLL.commentInfo bll=new Crowd.BLL.commentInfo();
		Crowd.Model.commentInfo model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblpublishID.Text=model.publishID.ToString();
		this.lbluserID.Text=model.userID.ToString();
		this.lblcomment.Text=model.comment;
		this.lblparentID.Text=model.parentID.ToString();

	}


    }
}
