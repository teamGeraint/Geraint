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
namespace Crowd.Web.DICT_photoClass
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
		Crowd.BLL.DICT_photoClass bll=new Crowd.BLL.DICT_photoClass();
		Crowd.Model.DICT_photoClass model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtclasssName.Text=model.classsName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtclasssName.Text.Trim().Length==0)
			{
				strErr+="classsName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string classsName=this.txtclasssName.Text;


			Crowd.Model.DICT_photoClass model=new Crowd.Model.DICT_photoClass();
			model.id=id;
			model.classsName=classsName;

			Crowd.BLL.DICT_photoClass bll=new Crowd.BLL.DICT_photoClass();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
