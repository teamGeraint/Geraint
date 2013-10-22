using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Crowd.DAL
{
	/// <summary>
	/// 数据访问类:publish
	/// </summary>
	public partial class publish
	{
		public publish()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "publish"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from publish");
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
		public int Add(Crowd.Model.publish model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into publish(");
			strSql.Append("userID,text,video,music)");
			strSql.Append(" values (");
			strSql.Append("@userID,@text,@video,@music)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@text", SqlDbType.NVarChar,3000),
					new SqlParameter("@video", SqlDbType.NVarChar,500),
					new SqlParameter("@music", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.userID;
			parameters[1].Value = model.text;
			parameters[2].Value = model.video;
			parameters[3].Value = model.music;

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
		public bool Update(Crowd.Model.publish model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update publish set ");
			strSql.Append("userID=@userID,");
			strSql.Append("text=@text,");
			strSql.Append("video=@video,");
			strSql.Append("music=@music");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@text", SqlDbType.NVarChar,3000),
					new SqlParameter("@video", SqlDbType.NVarChar,500),
					new SqlParameter("@music", SqlDbType.NVarChar,500),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.userID;
			parameters[1].Value = model.text;
			parameters[2].Value = model.video;
			parameters[3].Value = model.music;
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
			strSql.Append("delete from publish ");
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
			strSql.Append("delete from publish ");
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
		public Crowd.Model.publish GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,userID,text,video,music from publish ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			Crowd.Model.publish model=new Crowd.Model.publish();
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
				if(ds.Tables[0].Rows[0]["text"]!=null && ds.Tables[0].Rows[0]["text"].ToString()!="")
				{
					model.text=ds.Tables[0].Rows[0]["text"].ToString();
				}
				if(ds.Tables[0].Rows[0]["video"]!=null && ds.Tables[0].Rows[0]["video"].ToString()!="")
				{
					model.video=ds.Tables[0].Rows[0]["video"].ToString();
				}
				if(ds.Tables[0].Rows[0]["music"]!=null && ds.Tables[0].Rows[0]["music"].ToString()!="")
				{
					model.music=ds.Tables[0].Rows[0]["music"].ToString();
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
			strSql.Append("select id,userID,text,video,music ");
			strSql.Append(" FROM publish ");
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
			strSql.Append(" id,userID,text,video,music ");
			strSql.Append(" FROM publish ");
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
			parameters[0].Value = "publish";
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

