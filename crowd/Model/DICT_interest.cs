using System;
namespace Crowd.Model
{
	/// <summary>
	/// DICT_interest:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DICT_interest
	{
		public DICT_interest()
		{}
		#region Model
		private int _id;
		private string _insterestname;
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
		public string insterestName
		{
			set{ _insterestname=value;}
			get{return _insterestname;}
		}
		#endregion Model

	}
}

