using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Crowd.DAL
{
	/// <summary>
	/// 数据访问类:user
	/// </summary>
	public partial class user
	{
		public user()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "user"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from user");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Crowd.Model.user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into user(");
			strSql.Append("userID,userName,userPwd,userEmail,birthday,sex,Gschool,Dschool,company,describe,location,profession)");
			strSql.Append(" values (");
			strSql.Append("@userID,@userName,@userPwd,@userEmail,@birthday,@sex,@Gschool,@Dschool,@company,@describe,@location,@profession)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,50),
					new SqlParameter("@userPwd", SqlDbType.VarChar,50),
					new SqlParameter("@userEmail", SqlDbType.VarChar,100),
					new SqlParameter("@birthday", SqlDbType.DateTime),
					new SqlParameter("@sex", SqlDbType.Bit,1),
					new SqlParameter("@Gschool", SqlDbType.NVarChar,50),
					new SqlParameter("@Dschool", SqlDbType.NVarChar,50),
					new SqlParameter("@company", SqlDbType.NVarChar,50),
					new SqlParameter("@describe", SqlDbType.NVarChar,500),
					new SqlParameter("@location", SqlDbType.NVarChar,500),
					new SqlParameter("@profession", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.userID;
			parameters[1].Value = model.userName;
			parameters[2].Value = model.userPwd;
			parameters[3].Value = model.userEmail;
			parameters[4].Value = model.birthday;
			parameters[5].Value = model.sex;
			parameters[6].Value = model.Gschool;
			parameters[7].Value = model.Dschool;
			parameters[8].Value = model.company;
			parameters[9].Value = model.describe;
			parameters[10].Value = model.location;
			parameters[11].Value = model.profession;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Crowd.Model.user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update user set ");
			strSql.Append("userID=@userID,");
			strSql.Append("userName=@userName,");
			strSql.Append("userPwd=@userPwd,");
			strSql.Append("userEmail=@userEmail,");
			strSql.Append("birthday=@birthday,");
			strSql.Append("sex=@sex,");
			strSql.Append("Gschool=@Gschool,");
			strSql.Append("Dschool=@Dschool,");
			strSql.Append("company=@company,");
			strSql.Append("describe=@describe,");
			strSql.Append("location=@location,");
			strSql.Append("profession=@profession");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,50),
					new SqlParameter("@userPwd", SqlDbType.VarChar,50),
					new SqlParameter("@userEmail", SqlDbType.VarChar,100),
					new SqlParameter("@birthday", SqlDbType.DateTime),
					new SqlParameter("@sex", SqlDbType.Bit,1),
					new SqlParameter("@Gschool", SqlDbType.NVarChar,50),
					new SqlParameter("@Dschool", SqlDbType.NVarChar,50),
					new SqlParameter("@company", SqlDbType.NVarChar,50),
					new SqlParameter("@describe", SqlDbType.NVarChar,500),
					new SqlParameter("@location", SqlDbType.NVarChar,500),
					new SqlParameter("@profession", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.userID;
			parameters[1].Value = model.userName;
			parameters[2].Value = model.userPwd;
			parameters[3].Value = model.userEmail;
			parameters[4].Value = model.birthday;
			parameters[5].Value = model.sex;
			parameters[6].Value = model.Gschool;
			parameters[7].Value = model.Dschool;
			parameters[8].Value = model.company;
			parameters[9].Value = model.describe;
			parameters[10].Value = model.location;
			parameters[11].Value = model.profession;
			parameters[12].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from user ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from user ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Crowd.Model.user GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,userID,userName,userPwd,userEmail,birthday,sex,Gschool,Dschool,company,describe,location,profession from user ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			Crowd.Model.user model=new Crowd.Model.user();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userID"]!=null && ds.Tables[0].Rows[0]["userID"].ToString()!="")
				{
					model.userID=int.Parse(ds.Tables[0].Rows[0]["userID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userName"]!=null && ds.Tables[0].Rows[0]["userName"].ToString()!="")
				{
					model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["userPwd"]!=null && ds.Tables[0].Rows[0]["userPwd"].ToString()!="")
				{
					model.userPwd=ds.Tables[0].Rows[0]["userPwd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["userEmail"]!=null && ds.Tables[0].Rows[0]["userEmail"].ToString()!="")
				{
					model.userEmail=ds.Tables[0].Rows[0]["userEmail"].ToString();
				}
				if(ds.Tables[0].Rows[0]["birthday"]!=null && ds.Tables[0].Rows[0]["birthday"].ToString()!="")
				{
					model.birthday=DateTime.Parse(ds.Tables[0].Rows[0]["birthday"].ToString());
				}
				if(ds.Tables[0].Rows[0]["sex"]!=null && ds.Tables[0].Rows[0]["sex"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["sex"].ToString()=="1")||(ds.Tables[0].Rows[0]["sex"].ToString().ToLower()=="true"))
					{
						model.sex=true;
					}
					else
					{
						model.sex=false;
					}
				}
				if(ds.Tables[0].Rows[0]["Gschool"]!=null && ds.Tables[0].Rows[0]["Gschool"].ToString()!="")
				{
					model.Gschool=ds.Tables[0].Rows[0]["Gschool"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Dschool"]!=null && ds.Tables[0].Rows[0]["Dschool"].ToString()!="")
				{
					model.Dschool=ds.Tables[0].Rows[0]["Dschool"].ToString();
				}
				if(ds.Tables[0].Rows[0]["company"]!=null && ds.Tables[0].Rows[0]["company"].ToString()!="")
				{
					model.company=ds.Tables[0].Rows[0]["company"].ToString();
				}
				if(ds.Tables[0].Rows[0]["describe"]!=null && ds.Tables[0].Rows[0]["describe"].ToString()!="")
				{
					model.describe=ds.Tables[0].Rows[0]["describe"].ToString();
				}
				if(ds.Tables[0].Rows[0]["location"]!=null && ds.Tables[0].Rows[0]["location"].ToString()!="")
				{
					model.location=ds.Tables[0].Rows[0]["location"].ToString();
				}
				if(ds.Tables[0].Rows[0]["profession"]!=null && ds.Tables[0].Rows[0]["profession"].ToString()!="")
				{
					model.profession=ds.Tables[0].Rows[0]["profession"].ToString();
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,userID,userName,userPwd,userEmail,birthday,sex,Gschool,Dschool,company,describe,location,profession ");
			strSql.Append(" FROM user ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,userID,userName,userPwd,userEmail,birthday,sex,Gschool,Dschool,company,describe,location,profession ");
			strSql.Append(" FROM user ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "user";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

