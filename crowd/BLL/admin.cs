using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Crowd.Model;
namespace Crowd.BLL
{
	/// <summary>
	/// admin
	/// </summary>
	public partial class admin
	{
		private readonly Crowd.DAL.admin dal=new Crowd.DAL.admin();
		public admin()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string adminID)
		{
			return dal.Exists(adminID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Crowd.Model.admin model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Crowd.Model.admin model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string adminID)
		{
			
			return dal.Delete(adminID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string adminIDlist )
		{
			return dal.DeleteList(adminIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Crowd.Model.admin GetModel(string adminID)
		{
			
			return dal.GetModel(adminID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Crowd.Model.admin GetModelByCache(string adminID)
		{
			
			string CacheKey = "adminModel-" + adminID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(adminID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Crowd.Model.admin)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Crowd.Model.admin> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Crowd.Model.admin> DataTableToList(DataTable dt)
		{
			List<Crowd.Model.admin> modelList = new List<Crowd.Model.admin>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Crowd.Model.admin model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Crowd.Model.admin();
					if(dt.Rows[n]["adminID"]!=null && dt.Rows[n]["adminID"].ToString()!="")
					{
					model.adminID=dt.Rows[n]["adminID"].ToString();
					}
					if(dt.Rows[n]["adminName"]!=null && dt.Rows[n]["adminName"].ToString()!="")
					{
					model.adminName=dt.Rows[n]["adminName"].ToString();
					}
					if(dt.Rows[n]["adminPwd"]!=null && dt.Rows[n]["adminPwd"].ToString()!="")
					{
					model.adminPwd=dt.Rows[n]["adminPwd"].ToString();
					}
					if(dt.Rows[n]["creatAdmin"]!=null && dt.Rows[n]["creatAdmin"].ToString()!="")
					{
						if((dt.Rows[n]["creatAdmin"].ToString()=="1")||(dt.Rows[n]["creatAdmin"].ToString().ToLower()=="true"))
						{
						model.creatAdmin=true;
						}
						else
						{
							model.creatAdmin=false;
						}
					}
					if(dt.Rows[n]["deleteAdmin"]!=null && dt.Rows[n]["deleteAdmin"].ToString()!="")
					{
						if((dt.Rows[n]["deleteAdmin"].ToString()=="1")||(dt.Rows[n]["deleteAdmin"].ToString().ToLower()=="true"))
						{
						model.deleteAdmin=true;
						}
						else
						{
							model.deleteAdmin=false;
						}
					}
					if(dt.Rows[n]["ban"]!=null && dt.Rows[n]["ban"].ToString()!="")
					{
						if((dt.Rows[n]["ban"].ToString()=="1")||(dt.Rows[n]["ban"].ToString().ToLower()=="true"))
						{
						model.ban=true;
						}
						else
						{
							model.ban=false;
						}
					}
					if(dt.Rows[n]["postInfo"]!=null && dt.Rows[n]["postInfo"].ToString()!="")
					{
						if((dt.Rows[n]["postInfo"].ToString()=="1")||(dt.Rows[n]["postInfo"].ToString().ToLower()=="true"))
						{
						model.postInfo=true;
						}
						else
						{
							model.postInfo=false;
						}
					}
					if(dt.Rows[n]["see"]!=null && dt.Rows[n]["see"].ToString()!="")
					{
						if((dt.Rows[n]["see"].ToString()=="1")||(dt.Rows[n]["see"].ToString().ToLower()=="true"))
						{
						model.see=true;
						}
						else
						{
							model.see=false;
						}
					}
					if(dt.Rows[n]["updateV"]!=null && dt.Rows[n]["updateV"].ToString()!="")
					{
						if((dt.Rows[n]["updateV"].ToString()=="1")||(dt.Rows[n]["updateV"].ToString().ToLower()=="true"))
						{
						model.updateV=true;
						}
						else
						{
							model.updateV=false;
						}
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

