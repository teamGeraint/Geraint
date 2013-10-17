using System;
namespace Crowd.Model
{
	/// <summary>
	/// report:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class report
	{
		public report()
		{}
		#region Model
		private int _id;
		private int _userid;
		private int _publishid;
		private int _reportid;
		private string _reporttext;
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
		/// <summary>
		/// 
		/// </summary>
		public int reportID
		{
			set{ _reportid=value;}
			get{return _reportid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reportText
		{
			set{ _reporttext=value;}
			get{return _reporttext;}
		}
		#endregion Model

	}
}

