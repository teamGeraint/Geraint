using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Crowd.DAL
{
	/// <summary>
	/// 数据访问类:image
	/// </summary>
	public partial class image
	{
		public image()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "image"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from image");
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
		public int Add(Crowd.Model.image model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into image(");
			strSql.Append("smallImg,bigImg,publishID,middleImg,photoID)");
			strSql.Append(" values (");
			strSql.Append("@smallImg,@bigImg,@publishID,@middleImg,@photoID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@smallImg", SqlDbType.NVarChar,500),
					new SqlParameter("@bigImg", SqlDbType.NVarChar,500),
					new SqlParameter("@publishID", SqlDbType.Int,4),
					new SqlParameter("@middleImg", SqlDbType.NVarChar,500),
					new SqlParameter("@photoID", SqlDbType.Int,4)};
			parameters[0].Value = model.smallImg;
			parameters[1].Value = model.bigImg;
			parameters[2].Value = model.publishID;
			parameters[3].Value = model.middleImg;
			parameters[4].Value = model.photoID;

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
		public bool Update(Crowd.Model.image model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update image set ");
			strSql.Append("smallImg=@smallImg,");
			strSql.Append("bigImg=@bigImg,");
			strSql.Append("publishID=@publishID,");
			strSql.Append("middleImg=@middleImg,");
			strSql.Append("photoID=@photoID");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@smallImg", SqlDbType.NVarChar,500),
					new SqlParameter("@bigImg", SqlDbType.NVarChar,500),
					new SqlParameter("@publishID", SqlDbType.Int,4),
					new SqlParameter("@middleImg", SqlDbType.NVarChar,500),
					new SqlParameter("@photoID", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.smallImg;
			parameters[1].Value = model.bigImg;
			parameters[2].Value = model.publishID;
			parameters[3].Value = model.middleImg;
			parameters[4].Value = model.photoID;
			parameters[5].Value = model.id;

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
			strSql.Append("delete from image ");
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
			strSql.Append("delete from image ");
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
		public Crowd.Model.image GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,smallImg,bigImg,publishID,middleImg,photoID from image ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			Crowd.Model.image model=new Crowd.Model.image();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["smallImg"]!=null && ds.Tables[0].Rows[0]["smallImg"].ToString()!="")
				{
					model.smallImg=ds.Tables[0].Rows[0]["smallImg"].ToString();
				}
				if(ds.Tables[0].Rows[0]["bigImg"]!=null && ds.Tables[0].Rows[0]["bigImg"].ToString()!="")
				{
					model.bigImg=ds.Tables[0].Rows[0]["bigImg"].ToString();
				}
				if(ds.Tables[0].Rows[0]["publishID"]!=null && ds.Tables[0].Rows[0]["publishID"].ToString()!="")
				{
					model.publishID=int.Parse(ds.Tables[0].Rows[0]["publishID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["middleImg"]!=null && ds.Tables[0].Rows[0]["middleImg"].ToString()!="")
				{
					model.middleImg=ds.Tables[0].Rows[0]["middleImg"].ToString();
				}
				if(ds.Tables[0].Rows[0]["photoID"]!=null && ds.Tables[0].Rows[0]["photoID"].ToString()!="")
				{
					model.photoID=int.Parse(ds.Tables[0].Rows[0]["photoID"].ToString());
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
			strSql.Append("select id,smallImg,bigImg,publishID,middleImg,photoID ");
			strSql.Append(" FROM image ");
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
			strSql.Append(" id,smallImg,bigImg,publishID,middleImg,photoID ");
			strSql.Append(" FROM image ");
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
			parameters[0].Value = "image";
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

