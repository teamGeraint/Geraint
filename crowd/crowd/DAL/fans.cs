using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Crowd.DAL
{
	/// <summary>
	/// 数据访问类:fans
	/// </summary>
	public partial class fans
	{
		public fans()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "fans"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from fans");
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
		public int Add(Crowd.Model.fans model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into fans(");
			strSql.Append("userID,fansID,remarkName,Sfocus)");
			strSql.Append(" values (");
			strSql.Append("@userID,@fansID,@remarkName,@Sfocus)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@fansID", SqlDbType.Int,4),
					new SqlParameter("@remarkName", SqlDbType.VarChar,50),
					new SqlParameter("@Sfocus", SqlDbType.Bit,1)};
			parameters[0].Value = model.userID;
			parameters[1].Value = model.fansID;
			parameters[2].Value = model.remarkName;
			parameters[3].Value = model.Sfocus;

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
		public bool Update(Crowd.Model.fans model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update fans set ");
			strSql.Append("userID=@userID,");
			strSql.Append("fansID=@fansID,");
			strSql.Append("remarkName=@remarkName,");
			strSql.Append("Sfocus=@Sfocus");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@fansID", SqlDbType.Int,4),
					new SqlParameter("@remarkName", SqlDbType.VarChar,50),
					new SqlParameter("@Sfocus", SqlDbType.Bit,1),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.userID;
			parameters[1].Value = model.fansID;
			parameters[2].Value = model.remarkName;
			parameters[3].Value = model.Sfocus;
			parameters[4].Value = model.id;

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
			strSql.Append("delete from fans ");
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
			strSql.Append("delete from fans ");
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
		public Crowd.Model.fans GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,userID,fansID,remarkName,Sfocus from fans ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			Crowd.Model.fans model=new Crowd.Model.fans();
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
				if(ds.Tables[0].Rows[0]["fansID"]!=null && ds.Tables[0].Rows[0]["fansID"].ToString()!="")
				{
					model.fansID=int.Parse(ds.Tables[0].Rows[0]["fansID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["remarkName"]!=null && ds.Tables[0].Rows[0]["remarkName"].ToString()!="")
				{
					model.remarkName=ds.Tables[0].Rows[0]["remarkName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Sfocus"]!=null && ds.Tables[0].Rows[0]["Sfocus"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["Sfocus"].ToString()=="1")||(ds.Tables[0].Rows[0]["Sfocus"].ToString().ToLower()=="true"))
					{
						model.Sfocus=true;
					}
					else
					{
						model.Sfocus=false;
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
			strSql.Append("select id,userID,fansID,remarkName,Sfocus ");
			strSql.Append(" FROM fans ");
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
			strSql.Append(" id,userID,fansID,remarkName,Sfocus ");
			strSql.Append(" FROM fans ");
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
			parameters[0].Value = "fans";
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

