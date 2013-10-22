using System;
namespace Crowd.Model
{
	/// <summary>
	/// admin:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class admin
	{
		public admin()
		{}
		#region Model
		private string _adminid;
		private string _adminname;
		private string _adminpwd;
		private bool _creatadmin;
		private bool _deleteadmin;
		private bool _ban;
		private bool _postinfo;
		private bool _see;
		private bool _updatev;
		/// <summary>
		/// 
		/// </summary>
		public string adminID
		{
			set{ _adminid=value;}
			get{return _adminid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminName
		{
			set{ _adminname=value;}
			get{return _adminname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string adminPwd
		{
			set{ _adminpwd=value;}
			get{return _adminpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool creatAdmin
		{
			set{ _creatadmin=value;}
			get{return _creatadmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool deleteAdmin
		{
			set{ _deleteadmin=value;}
			get{return _deleteadmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool ban
		{
			set{ _ban=value;}
			get{return _ban;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool postInfo
		{
			set{ _postinfo=value;}
			get{return _postinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool see
		{
			set{ _see=value;}
			get{return _see;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool updateV
		{
			set{ _updatev=value;}
			get{return _updatev;}
		}
		#endregion Model

	}
}

