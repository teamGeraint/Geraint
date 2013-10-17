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
namespace Crowd.Web.photo
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
			if(this.txtphotoName.Text.Trim().Length==0)
			{
				strErr+="photoName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtphotoClass.Text))
			{
				strErr+="photoClass格式错误！\\n";	
			}
			if(this.txtphotoDesc.Text.Trim().Length==0)
			{
				strErr+="photoDesc不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int userID=int.Parse(this.txtuserID.Text);
			string photoName=this.txtphotoName.Text;
			int photoClass=int.Parse(this.txtphotoClass.Text);
			string photoDesc=this.txtphotoDesc.Text;

			Crowd.Model.photo model=new Crowd.Model.photo();
			model.userID=userID;
			model.photoName=photoName;
			model.photoClass=photoClass;
			model.photoDesc=photoDesc;

			Crowd.BLL.photo bll=new Crowd.BLL.photo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
