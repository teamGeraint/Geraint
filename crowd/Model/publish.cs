using System;
namespace Crowd.Model
{
	/// <summary>
	/// publish:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class publish
	{
		public publish()
		{}
		#region Model
		private int _id;
		private int _userid;
		private string _text;
		private string _video;
		private string _music;
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
		public string text
		{
			set{ _text=value;}
			get{return _text;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string video
		{
			set{ _video=value;}
			get{return _video;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string music
		{
			set{ _music=value;}
			get{return _music;}
		}
		#endregion Model

	}
}

