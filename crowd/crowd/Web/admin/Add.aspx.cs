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
namespace Crowd.Web.admin
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtadminID.Text.Trim().Length==0)
			{
				strErr+="adminID不能为空！\\n";	
			}
			if(this.txtadminName.Text.Trim().Length==0)
			{
				strErr+="adminName不能为空！\\n";	
			}
			if(this.txtadminPwd.Text.Trim().Length==0)
			{
				strErr+="adminPwd不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string adminID=this.txtadminID.Text;
			string adminName=this.txtadminName.Text;
			string adminPwd=this.txtadminPwd.Text;
			bool creatAdmin=this.chkcreatAdmin.Checked;
			bool deleteAdmin=this.chkdeleteAdmin.Checked;
			bool ban=this.chkban.Checked;
			bool postInfo=this.chkpostInfo.Checked;
			bool see=this.chksee.Checked;
			bool updateV=this.chkupdateV.Checked;

			Crowd.Model.admin model=new Crowd.Model.admin();
			model.adminID=adminID;
			model.adminName=adminName;
			model.adminPwd=adminPwd;
			model.creatAdmin=creatAdmin;
			model.deleteAdmin=deleteAdmin;
			model.ban=ban;
			model.postInfo=postInfo;
			model.see=see;
			model.updateV=updateV;

			Crowd.BLL.admin bll=new Crowd.BLL.admin();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
