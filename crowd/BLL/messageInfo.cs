﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Crowd.Model;
namespace Crowd.BLL
{
	/// <summary>
	/// messageInfo
	/// </summary>
	public partial class messageInfo
	{
		private readonly Crowd.DAL.messageInfo dal=new Crowd.DAL.messageInfo();
		public messageInfo()
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
		public int  Add(Crowd.Model.messageInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Crowd.Model.messageInfo model)
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
		public Crowd.Model.messageInfo GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Crowd.Model.messageInfo GetModelByCache(int id)
		{
			
			string CacheKey = "messageInfoModel-" + id;
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
			return (Crowd.Model.messageInfo)objModel;
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
		public List<Crowd.Model.messageInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Crowd.Model.messageInfo> DataTableToList(DataTable dt)
		{
			List<Crowd.Model.messageInfo> modelList = new List<Crowd.Model.messageInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Crowd.Model.messageInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Crowd.Model.messageInfo();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["message"]!=null && dt.Rows[n]["message"].ToString()!="")
					{
					model.message=dt.Rows[n]["message"].ToString();
					}
					if(dt.Rows[n]["receiveID"]!=null && dt.Rows[n]["receiveID"].ToString()!="")
					{
						model.receiveID=int.Parse(dt.Rows[n]["receiveID"].ToString());
					}
					if(dt.Rows[n]["sendID"]!=null && dt.Rows[n]["sendID"].ToString()!="")
					{
						model.sendID=int.Parse(dt.Rows[n]["sendID"].ToString());
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

