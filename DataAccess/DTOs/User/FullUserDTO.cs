using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs.User
{
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
}
