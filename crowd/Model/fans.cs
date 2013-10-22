using System;
namespace Crowd.Model
{
	/// <summary>
	/// fans:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class fans
	{
		public fans()
		{}
		#region Model
		private int _id;
		private int _userid;
		private int _fansid;
		private string _remarkname;
		private bool _sfocus;
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
		public int fansID
		{
			set{ _fansid=value;}
			get{return _fansid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remarkName
		{
			set{ _remarkname=value;}
			get{return _remarkname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Sfocus
		{
			set{ _sfocus=value;}
			get{return _sfocus;}
		}
		#endregion Model

	}
}

