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
namespace Crowd.Web.report
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			if(!PageValidate.IsNumber(txtreportID.Text))
			{
				strErr+="reportID格式错误！\\n";	
			}
			if(this.txtreportText.Text.Trim().Length==0)
			{
				strErr+="reportText不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int userID=int.Parse(this.txtuserID.Text);
			int publishID=int.Parse(this.txtpublishID.Text);
			int reportID=int.Parse(this.txtreportID.Text);
			string reportText=this.txtreportText.Text;

			Crowd.Model.report model=new Crowd.Model.report();
			model.userID=userID;
			model.publishID=publishID;
			model.reportID=reportID;
			model.reportText=reportText;

			Crowd.BLL.report bll=new Crowd.BLL.report();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
