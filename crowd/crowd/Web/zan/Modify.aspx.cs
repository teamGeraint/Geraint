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
namespace Crowd.Web.zan
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
		Crowd.BLL.zan bll=new Crowd.BLL.zan();
		Crowd.Model.zan model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtuserID.Text=model.userID.ToString();
		this.txtpublishID.Text=model.publishID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtuserID.Text))
			{
				strErr+="userID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpublishID.Text))
			{
				strErr+="publishID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int userID=int.Parse(this.txtuserID.Text);
			int publishID=int.Parse(this.txtpublishID.Text);


			Crowd.Model.zan model=new Crowd.Model.zan();
			model.id=id;
			model.userID=userID;
			model.publishID=publishID;

			Crowd.BLL.zan bll=new Crowd.BLL.zan();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
