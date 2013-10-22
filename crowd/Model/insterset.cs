using System;
namespace Crowd.Model
{
	/// <summary>
	/// insterset:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class insterset
	{
		public insterset()
		{}
		#region Model
		private int _id;
		private int _interestid;
		private int _userid;
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
		public int interestID
		{
			set{ _interestid=value;}
			get{return _interestid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int userID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		#endregion Model

	}
}

