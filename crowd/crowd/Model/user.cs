using System;
namespace Crowd.Model
{
    /// <summary>
    /// user:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class user
    {
        public user()
        { }
        #region Model
        private int _id;
        private int _userid;
        private string _username;
        private string _userpwd;
        private string _useremail;
        private DateTime? _birthday;
        private bool _sex;
        private string _gschool;
        private string _dschool;
        private string _company;
        private string _describe;
        private string _location;
        private string _profession;
        private int? _headimg;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int userID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userPwd
        {
            set { _userpwd = value; }
            get { return _userpwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userEmail
        {
            set { _useremail = value; }
            get { return _useremail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Gschool
        {
            set { _gschool = value; }
            get { return _gschool; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Dschool
        {
            set { _dschool = value; }
            get { return _dschool; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string company
        {
            set { _company = value; }
            get { return _company; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string describe
        {
            set { _describe = value; }
            get { return _describe; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string location
        {
            set { _location = value; }
            get { return _location; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string profession
        {
            set { _profession = value; }
            get { return _profession; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? headImg
        {
            set { _headimg = value; }
            get { return _headimg; }
        }
        #endregion Model

    }
}

