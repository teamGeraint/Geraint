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
namespace Crowd.Web.messageInfo
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
		Crowd.BLL.messageInfo bll=new Crowd.BLL.messageInfo();
		Crowd.Model.messageInfo model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtmessage.Text=model.message;
		this.txtreceiveID.Text=model.receiveID.ToString();
		this.txtsendID.Text=model.sendID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtmessage.Text.Trim().Length==0)
			{
				strErr+="message不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtreceiveID.Text))
			{
				strErr+="receiveID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsendID.Text))
			{
				strErr+="sendID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string message=this.txtmessage.Text;
			int receiveID=int.Parse(this.txtreceiveID.Text);
			int sendID=int.Parse(this.txtsendID.Text);


			Crowd.Model.messageInfo model=new Crowd.Model.messageInfo();
			model.id=id;
			model.message=message;
			model.receiveID=receiveID;
			model.sendID=sendID;

			Crowd.BLL.messageInfo bll=new Crowd.BLL.messageInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
