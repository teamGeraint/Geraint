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
namespace Crowd.Web.DICT_interest
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
		Crowd.BLL.DICT_interest bll=new Crowd.BLL.DICT_interest();
		Crowd.Model.DICT_interest model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtinsterestName.Text=model.insterestName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtinsterestName.Text.Trim().Length==0)
			{
				strErr+="insterestName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string insterestName=this.txtinsterestName.Text;


			Crowd.Model.DICT_interest model=new Crowd.Model.DICT_interest();
			model.id=id;
			model.insterestName=insterestName;

			Crowd.BLL.DICT_interest bll=new Crowd.BLL.DICT_interest();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
