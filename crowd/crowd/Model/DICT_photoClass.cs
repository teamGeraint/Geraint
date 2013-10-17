using System;
namespace Crowd.Model
{
	/// <summary>
	/// DICT_photoClass:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DICT_photoClass
	{
		public DICT_photoClass()
		{}
		#region Model
		private int _id;
		private string _classsname;
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
		public string classsName
		{
			set{ _classsname=value;}
			get{return _classsname;}
		}
		#endregion Model

	}
}

