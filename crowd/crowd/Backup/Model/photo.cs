using System;
namespace Crowd.Model
{
	/// <summary>
	/// photo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class photo
	{
		public photo()
		{}
		#region Model
		private int _id;
		private int _userid;
		private string _photoname;
		private int _photoclass;
		private string _photodesc;
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
		public string photoName
		{
			set{ _photoname=value;}
			get{return _photoname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int photoClass
		{
			set{ _photoclass=value;}
			get{return _photoclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string photoDesc
		{
			set{ _photodesc=value;}
			get{return _photodesc;}
		}
		#endregion Model

	}
}

