using System;
namespace Crowd.Model
{
	/// <summary>
	/// web:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class web
	{
		public web()
		{}
		#region Model
		private int _id;
		private string _webname;
		private string _author;
		private string _version;
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
		public string webName
		{
			set{ _webname=value;}
			get{return _webname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Author
		{
			set{ _author=value;}
			get{return _author;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string version
		{
			set{ _version=value;}
			get{return _version;}
		}
		#endregion Model

	}
}

