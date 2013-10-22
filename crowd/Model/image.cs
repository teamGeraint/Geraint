using System;
namespace Crowd.Model
{
	/// <summary>
	/// image:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class image
	{
		public image()
		{}
		#region Model
		private int _id;
		private string _smallimg;
		private string _bigimg;
		private int _publishid;
		private string _middleimg;
		private int? _photoid;
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
		public string smallImg
		{
			set{ _smallimg=value;}
			get{return _smallimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bigImg
		{
			set{ _bigimg=value;}
			get{return _bigimg;}
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
		public string middleImg
		{
			set{ _middleimg=value;}
			get{return _middleimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? photoID
		{
			set{ _photoid=value;}
			get{return _photoid;}
		}
		#endregion Model

	}
}

