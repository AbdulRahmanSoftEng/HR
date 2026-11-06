using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class UserDTO
    {
        public UserDTO(
            int userID,
            int employeeID,
            string employeeCode,
            string fullName,
            string username,
            int roleID,
            string roleName,
            bool isActive,
            DateTime createdAt)
        {
            UserID = userID;
            EmployeeID = employeeID;
            EmployeeCode = employeeCode;
            FullName = fullName;
            Username = username;
            RoleID = roleID;
            RoleName = roleName;
            IsActive = isActive;
            CreatedAt = createdAt;
        }

        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}