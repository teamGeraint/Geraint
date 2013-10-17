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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string message=this.txtmessage.Text;
			int receiveID=int.Parse(this.txtreceiveID.Text);
			int sendID=int.Parse(this.txtsendID.Text);

			Crowd.Model.messageInfo model=new Crowd.Model.messageInfo();
			model.message=message;
			model.receiveID=receiveID;
			model.sendID=sendID;

			Crowd.BLL.messageInfo bll=new Crowd.BLL.messageInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
