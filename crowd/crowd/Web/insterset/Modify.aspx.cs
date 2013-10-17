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
namespace Crowd.Web.insterset
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
		Crowd.BLL.insterset bll=new Crowd.BLL.insterset();
		Crowd.Model.insterset model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtinterestID.Text=model.interestID.ToString();
		this.txtuserID.Text=model.userID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtinterestID.Text))
			{
				strErr+="interestID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtuserID.Text))
			{
				strErr+="userID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int interestID=int.Parse(this.txtinterestID.Text);
			int userID=int.Parse(this.txtuserID.Text);


			Crowd.Model.insterset model=new Crowd.Model.insterset();
			model.id=id;
			model.interestID=interestID;
			model.userID=userID;

			Crowd.BLL.insterset bll=new Crowd.BLL.insterset();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
