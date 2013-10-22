using System;
namespace Crowd.Model
{
	/// <summary>
	/// DICT_report:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DICT_report
	{
		public DICT_report()
		{}
		#region Model
		private int _id;
		private string _reportname;
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
		public string reportName
		{
			set{ _reportname=value;}
			get{return _reportname;}
		}
		#endregion Model

	}
}

