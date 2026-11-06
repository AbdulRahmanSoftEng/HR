using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class UserLoginDTO
    {
        public UserLoginDTO(
            int userID,
            int employeeID,
            string username,
            string passwordHash,
            int roleID,
            string roleName,
            bool isActive,
            string fullName,
            bool employeeIsActive)
        {
            UserID = userID;
            EmployeeID = employeeID;
            Username = username;
            PasswordHash = passwordHash;
            RoleID = roleID;
            RoleName = roleName;
            IsActive = isActive;
            FullName = fullName;
            EmployeeIsActive = employeeIsActive;
        }

        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public string FullName { get; set; }
        public bool EmployeeIsActive { get; set; }
    }
}