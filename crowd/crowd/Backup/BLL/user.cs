using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Crowd.Model;
namespace Crowd.BLL
{
	/// <summary>
	/// user
	/// </summary>
	public partial class user
	{
		private readonly Crowd.DAL.user dal=new Crowd.DAL.user();
		public user()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Crowd.Model.user model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Crowd.Model.user model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Crowd.Model.user GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Crowd.Model.user GetModelByCache(int id)
		{
			
			string CacheKey = "userModel-" + id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Crowd.Model.user)objModel;
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
		public List<Crowd.Model.user> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Crowd.Model.user> DataTableToList(DataTable dt)
		{
			List<Crowd.Model.user> modelList = new List<Crowd.Model.user>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Crowd.Model.user model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Crowd.Model.user();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["userID"]!=null && dt.Rows[n]["userID"].ToString()!="")
					{
						model.userID=int.Parse(dt.Rows[n]["userID"].ToString());
					}
					if(dt.Rows[n]["userName"]!=null && dt.Rows[n]["userName"].ToString()!="")
					{
					model.userName=dt.Rows[n]["userName"].ToString();
					}
					if(dt.Rows[n]["userPwd"]!=null && dt.Rows[n]["userPwd"].ToString()!="")
					{
					model.userPwd=dt.Rows[n]["userPwd"].ToString();
					}
					if(dt.Rows[n]["userEmail"]!=null && dt.Rows[n]["userEmail"].ToString()!="")
					{
					model.userEmail=dt.Rows[n]["userEmail"].ToString();
					}
					if(dt.Rows[n]["birthday"]!=null && dt.Rows[n]["birthday"].ToString()!="")
					{
						model.birthday=DateTime.Parse(dt.Rows[n]["birthday"].ToString());
					}
					if(dt.Rows[n]["sex"]!=null && dt.Rows[n]["sex"].ToString()!="")
					{
						if((dt.Rows[n]["sex"].ToString()=="1")||(dt.Rows[n]["sex"].ToString().ToLower()=="true"))
						{
						model.sex=true;
						}
						else
						{
							model.sex=false;
						}
					}
					if(dt.Rows[n]["Gschool"]!=null && dt.Rows[n]["Gschool"].ToString()!="")
					{
					model.Gschool=dt.Rows[n]["Gschool"].ToString();
					}
					if(dt.Rows[n]["Dschool"]!=null && dt.Rows[n]["Dschool"].ToString()!="")
					{
					model.Dschool=dt.Rows[n]["Dschool"].ToString();
					}
					if(dt.Rows[n]["company"]!=null && dt.Rows[n]["company"].ToString()!="")
					{
					model.company=dt.Rows[n]["company"].ToString();
					}
					if(dt.Rows[n]["describe"]!=null && dt.Rows[n]["describe"].ToString()!="")
					{
					model.describe=dt.Rows[n]["describe"].ToString();
					}
					if(dt.Rows[n]["location"]!=null && dt.Rows[n]["location"].ToString()!="")
					{
					model.location=dt.Rows[n]["location"].ToString();
					}
					if(dt.Rows[n]["profession"]!=null && dt.Rows[n]["profession"].ToString()!="")
					{
					model.profession=dt.Rows[n]["profession"].ToString();
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

