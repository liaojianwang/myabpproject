using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyAbpProject.CmsEntities
{
    [Table("ManagerInfo")]
    [Serializable]
    public class ManagerInfo : BaseEntity
    {
        #region Model
        private int _role_id = 0;
        private int _role_type = 2;
        private string _user_name = string.Empty;
        private string _password = string.Empty;
        private string _salt = string.Empty;
        private string _avatar = string.Empty;
        private string _real_name = string.Empty;
        private string _telephone = string.Empty;
        private string _email = string.Empty;
        private int _is_audit = 0;
        private int _is_lock = 0;

        /// <summary>
        /// 角色ID
        /// </summary>
        public int role_id
        {
            set { _role_id = value; }
            get { return _role_id; }
        }
        /// <summary>
        /// 管理员类型1超管2系管
        /// </summary>
        public int role_type
        {
            set { _role_type = value; }
            get { return _role_type; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string user_name
        {
            set { _user_name = value; }
            get { return _user_name; }
        }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 6位随机字符串,加密用到
        /// </summary>
        public string salt
        {
            set { _salt = value; }
            get { return _salt; }
        }
        /// <summary>
        /// 管理员头像
        /// </summary>
        public string avatar
        {
            set { _avatar = value; }
            get { return _avatar; }
        }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string real_name
        {
            set { _real_name = value; }
            get { return _real_name; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string telephone
        {
            set { _telephone = value; }
            get { return _telephone; }
        }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 信息是否要审核
        /// </summary>
        public int is_audit
        {
            set { _is_audit = value; }
            get { return _is_audit; }
        }
        /// <summary>
        /// 是否锁定
        /// </summary>
        public int is_lock
        {
            set { _is_lock = value; }
            get { return _is_lock; }
        }
        #endregion

    }
}
