using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace MyAbpProject.AdminLogin.Dtos
{
    [Serializable]
    public class LoginRespose
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public ClaimsIdentity Identity { get; set; }
    }
}
