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
namespace Crowd.Web.user
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
		Crowd.BLL.user bll=new Crowd.BLL.user();
		Crowd.Model.user model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtuserID.Text=model.userID.ToString();
		this.txtuserName.Text=model.userName;
		this.txtuserPwd.Text=model.userPwd;
		this.txtuserEmail.Text=model.userEmail;
		this.txtbirthday.Text=model.birthday.ToString();
		this.chksex.Checked=model.sex;
		this.txtGschool.Text=model.Gschool;
		this.txtDschool.Text=model.Dschool;
		this.txtcompany.Text=model.company;
		this.txtdescribe.Text=model.describe;
		this.txtlocation.Text=model.location;
		this.txtprofession.Text=model.profession;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtuserID.Text))
			{
				strErr+="userID格式错误！\\n";	
			}
			if(this.txtuserName.Text.Trim().Length==0)
			{
				strErr+="userName不能为空！\\n";	
			}
			if(this.txtuserPwd.Text.Trim().Length==0)
			{
				strErr+="userPwd不能为空！\\n";	
			}
			if(this.txtuserEmail.Text.Trim().Length==0)
			{
				strErr+="userEmail不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtbirthday.Text))
			{
				strErr+="birthday格式错误！\\n";	
			}
			if(this.txtGschool.Text.Trim().Length==0)
			{
				strErr+="Gschool不能为空！\\n";	
			}
			if(this.txtDschool.Text.Trim().Length==0)
			{
				strErr+="Dschool不能为空！\\n";	
			}
			if(this.txtcompany.Text.Trim().Length==0)
			{
				strErr+="company不能为空！\\n";	
			}
			if(this.txtdescribe.Text.Trim().Length==0)
			{
				strErr+="describe不能为空！\\n";	
			}
			if(this.txtlocation.Text.Trim().Length==0)
			{
				strErr+="location不能为空！\\n";	
			}
			if(this.txtprofession.Text.Trim().Length==0)
			{
				strErr+="profession不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int userID=int.Parse(this.txtuserID.Text);
			string userName=this.txtuserName.Text;
			string userPwd=this.txtuserPwd.Text;
			string userEmail=this.txtuserEmail.Text;
			DateTime birthday=DateTime.Parse(this.txtbirthday.Text);
			bool sex=this.chksex.Checked;
			string Gschool=this.txtGschool.Text;
			string Dschool=this.txtDschool.Text;
			string company=this.txtcompany.Text;
			string describe=this.txtdescribe.Text;
			string location=this.txtlocation.Text;
			string profession=this.txtprofession.Text;


			Crowd.Model.user model=new Crowd.Model.user();
			model.id=id;
			model.userID=userID;
			model.userName=userName;
			model.userPwd=userPwd;
			model.userEmail=userEmail;
			model.birthday=birthday;
			model.sex=sex;
			model.Gschool=Gschool;
			model.Dschool=Dschool;
			model.company=company;
			model.describe=describe;
			model.location=location;
			model.profession=profession;

			Crowd.BLL.user bll=new Crowd.BLL.user();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
