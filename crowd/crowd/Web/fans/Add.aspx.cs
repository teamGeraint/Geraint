﻿using System;
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
namespace Crowd.Web.fans
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
			if(!PageValidate.IsNumber(txtfansID.Text))
			{
				strErr+="fansID格式错误！\\n";	
			}
			if(this.txtremarkName.Text.Trim().Length==0)
			{
				strErr+="remarkName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int userID=int.Parse(this.txtuserID.Text);
			int fansID=int.Parse(this.txtfansID.Text);
			string remarkName=this.txtremarkName.Text;
			bool Sfocus=this.chkSfocus.Checked;

			Crowd.Model.fans model=new Crowd.Model.fans();
			model.userID=userID;
			model.fansID=fansID;
			model.remarkName=remarkName;
			model.Sfocus=Sfocus;

			Crowd.BLL.fans bll=new Crowd.BLL.fans();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
