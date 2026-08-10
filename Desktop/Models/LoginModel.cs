using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetBrainDesktop.Models
{
    public class LoginModel
    {
        public class LoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        public class LoginResponse
        {
            public LoginUser? User { get; set; }
            public string AccessToken { get; set; }
            public string RefreshToken { get; set; }
        }

        public class LoginUser
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Role { get; set; }
        }
    }

}
