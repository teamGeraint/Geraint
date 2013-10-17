using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Crowd.Model;
namespace Crowd.BLL
{
	/// <summary>
	/// publish
	/// </summary>
	public partial class publish
	{
		private readonly Crowd.DAL.publish dal=new Crowd.DAL.publish();
		public publish()
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
		public int  Add(Crowd.Model.publish model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Crowd.Model.publish model)
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
		public Crowd.Model.publish GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Crowd.Model.publish GetModelByCache(int id)
		{
			
			string CacheKey = "publishModel-" + id;
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
			return (Crowd.Model.publish)objModel;
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
		public List<Crowd.Model.publish> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Crowd.Model.publish> DataTableToList(DataTable dt)
		{
			List<Crowd.Model.publish> modelList = new List<Crowd.Model.publish>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Crowd.Model.publish model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Crowd.Model.publish();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["userID"]!=null && dt.Rows[n]["userID"].ToString()!="")
					{
						model.userID=int.Parse(dt.Rows[n]["userID"].ToString());
					}
					if(dt.Rows[n]["text"]!=null && dt.Rows[n]["text"].ToString()!="")
					{
					model.text=dt.Rows[n]["text"].ToString();
					}
					if(dt.Rows[n]["video"]!=null && dt.Rows[n]["video"].ToString()!="")
					{
					model.video=dt.Rows[n]["video"].ToString();
					}
					if(dt.Rows[n]["music"]!=null && dt.Rows[n]["music"].ToString()!="")
					{
					model.music=dt.Rows[n]["music"].ToString();
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

