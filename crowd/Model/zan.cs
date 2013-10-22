using System;
namespace Crowd.Model
{
	/// <summary>
	/// zan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class zan
	{
		public zan()
		{}
		#region Model
		private int _id;
		private int _userid;
		private int _publishid;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int userID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int publishID
		{
			set{ _publishid=value;}
			get{return _publishid;}
		}
		#endregion Model

	}
}

