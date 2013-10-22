using System;
namespace Crowd.Model
{
	/// <summary>
	/// messageInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class messageInfo
	{
		public messageInfo()
		{}
		#region Model
		private int _id;
		private string _message;
		private int _receiveid;
		private int _sendid;
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
		public string message
		{
			set{ _message=value;}
			get{return _message;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int receiveID
		{
			set{ _receiveid=value;}
			get{return _receiveid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sendID
		{
			set{ _sendid=value;}
			get{return _sendid;}
		}
		#endregion Model

	}
}

