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
namespace Crowd.Web.image
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
		Crowd.BLL.image bll=new Crowd.BLL.image();
		Crowd.Model.image model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblsmallImg.Text=model.smallImg;
		this.lblbigImg.Text=model.bigImg;
		this.lblpublishID.Text=model.publishID.ToString();
		this.lblmiddleImg.Text=model.middleImg;
		this.lblphotoID.Text=model.photoID.ToString();

	}


    }
}
