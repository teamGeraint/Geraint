using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Crowd.DAL
{
	/// <summary>
	/// 数据访问类:admin
	/// </summary>
	public partial class admin
	{
		public admin()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string adminID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from admin");
			strSql.Append(" where adminID=@adminID ");
			SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.VarChar,20)};
			parameters[0].Value = adminID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Crowd.Model.admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into admin(");
			strSql.Append("adminID,adminName,adminPwd,creatAdmin,deleteAdmin,ban,postInfo,see,updateV)");
			strSql.Append(" values (");
			strSql.Append("@adminID,@adminName,@adminPwd,@creatAdmin,@deleteAdmin,@ban,@postInfo,@see,@updateV)");
			SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.VarChar,20),
					new SqlParameter("@adminName", SqlDbType.NVarChar,20),
					new SqlParameter("@adminPwd", SqlDbType.VarChar,20),
					new SqlParameter("@creatAdmin", SqlDbType.Bit,1),
					new SqlParameter("@deleteAdmin", SqlDbType.Bit,1),
					new SqlParameter("@ban", SqlDbType.Bit,1),
					new SqlParameter("@postInfo", SqlDbType.Bit,1),
					new SqlParameter("@see", SqlDbType.Bit,1),
					new SqlParameter("@updateV", SqlDbType.Bit,1)};
			parameters[0].Value = model.adminID;
			parameters[1].Value = model.adminName;
			parameters[2].Value = model.adminPwd;
			parameters[3].Value = model.creatAdmin;
			parameters[4].Value = model.deleteAdmin;
			parameters[5].Value = model.ban;
			parameters[6].Value = model.postInfo;
			parameters[7].Value = model.see;
			parameters[8].Value = model.updateV;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Crowd.Model.admin model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update admin set ");
			strSql.Append("adminName=@adminName,");
			strSql.Append("adminPwd=@adminPwd,");
			strSql.Append("creatAdmin=@creatAdmin,");
			strSql.Append("deleteAdmin=@deleteAdmin,");
			strSql.Append("ban=@ban,");
			strSql.Append("postInfo=@postInfo,");
			strSql.Append("see=@see,");
			strSql.Append("updateV=@updateV");
			strSql.Append(" where adminID=@adminID ");
			SqlParameter[] parameters = {
					new SqlParameter("@adminName", SqlDbType.NVarChar,20),
					new SqlParameter("@adminPwd", SqlDbType.VarChar,20),
					new SqlParameter("@creatAdmin", SqlDbType.Bit,1),
					new SqlParameter("@deleteAdmin", SqlDbType.Bit,1),
					new SqlParameter("@ban", SqlDbType.Bit,1),
					new SqlParameter("@postInfo", SqlDbType.Bit,1),
					new SqlParameter("@see", SqlDbType.Bit,1),
					new SqlParameter("@updateV", SqlDbType.Bit,1),
					new SqlParameter("@adminID", SqlDbType.VarChar,20)};
			parameters[0].Value = model.adminName;
			parameters[1].Value = model.adminPwd;
			parameters[2].Value = model.creatAdmin;
			parameters[3].Value = model.deleteAdmin;
			parameters[4].Value = model.ban;
			parameters[5].Value = model.postInfo;
			parameters[6].Value = model.see;
			parameters[7].Value = model.updateV;
			parameters[8].Value = model.adminID;

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
		public bool Delete(string adminID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from admin ");
			strSql.Append(" where adminID=@adminID ");
			SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.VarChar,20)};
			parameters[0].Value = adminID;

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
		public bool DeleteList(string adminIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from admin ");
			strSql.Append(" where adminID in ("+adminIDlist + ")  ");
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
		public Crowd.Model.admin GetModel(string adminID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 adminID,adminName,adminPwd,creatAdmin,deleteAdmin,ban,postInfo,see,updateV from admin ");
			strSql.Append(" where adminID=@adminID ");
			SqlParameter[] parameters = {
					new SqlParameter("@adminID", SqlDbType.VarChar,20)};
			parameters[0].Value = adminID;

			Crowd.Model.admin model=new Crowd.Model.admin();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["adminID"]!=null && ds.Tables[0].Rows[0]["adminID"].ToString()!="")
				{
					model.adminID=ds.Tables[0].Rows[0]["adminID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["adminName"]!=null && ds.Tables[0].Rows[0]["adminName"].ToString()!="")
				{
					model.adminName=ds.Tables[0].Rows[0]["adminName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["adminPwd"]!=null && ds.Tables[0].Rows[0]["adminPwd"].ToString()!="")
				{
					model.adminPwd=ds.Tables[0].Rows[0]["adminPwd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["creatAdmin"]!=null && ds.Tables[0].Rows[0]["creatAdmin"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["creatAdmin"].ToString()=="1")||(ds.Tables[0].Rows[0]["creatAdmin"].ToString().ToLower()=="true"))
					{
						model.creatAdmin=true;
					}
					else
					{
						model.creatAdmin=false;
					}
				}
				if(ds.Tables[0].Rows[0]["deleteAdmin"]!=null && ds.Tables[0].Rows[0]["deleteAdmin"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["deleteAdmin"].ToString()=="1")||(ds.Tables[0].Rows[0]["deleteAdmin"].ToString().ToLower()=="true"))
					{
						model.deleteAdmin=true;
					}
					else
					{
						model.deleteAdmin=false;
					}
				}
				if(ds.Tables[0].Rows[0]["ban"]!=null && ds.Tables[0].Rows[0]["ban"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["ban"].ToString()=="1")||(ds.Tables[0].Rows[0]["ban"].ToString().ToLower()=="true"))
					{
						model.ban=true;
					}
					else
					{
						model.ban=false;
					}
				}
				if(ds.Tables[0].Rows[0]["postInfo"]!=null && ds.Tables[0].Rows[0]["postInfo"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["postInfo"].ToString()=="1")||(ds.Tables[0].Rows[0]["postInfo"].ToString().ToLower()=="true"))
					{
						model.postInfo=true;
					}
					else
					{
						model.postInfo=false;
					}
				}
				if(ds.Tables[0].Rows[0]["see"]!=null && ds.Tables[0].Rows[0]["see"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["see"].ToString()=="1")||(ds.Tables[0].Rows[0]["see"].ToString().ToLower()=="true"))
					{
						model.see=true;
					}
					else
					{
						model.see=false;
					}
				}
				if(ds.Tables[0].Rows[0]["updateV"]!=null && ds.Tables[0].Rows[0]["updateV"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["updateV"].ToString()=="1")||(ds.Tables[0].Rows[0]["updateV"].ToString().ToLower()=="true"))
					{
						model.updateV=true;
					}
					else
					{
						model.updateV=false;
					}
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
			strSql.Append("select adminID,adminName,adminPwd,creatAdmin,deleteAdmin,ban,postInfo,see,updateV ");
			strSql.Append(" FROM admin ");
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
			strSql.Append(" adminID,adminName,adminPwd,creatAdmin,deleteAdmin,ban,postInfo,see,updateV ");
			strSql.Append(" FROM admin ");
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
			parameters[0].Value = "admin";
			parameters[1].Value = "adminID";
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

