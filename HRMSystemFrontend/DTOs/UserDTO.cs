using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystemFrontend.DTOs
{
        public class UserDTO
        {
            public int UserID { get; set; }
            public int EmployeeID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public bool IsActive { get; set; }
            public int RoleID { get; set; }
            public DateTime CreatedAt { get; set; }
        }

  
        public class FullUserDTO
        {
            public int UserID { get; set; }
            public int EmployeeID { get; set; }
            public string Username { get; set; }
            public bool IsActive { get; set; }
            public int RoleID { get; set; }
            public DateTime CreatedAt { get; set; }
            public string EmployeeCode { get; set; }
            public string FullName { get; set; }
            public string RoleName { get; set; }
            public bool EmployeeIsActive { get; set; }

        }

        public class LoginDTO
    {
            public int UserID { get; set; }
            public int EmployeeID { get; set; }
            public string Username { get; set; }
            public bool IsActive { get; set; }
            public int RoleID { get; set; }
            public DateTime CreatedAt { get; set; }
            public string EmployeeCode { get; set; }
            public string PasswordHash { get; set; }
            public string FullName { get; set; }
            public string RoleName { get; set; }
            public bool EmployeeIsActive { get; set; }

        }

        public class UserLoginInfo
        {
            public int UserID { get; set; }
            public string FullName { get; set; }
            public string RoleName { get; set; }
        }

}