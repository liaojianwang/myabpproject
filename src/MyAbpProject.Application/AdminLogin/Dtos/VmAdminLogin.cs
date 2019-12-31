using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyAbpProject.AdminLogin.Dtos
{
    /// <summary>
    /// 后面登录页面模型
    /// </summary>
    public class VmAdminLogin
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        public string txtUserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        public string txtPassword { get; set; }

        /// <summary>
        /// 是否记住账号
        /// </summary>
        public bool RememberMe { get; set; }
    }
}
